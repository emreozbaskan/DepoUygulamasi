using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoUygulamasi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string dbUserName = "admin";
        string dbPassword = "123";

        //rootPath ayarı yapıyoruz
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //sayfanın default açılısında bu resim gözükecek
            ChangePicture("admin");
        }

        //textbox çıkıldığı anda tetiklenir
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            ChangePicture(userName);
        }

        void ChangePicture(string imageName)
        {
            try
            {
                pbUserImage.Image = Image.FromFile($"{path}\\images\\{imageName}.png");
            }
            catch (Exception ex)
            {
                pbUserImage.Image = Image.FromFile($"{path}\\images\\admin.png");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username == dbUserName && password == dbPassword)
            {
                this.Hide(); //Login form anladımda this
                var mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Depo Uygulaması", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
