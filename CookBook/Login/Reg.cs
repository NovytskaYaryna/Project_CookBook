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
    public partial class Reg : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        Login logForm = new Login();
        CookBookDB db = CookBookDB.getInstance();

        public Reg()
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            logForm.Show();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (surnameTB.Text.Length == 0 || nameTB.Text.Length == 0 || loginTB.Text.Length == 0 || ageTB.Text.Length == 0 ||
                passwordTB.Text.Length == 0 || repeatPasswordTB.Text.Length == 0 )
            {
                MessageBox.Show("Для реєстрації потрібно ввести всі дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            uint parsedValue;
            if (!uint.TryParse(ageTB.Text, out parsedValue))
            {
                MessageBox.Show("Вік  повинен складатися тільки з цифр!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (ageTB.Text.Length > 2)
            {
                MessageBox.Show("Введіть валідний вік!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users user = db.Users
                .Where(o => o.login == loginTB.Text)
                .FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Користувач з таким логіном уже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(passwordTB.Text, repeatPasswordTB.Text))
            {
                MessageBox.Show("Паролі не співпадають", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Users userReg = new Users();
            userReg.name = nameTB.Text;
            userReg.surname = surnameTB.Text;
            userReg.password = passwordTB.Text;
            userReg.login = loginTB.Text;
            userReg.age = Convert.ToInt32(ageTB.Text);

            db.Users.Add(userReg);
            db.SaveChanges();

            MessageBox.Show("Успішно зареєстровано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            logForm.Show();
        }
    }
}
