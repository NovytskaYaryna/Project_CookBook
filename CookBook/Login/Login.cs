using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Login
{
    public partial class Login : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        CookBookDB db = CookBookDB.getInstance();
       
        public Login()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void headerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Reg regForm = new Reg();
            regForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginTB.Text.Length == 0 || passwordTB.Text.Length == 0)
            {
                MessageBox.Show("Введіть дані для входу.");
                return;
            }

            Users user = db.Users
                .Where(o => o.login == loginTB.Text && o.password == passwordTB.Text)
                .FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Невірні дані для входу.");
                return;
            }

            this.Hide();
            UserLogin.setInstance(user.id, user.login);
            Form1 mainForm = new Form1();
            mainForm.Show();
        }
    }
}
