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
using System.Threading;

namespace VisualProgramingProject.Forms
{
    public partial class Login_Form : Form
    {
        //public string serverName = @"ESLAMEZZAT\SQLEXPRESS";
        public string serverName = @"NOTEBOOK\MSSQLSERVER02";
        public string databaseName = "StudentDetails";
        public static SqlConnection sqlConnection;
        public static string connectionString = "";
        public Login_Form()
        {
            InitializeComponent();
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        bool checkCon = false;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "" && txtPassword.Text != "")
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
                    string password = "";
                    sql = $"Select StudentID from [StudentDetails] WHERE StudentID={int.Parse(txtID.Text)}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        ID = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    sql = $"Select Password from [StudentDetails]  WHERE StudentID={int.Parse(txtID.Text)}";
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        password = sqlDataReader.GetValue(0).ToString();
                    }
                    sqlDataReader.Close();
                    if (ID == txtID.Text && password == txtPassword.Text)
                    {
                        this.Hide();
                        Wait_Form waitForm = new Wait_Form();
                        waitForm.ShowDialog();
                        //waitForm.Show(this);
                        //Thread.Sleep(1000);
                        //waitForm.Close();
                        Home_Form f1 = new Home_Form();
                        f1.receivingID(int.Parse(txtID.Text));
                        f1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You Entered Wrong ID Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    //MessageBox.Show("Your Name Is : "+txtUsername.Text + "\n" + "Your Password Is :"+ txtPassword.Text);
                }
                else
                {
                    MessageBox.Show("Please,Fill The Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Wait_Form waitForm = new Wait_Form();
            waitForm.ShowDialog();
            Student_Record_Form st = new Student_Record_Form();
            st.ShowDialog();
            this.Close();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtID;
            notifyIcon1.ShowBalloonTip(10000);
            toolTip.SetToolTip(txtID, "Enter Your ID Here");
            toolTip.SetToolTip(txtPassword, "Enter Your Password Here");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help App is used for helping students in studying that collect all tools that the students use in one place " +
                "Like Calculator, Notepad , Paint , Browsing , and Links", "Information About Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
