using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VisualProgramingProject.Connection
{
    public class Connect
    {
        public bool db_ConnectionToDatabase(bool showMessage, SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Open();
                if (showMessage)
                    MessageBox.Show("Successful database connection.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Database Connection");
                return false;
            }
        }
    }
}
