namespace HelpApp.Forms
{
    partial class Alarm
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
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btn_Start = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Stop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWhite = new Guna.UI2.WinForms.Guna2Button();
            this.btnBlack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2DateTimePicker1.BorderThickness = 3;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.guna2DateTimePicker1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(80, 14);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(222, 103);
            this.guna2DateTimePicker1.TabIndex = 0;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 6, 4, 21, 25, 13, 972);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Maroon;
            this.lblStatus.Location = new System.Drawing.Point(75, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(213, 25);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status of the Alarm";
            // 
            // btn_Start
            // 
            this.btn_Start.BorderRadius = 20;
            this.btn_Start.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Start.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Start.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(20, 244);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(132, 84);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Start";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BorderRadius = 20;
            this.btn_Stop.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Stop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Stop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Stop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Stop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Stop.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Stop.Location = new System.Drawing.Point(242, 244);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(119, 84);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel1.Controls.Add(this.btn_Start);
            this.guna2Panel1.Controls.Add(this.btn_Stop);
            this.guna2Panel1.Controls.Add(this.lblStatus);
            this.guna2Panel1.Location = new System.Drawing.Point(188, 111);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(382, 362);
            this.guna2Panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(779, 57);
            this.label5.TabIndex = 37;
            this.label5.Text = "Alarm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnWhite);
            this.groupBox1.Controls.Add(this.btnBlack);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox1.Location = new System.Drawing.Point(0, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 103);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Background Mode";
            // 
            // btnWhite
            // 
            this.btnWhite.BorderRadius = 20;
            this.btnWhite.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnWhite.BorderThickness = 2;
            this.btnWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWhite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWhite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWhite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWhite.FillColor = System.Drawing.Color.White;
            this.btnWhite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhite.ForeColor = System.Drawing.Color.Black;
            this.btnWhite.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnWhite.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnWhite.Location = new System.Drawing.Point(594, 28);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.PressedColor = System.Drawing.Color.Brown;
            this.btnWhite.Size = new System.Drawing.Size(141, 60);
            this.btnWhite.TabIndex = 41;
            this.btnWhite.Text = "White Mode";
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BorderRadius = 20;
            this.btnBlack.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnBlack.BorderThickness = 2;
            this.btnBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBlack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBlack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBlack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBlack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBlack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBlack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBlack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(429, 28);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(141, 60);
            this.btnBlack.TabIndex = 41;
            this.btnBlack.Text = "Dark Mode";
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(779, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btn_Start;
        private Guna.UI2.WinForms.Guna2Button btn_Stop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnWhite;
        private Guna.UI2.WinForms.Guna2Button btnBlack;
    }
}