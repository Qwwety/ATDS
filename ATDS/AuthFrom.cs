using ATDS.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDS
{
    public partial class AuthFrom : Form
    {
        private ATDSContext context_;
        string LogPath = @"\C#\Diplom\Automatic task delivery system(ATDS)\ATDS\Logs.Txt";


        public AuthFrom()
        {
            InitializeComponent();
        }
        private void AuthFrom_Load(object sender, EventArgs e)
        {
            context_ = new ATDSContext();
        }
        private async void AuthButton_Click(object sender, EventArgs e)
        {
            try
            {

                var UserId = await context_.User.Where(x => x.Name == NameBox.Text && x.Password == PassBox.Text).Select(x => x.Id).FirstOrDefaultAsync();

                if (UserId != 0)
                {
                    UserForm UserForm = new UserForm(context_);
                    UserForm.CurrentUserId = UserId;
                    UserForm.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }

            }
            catch (Exception ex)
            {
                File.AppendAllText(LogPath, ex.Message + "\n");
            }

        }
    }
}
