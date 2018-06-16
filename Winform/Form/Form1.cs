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
using Assignment;

namespace Assignment
{
    public partial class Form1 : Form, UpdateForm
    {
        public Form1()
        {
            InitializeComponent();
            showStdClass();
            showStudent();


        }





        private void button_add(object sender, EventArgs e)
        {
            DBConnection.Instance().OpenConnection(); // Xác Định kết nối đến DB

            string name = className.Text;
            int floor = Int32.Parse(classFloor.Text);
            int capicity = Int32.Parse(classCapitity.Text);
            string description = classDescription.Text;
            StdClass class1 = new StdClass(name, floor, capicity, description);
            var sqlQuery = "INSERT INTO `stdclass`(`name`, `floor`, `MaxCapicity`, `Ddescription`) " +
                "VALUES " +
                "(@name,@floor,@capicity,@description)";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            cmd.Parameters.AddWithValue("@name", class1.Name);
            cmd.Parameters.AddWithValue("@floor", class1.Floor);
            cmd.Parameters.AddWithValue("@capicity", class1.MaxCapicity);
            cmd.Parameters.AddWithValue("@description", class1.Description);
            cmd.ExecuteNonQuery();
            DBConnection.Instance().CloseConnection();
            showStdClass();
            MessageBox.Show("Add!!!");
        }


        void showStdClass()
        {
            DBConnection.Instance().OpenConnection();
            var sqlQuery = "SELECT * FROM `stdclass`";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            DBConnection.Instance().CloseConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ClassViewList.DataSource = dt;


        }

        private void ClassViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteClass(object sender, EventArgs e)
        {
            DBConnection.Instance().OpenConnection();
            int selectedRowIndex = Int32.Parse(ClassViewList.SelectedCells[0].RowIndex.ToString());
            var numb = ClassViewList.Rows[selectedRowIndex];
            var sqlQuery = "DELETE FROM `stdclass` WHERE `name` = '" + numb.Cells[0].Value.ToString() + "'";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            cmd.ExecuteNonQuery();
            DBConnection.Instance().CloseConnection();
            MessageBox.Show("Deleted!!");
            showStdClass();
        }

        private void AddStudentBtn(object sender, EventArgs e)
        {
            DBConnection.Instance().OpenConnection(); // Xác Định kết nối đến DB
            string id = studentId.Text;
            string name = studentName.Text;
            string gender = studentGender.Text;
            int age = Int32.Parse(studentAge.Text);
            string stdClass = _studentClass.Text;
            Student newstudent = new Student(id, name, age, gender, stdClass);
            var sqlQuery = "INSERT INTO `students`(`name`, `ID`, `Age`, `Gender`, `StudentClass`) " +
                "VALUES " +
                "(@name,@id,@age,@gender,@studentClass)";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            cmd.Parameters.AddWithValue("@name", newstudent.Name);
            cmd.Parameters.AddWithValue("@id", newstudent.Id);
            cmd.Parameters.AddWithValue("@age", newstudent.Age);
            cmd.Parameters.AddWithValue("@gender", newstudent.Gender);
            cmd.Parameters.AddWithValue("@studentClass", newstudent.Stdclass1);
            cmd.ExecuteNonQuery();
            DBConnection.Instance().CloseConnection();
            MessageBox.Show("Added!!!");
            showStudent();
        }
        void showStudent()
        {
            DBConnection.Instance().OpenConnection();
            var sqlQuery = "SELECT * FROM `students`";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            var data = cmd.ExecuteReader();
            DBConnection.Instance().CloseConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            studentViewList.DataSource = dt;
        }

        private void DeleteStudentBtn(object sender, EventArgs e)
        {
            DBConnection.Instance().OpenConnection();
            int selectedRowIndex = Int32.Parse(ClassViewList.SelectedCells[0].RowIndex.ToString());
            var numb = studentViewList.Rows[selectedRowIndex];
            var sqlQuery = "DELETE FROM `students` WHERE `id` = '" + numb.Cells[1].Value.ToString() + "'";
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            cmd.ExecuteNonQuery();
            DBConnection.Instance().CloseConnection();
            MessageBox.Show("Deleted");
            showStudent();

        }

       

