using Assignment;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform;

namespace Winform
{
    public partial class classDetail : Form
    {
        public UpdateForm updateForm { get; set; }

        public classDetail(string name, string floor, string maxCapicity, string description)
        {
            InitializeComponent();
            classUpdateName.Text = name;
            classUpdateFloor.Text = floor;
            classUpdateCapitity.Text = maxCapicity;
            classUpdateDescription.Text = description;
            originClassName.Text = name;
        }

        private void UpdateClassBtn1(object sender, EventArgs e)
        {
            DBConnection.Instance().OpenConnection(); // Xác Định kết nối đến DB

            string name = classUpdateName.Text;
            int floor = Int32.Parse(classUpdateFloor.Text);
            int capicity = Int32.Parse(classUpdateCapitity.Text);
            string description = classUpdateDescription.Text;
            StdClass class1 = new StdClass(name, floor, capicity, description);
            var sqlQuery = "UPDATE `stdclass` " +
                           "SET `name`=@name,`floor`=@floor,`MaxCapicity`=@capicity,`Ddescription`=@description" +
                           " WHERE `name`=@location";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            cmd.Parameters.AddWithValue("@name", class1.Name);
            cmd.Parameters.AddWithValue("@floor", class1.Floor);
            cmd.Parameters.AddWithValue("@capicity", class1.MaxCapicity);
            cmd.Parameters.AddWithValue("@description", class1.Description);
            cmd.Parameters.AddWithValue("@location", originClassName.Text);
            cmd.ExecuteNonQuery();
            DBConnection.Instance().CloseConnection();
            MessageBox.Show("Updated");

            updateForm.onUpdate();

            Close();
        }
    }
}
