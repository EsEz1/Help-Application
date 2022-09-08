
namespace VisualProgramingProject.Forms
{
    partial class Student_Record_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Record_Form));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.picPerson = new Guna.UI2.WinForms.Guna2PictureBox();
            this.studentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.studentId = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.genderMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnSelectPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.SaveToDatabase = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Student Address";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Student Age";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(729, 64);
            this.label5.TabIndex = 35;
            this.label5.Text = "Record Student Data";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Student ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Password";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel.Controls.Add(this.progressBar1);
            this.panel.Controls.Add(this.picPerson);
            this.panel.Controls.Add(this.studentPassword);
            this.panel.Controls.Add(this.studentAddress);
            this.panel.Controls.Add(this.studentAge);
            this.panel.Controls.Add(this.studentName);
            this.panel.Controls.Add(this.studentId);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.btnSelectPhoto);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(729, 460);
            this.panel.TabIndex = 46;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 409);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(679, 34);
            this.progressBar1.TabIndex = 46;
            // 
            // picPerson
            // 
            this.picPerson.BorderRadius = 70;
            this.picPerson.ImageRotate = 0F;
            this.picPerson.Location = new System.Drawing.Point(515, 77);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(194, 206);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerson.TabIndex = 45;
            this.picPerson.TabStop = false;
            this.toolTip.SetToolTip(this.picPerson, "Please Select Your Photo");
            // 
            // studentPassword
            // 
            this.studentPassword.BorderRadius = 10;
            this.studentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentPassword.DefaultText = "";
            this.studentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPassword.ForeColor = System.Drawing.Color.Black;
            this.studentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentPassword.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.studentPassword.Location = new System.Drawing.Point(255, 368);
            this.studentPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentPassword.MaxLength = 1000;
            this.studentPassword.Name = "studentPassword";
            this.studentPassword.PasswordChar = '●';
            this.studentPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.studentPassword.PlaceholderText = "";
            this.studentPassword.SelectedText = "";
            this.studentPassword.Size = new System.Drawing.Size(252, 32);
            this.studentPassword.TabIndex = 6;
            this.toolTip.SetToolTip(this.studentPassword, "Please Enter Your Password");
            this.studentPassword.UseSystemPasswordChar = true;
            // 
            // studentAddress
            // 
            this.studentAddress.BorderRadius = 10;
            this.studentAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentAddress.DefaultText = "";
            this.studentAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAddress.ForeColor = System.Drawing.Color.Black;
            this.studentAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentAddress.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentAddress.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.studentAddress.Location = new System.Drawing.Point(255, 246);
            this.studentAddress.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentAddress.MaxLength = 70;
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.PasswordChar = '\0';
            this.studentAddress.PlaceholderForeColor = System.Drawing.Color.Black;
            this.studentAddress.PlaceholderText = "";
            this.studentAddress.SelectedText = "";
            this.studentAddress.Size = new System.Drawing.Size(252, 32);
            this.studentAddress.TabIndex = 3;
            this.toolTip.SetToolTip(this.studentAddress, "Please Enter Your Address");
            // 
            // studentAge
            // 
            this.studentAge.BorderRadius = 10;
            this.studentAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentAge.DefaultText = "";
            this.studentAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentAge.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAge.ForeColor = System.Drawing.Color.Black;
            this.studentAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentAge.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentAge.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.studentAge.Location = new System.Drawing.Point(255, 198);
            this.studentAge.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentAge.MaxLength = 2;
            this.studentAge.Name = "studentAge";
            this.studentAge.PasswordChar = '\0';
            this.studentAge.PlaceholderForeColor = System.Drawing.Color.Black;
            this.studentAge.PlaceholderText = "";
            this.studentAge.SelectedText = "";
            this.studentAge.Size = new System.Drawing.Size(252, 32);
            this.studentAge.TabIndex = 2;
            this.toolTip.SetToolTip(this.studentAge, "Please Enter Your Age");
            // 
            // studentName
            // 
            this.studentName.BorderRadius = 10;
            this.studentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentName.DefaultText = "";
            this.studentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.ForeColor = System.Drawing.Color.Black;
            this.studentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentName.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentName.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.studentName.Location = new System.Drawing.Point(255, 139);
            this.studentName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentName.MaxLength = 15;
            this.studentName.Name = "studentName";
            this.studentName.PasswordChar = '\0';
            this.studentName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.studentName.PlaceholderText = "";
            this.studentName.SelectedText = "";
            this.studentName.Size = new System.Drawing.Size(252, 32);
            this.studentName.TabIndex = 1;
            this.toolTip.SetToolTip(this.studentName, "Please Enter Your Full Name");
            // 
            // studentId
            // 
            this.studentId.BorderRadius = 10;
            this.studentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentId.DefaultText = "";
            this.studentId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentId.ForeColor = System.Drawing.Color.Black;
            this.studentId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentId.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.studentId.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.studentId.Location = new System.Drawing.Point(255, 87);
            this.studentId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.studentId.MaxLength = 7;
            this.studentId.Name = "studentId";
            this.studentId.PasswordChar = '\0';
            this.studentId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.studentId.PlaceholderText = "";
            this.studentId.SelectedText = "";
            this.studentId.Size = new System.Drawing.Size(252, 32);
            this.studentId.TabIndex = 0;
            this.toolTip.SetToolTip(this.studentId, "Please Enter Your ID");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderFemale);
            this.groupBox1.Controls.Add(this.genderMale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 72);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // genderFemale
            // 
            this.genderFemale.AutoSize = true;
            this.genderFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderFemale.CheckedState.BorderThickness = 0;
            this.genderFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.genderFemale.CheckedState.InnerOffset = -4;
            this.genderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderFemale.Location = new System.Drawing.Point(278, 28);
            this.genderFemale.Name = "genderFemale";
            this.genderFemale.Size = new System.Drawing.Size(113, 33);
            this.genderFemale.TabIndex = 5;
            this.genderFemale.Text = "Female";
            this.toolTip.SetToolTip(this.genderFemale, "Please Chose Your Gender Female");
            this.genderFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.genderFemale.UncheckedState.BorderThickness = 2;
            this.genderFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.genderFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // genderMale
            // 
            this.genderMale.AutoSize = true;
            this.genderMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderMale.CheckedState.BorderThickness = 0;
            this.genderMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.genderMale.CheckedState.InnerOffset = -4;
            this.genderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderMale.Location = new System.Drawing.Point(142, 28);
            this.genderMale.Name = "genderMale";
            this.genderMale.Size = new System.Drawing.Size(84, 33);
            this.genderMale.TabIndex = 4;
            this.genderMale.Text = "Male";
            this.toolTip.SetToolTip(this.genderMale, "Please Chose Your Gender Male");
            this.genderMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.genderMale.UncheckedState.BorderThickness = 2;
            this.genderMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.genderMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.BorderRadius = 20;
            this.btnSelectPhoto.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSelectPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectPhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectPhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectPhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectPhoto.FillColor = System.Drawing.Color.Navy;
            this.btnSelectPhoto.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPhoto.ForeColor = System.Drawing.Color.White;
            this.btnSelectPhoto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectPhoto.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSelectPhoto.Location = new System.Drawing.Point(515, 295);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(194, 53);
            this.btnSelectPhoto.TabIndex = 7;
            this.btnSelectPhoto.Text = "Select Photo";
            this.toolTip.SetToolTip(this.btnSelectPhoto, "Select Photo From File ");
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // SaveToDatabase
            // 
            this.SaveToDatabase.BorderRadius = 20;
            this.SaveToDatabase.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SaveToDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveToDatabase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveToDatabase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveToDatabase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveToDatabase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveToDatabase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveToDatabase.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToDatabase.ForeColor = System.Drawing.Color.White;
            this.SaveToDatabase.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveToDatabase.HoverState.ForeColor = System.Drawing.Color.Black;
            this.SaveToDatabase.Image = ((System.Drawing.Image)(resources.GetObject("SaveToDatabase.Image")));
            this.SaveToDatabase.Location = new System.Drawing.Point(54, 466);
            this.SaveToDatabase.Name = "SaveToDatabase";
            this.SaveToDatabase.Size = new System.Drawing.Size(103, 53);
            this.SaveToDatabase.TabIndex = 8;
            this.SaveToDatabase.Text = "Save";
            this.toolTip.SetToolTip(this.SaveToDatabase, "If You Wont To Save Information");
            this.SaveToDatabase.Click += new System.EventHandler(this.SaveToDatabase_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 20;
            this.btnClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(335, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.toolTip.SetToolTip(this.btnClear, "If You Wont To Clear All TextBox");
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 20;
            this.btnExit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(606, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 53);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.toolTip.SetToolTip(this.btnExit, "Go To Login Form");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            this.toolTip.AllowLinksHandling = true;
            this.toolTip.AutomaticDelay = 1000;
            this.toolTip.AutoPopDelay = 3000;
            this.toolTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip.ForeColor = System.Drawing.Color.Black;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.IsBalloon = true;
            this.toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.toolTip.ReshowDelay = 200;
            this.toolTip.TitleFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Help:";
            // 
            // Student_Record_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 531);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.SaveToDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Record_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student_Record_Form";
            this.Load += new System.EventHandler(this.Student_Record_Form_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2Button SaveToDatabase;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox studentId;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton genderFemale;
        private Guna.UI2.WinForms.Guna2RadioButton genderMale;
        private Guna.UI2.WinForms.Guna2TextBox studentPassword;
        private Guna.UI2.WinForms.Guna2TextBox studentAddress;
        private Guna.UI2.WinForms.Guna2TextBox studentAge;
        private Guna.UI2.WinForms.Guna2TextBox studentName;
        private Guna.UI2.WinForms.Guna2Button btnSelectPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2PictureBox picPerson;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTip;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}