        private void cellClassEventClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = Int32.Parse(ClassViewList.SelectedCells[0].RowIndex.ToString());
            var numb = ClassViewList.Rows[selectedRowIndex];
            var classDetailInfo = new classDetail(numb.Cells[0].Value.ToString(),
                                                  numb.Cells[1].Value.ToString(),
                                                  numb.Cells[2].Value.ToString(),
                                                  numb.Cells[3].Value.ToString()
                                                  );
            classDetailInfo.updateForm = this;
            classDetailInfo.Show(this);
        }

        private void updateClassBtn(object sender, EventArgs e)
        {

            int selectedRowIndex = Int32.Parse(ClassViewList.SelectedCells[0].RowIndex.ToString());
            var numb = ClassViewList.Rows[selectedRowIndex];
            var classDetailInfo = new classDetail(numb.Cells[0].Value.ToString(),
                                                  numb.Cells[1].Value.ToString(),
                                                  numb.Cells[2].Value.ToString(),
                                                  numb.Cells[3].Value.ToString()
                                                  );
            classDetailInfo.updateForm = this;
            classDetailInfo.Show(this);


        }

        public void onUpdate()
        {
            showStdClass();
            showStudent();
        }

        private void updateStudentBtn(object sender, EventArgs e)
        {

            int selectedRowIndex = Int32.Parse(studentViewList.SelectedCells[0].RowIndex.ToString());
            var numb = studentViewList.Rows[selectedRowIndex];
            var studentDetailInfo = new stdDetail(numb.Cells[1].Value.ToString(),
                                                  numb.Cells[0].Value.ToString(),
                                                  numb.Cells[3].Value.ToString(),
                                                  numb.Cells[2].Value.ToString(),
                                                  numb.Cells[4].Value.ToString()
                                                  );
            studentDetailInfo.updateForm = this;
            studentDetailInfo.Show(this);
        }

        private void cellStudentDetailEvent(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = Int32.Parse(studentViewList.SelectedCells[0].RowIndex.ToString());
            var numb = studentViewList.Rows[selectedRowIndex];
            var studentDetailInfo = new stdDetail(numb.Cells[1].Value.ToString(),
                                                  numb.Cells[0].Value.ToString(),
                                                  numb.Cells[3].Value.ToString(),
                                                  numb.Cells[2].Value.ToString(),
                                                  numb.Cells[4].Value.ToString()
                                                  );
            studentDetailInfo.updateForm = this;
            studentDetailInfo.Show(this);
        }

        void showClassBySearch(string key, string value)
        {
            DBConnection.Instance().OpenConnection();
            var sqlQuery = "SELECT * FROM `stdclass` WHERE `" + key + "` =" + value;
            var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
            DBConnection.Instance().CloseConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ClassViewList.DataSource = dt;
        }
        void showStudentBySearch(string key, string value)
        {
            if (key.Equals("name"))
            {
                DBConnection.Instance().OpenConnection();
                var sqlQuery = "SELECT * FROM `students` WHERE `" + key + "` LIKE '%" + value + "%'";
                var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
                var data = cmd.ExecuteReader();
                DBConnection.Instance().CloseConnection();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                studentViewList.DataSource = dt;
            }
            else
            {
                DBConnection.Instance().OpenConnection();
                var sqlQuery = "SELECT * FROM `students` WHERE `" + key + "` = '" + value + "'";
                var cmd = new MySqlCommand(sqlQuery, DBConnection.Instance().Connection);
                var data = cmd.ExecuteReader();
                DBConnection.Instance().CloseConnection();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                studentViewList.DataSource = dt;
            }
        }

        private void classSearchEvent(object sender, EventArgs e)
        {
            if (floorRadio.Checked)
            {
                showClassBySearch("floor", classSearchInput.Text);
            }
            else if (nameRadio.Checked)
            {
                showClassBySearch("name", "'" + classSearchInput.Text + "'");
            }
        }

        private void studentSearchEvent(object sender, EventArgs e)
        {
            if (idRadio.Checked)
            {
                showStudentBySearch("ID", studentSearchInput.Text);
            }
            else if (studentNameRadio.Checked)
            {
                showStudentBySearch("name", studentSearchInput.Text);
            }
        }
    }
}
