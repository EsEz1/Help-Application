using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VisualProgramingProject.Connection;
using System.IO;

namespace VisualProgramingProject.Forms
{
    public partial class Student_Record_Form : Form
    {
        //public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string serverName = @"NOTEBOOK\MSSQLSERVER02";
        public string databaseName = "StudentDetails";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Student_Record_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        bool checkCon = false;
        private void SaveToDatabase_Click(object sender, EventArgs e)
        {
            if (studentId.Text != "" && studentName.Text != "" && studentAge.Text != "" && studentAddress.Text != "" && studentPassword.Text != ""
                && picPerson.Image != null)
            {
                try
                {
                    if (checkCon == false)
                    {
                        checkCon = true;
                        Connect connect = new Connect();
                        connect.db_ConnectionToDatabase(false, sqlConnection);
                    }
                    SqlCommand sqlCommand;
                    SqlDataReader sqlDataReader;
                    string sql = "";
                    string ID = "";
                    sql = $"Select StudentID from [StudentDetails] WHERE StudentID={int.Parse(studentId.Text)}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        ID = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 70;
                    progressBar1.Step = 10;
                    if (ID == "")
                    {
                        Directory.CreateDirectory("img");
                        picPerson.Image.Save("img/" + studentId.Text + ".jpg");
                        progressBar1.PerformStep();
                        SqlCommand cmd = new SqlCommand("insert into StudentDetails(StudentID,StudentName,StudentAge,StudentAddress,Password,Gender) Values (@StudentID,@StudentName,@StudentAge,@StudentAddress,@Password,@Gender)", sqlConnection);
                        cmd.Parameters.AddWithValue("@StudentID", int.Parse(studentId.Text));
                        progressBar1.PerformStep();
                        cmd.Parameters.AddWithValue("@StudentName", studentName.Text);
                        progressBar1.PerformStep();
                        cmd.Parameters.AddWithValue("@StudentAge", int.Parse(studentAge.Text));
                        progressBar1.PerformStep();
                        cmd.Parameters.AddWithValue("@StudentAddress", studentAddress.Text);
                        progressBar1.PerformStep();
                        cmd.Parameters.AddWithValue("@Password", int.Parse(studentPassword.Text));
                        progressBar1.PerformStep();
                        if (genderMale.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Gender", genderMale.Text);
                        }
                        else if (genderFemale.Checked)
                        {
                            cmd.Parameters.AddWithValue("@Gender", genderFemale.Text);
                        }
                        progressBar1.PerformStep();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account Created");
                        genderFemale.Checked = false;
                        genderMale.Checked = false;
                        studentName.Text = "";
                        studentId.Text = "";
                        studentAge.Text = "";
                        studentAddress.Text = "";
                        studentPassword.Text = "";
                        picPerson.Image = null;
                        progressBar1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("This ID Exist, Please Write Another One\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picPerson.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    studentId.Text = "";
                    studentName.Text = "";
                    studentAge.Text = "";
                    studentAddress.Text = "";
                    studentPassword.Text = "";
                    picPerson.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Please, Fill the Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                studentId.Text = "";
                studentName.Text = "";
                studentAge.Text = "";
                studentAddress.Text = "";
                studentPassword.Text = "";
                picPerson.Image = null;
            }
        }

        private void Student_Record_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = studentId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form login = new Login_Form();
            login.ShowDialog();
            this.Close();
        }
        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images|*.jpg;*.png;*.gif;*.bmp;*.jpeg";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picPerson.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            genderFemale.Checked = false;
            genderMale.Checked = false;
            studentName.Text = "";
            studentId.Text = "";
            studentAge.Text = "";
            studentAddress.Text = "";
            studentPassword.Text = "";
            picPerson.Image = null;
            progressBar1.Value = 0;
        }


    }
}
