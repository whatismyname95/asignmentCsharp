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

namespace Assignment
{
    public partial class stdDetail : Form
    {
        public UpdateForm updateForm;
        public stdDetail(string id, string name, string gender, string age, string stdClass)
        {
            InitializeComponent();
            updateStudentId.Text = id;
            updateStudentName.Text = name;
            updateStudentGender.Text = gender;
            updateStudentAge.Text = age;
            updateStudentClass.Text = stdClass;
            originId.Text = id;
        }

        private void updateStudentEvent(object sender, EventArgs e)
        {
            DBConnection.Instance().OpenConnection(); // Xác Định kết nối đến DB
            string id = updateStudentId.Text;
            string name = updateStudentName.Text;
            string gender = updateStudentGender.Text;
            int age = Int32.Parse(updateStudentAge.Text);
            string stdClass = updateStudentClass.Text;

            Student newStudent = new Student(id, name, age, gender, stdClass);
            var sqlQuery = "UPDATE `students` SET `name`=@name,`ID`=@id,`Age`=@age,`Gender`=@gender,`StudentClass`=@stdClass WHERE `ID` = @location";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            cmd.Parameters.AddWithValue("@name", newStudent.Name);
            cmd.Parameters.AddWithValue("@id", newStudent.Id);
            cmd.Parameters.AddWithValue("@age", newStudent.Age);
            cmd.Parameters.AddWithValue("@gender", newStudent.Gender);
            cmd.Parameters.AddWithValue("@stdClass", newStudent.Stdclass1);
            cmd.Parameters.AddWithValue("@location", originId.Text);
            cmd.ExecuteNonQuery();
            DBConnection.Instance().CloseConnection();
            MessageBox.Show("Updated");
            updateForm.onUpdate();

            Close();
        }

        private void deleteStudentEvent(object sender, EventArgs e)
        {
            DBConnection.Instance().OpenConnection();

            var sqlQuery = "DELETE FROM `students` WHERE `id` = '" + originId.Text + "'";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            cmd.ExecuteNonQuery();
            DBConnection.Instance().CloseConnection();
            MessageBox.Show("Deleted!!");

            updateForm.onUpdate();

            Close();
        }
    }
}
