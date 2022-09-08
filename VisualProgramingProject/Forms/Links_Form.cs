using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace VisualProgramingProject
{
    public partial class Links_Form : Form
    {
        public Links_Form()
        {
            InitializeComponent();
        }

        private void FacebookLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Process.Start("http://www.facebook.com");
        }

        private void LinkedInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            Process.Start("https://www.linkedin.com");
        }

        private void WhatsAppLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.LinkVisited = true;
            Process.Start("https://web.whatsapp.com");
        }

        private void InstgramLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            Process.Start("https://www.instagram.com");
        }

        private void TwitterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            Process.Start("https://twitter.com");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel9.LinkVisited = true;
            Process.Start("https://www.geeksforgeeks.org");
        }

        private void W3SchoolsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel10.LinkVisited = true;
            Process.Start("https://www.w3schools.com");
        }

        private void JavaPointLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel7.LinkVisited = true;
            Process.Start("https://www.javatpoint.com/");
        }

        private void TutoiralPointLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel8.LinkVisited = true;
            Process.Start("https://www.tutorialspoint.com");
        }

        private void FreeCodeCampLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.LinkVisited = true;
            Process.Start("https://www.freecodecamp.org");
        }

        private void FreeCodeCamp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel14.LinkVisited = true;
            Process.Start("https://www.youtube.com/c/Freecodecamp");
        }

        private void ElzeroWebSchool_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel14.LinkVisited = true;
            Process.Start("https://www.youtube.com/c/ElzeroInfo");
        }

        private void AdelNasimLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel14.LinkVisited = true;
            Process.Start("https://www.youtube.com/c/AdelNasim");
        }

        private void DrossOnline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel14.LinkVisited = true;
            Process.Start("https://www.youtube.com/c/DroosOnline4u");
        }

        private void AhmedAliLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel11.LinkVisited = true;
            Process.Start("https://www.youtube.com/channel/UCRSFUodZcy-71EyiXoUUxEw");
        }
    }
}
