using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualProgramingProject.Connection;
using System.Data.SqlClient;
using VisualProgramingProject.Forms;
using System.IO;
using HelpApp.Forms;

namespace VisualProgramingProject
{
    public partial class Home_Form : Form
    {
        //public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string serverName = @"TAREKFAYEZ\SQLEXPRESS";
        public string databaseName = "Student";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";

        public Home_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }






        public void ShowForm(object form)
        {
            panelformularios.Controls.Clear();
            Form frm = form as Form;
            frm.TopLevel = false;
            panelformularios.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }




        private void btnCalculat_Click_1(object sender, EventArgs e)
        {
            ShowForm(new Calculator_Form());
        }

        private void btn_Note_Click(object sender, EventArgs e)
        {
            ShowForm(new Note_Form());
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            ShowForm(new Search_Form());
        }
        private void btn_Paint_Click(object sender, EventArgs e)
        {
            ShowForm(new Paint_Form());
        }
        private void btn_Links_Click(object sender, EventArgs e)
        {
            ShowForm(new Links_Form());
        }
        private void btn_Alarm_Click(object sender, EventArgs e)
        {
            ShowForm(new Alarm());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panelformularios.Controls.Clear();
        }

        int ID;
        public void receivingID(int ID)
        {
            this.ID = ID;
        }



        bool checkCon = false;
        private void Home_Form_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/M/yyyy");
            lblTime.Text = DateTime.Now.ToString("h:mm tt");
            if (checkCon == false)
            {
                checkCon = true;
                Connect connect = new Connect();
                connect.db_ConnectionToDatabase(false, sqlConnection);
            }
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            string sql = "";
            sql = $"Select StudentID,StudentName from [StudentDetails] WHERE StudentID = {ID}";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblID.Text = sqlDataReader.GetValue(0).ToString();
                lblName.Text = sqlDataReader.GetValue(1).ToString();

                string myPath = "img/" + lblID.Text + ".jpg";
                if (File.Exists(myPath))
                    picPerson.Image = Image.FromFile(myPath);

            }
            sqlDataReader.Close();

        }


        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wait_Form wait = new Wait_Form();
            wait.ShowDialog();
            Login_Form log = new Login_Form();
            log.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
