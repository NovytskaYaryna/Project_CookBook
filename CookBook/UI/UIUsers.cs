using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class UIUsers : UserControl
    {
        CookBookDB db = CookBookDB.getInstance();
        UserLogin userLogin = UserLogin.getInstance();

        public UIUsers()
        {
            InitializeComponent();
        }

        public void showUsers()
        {
            UsersDG.Rows.Clear();
            UsersDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            UsersDG.ColumnCount = 4;

            UsersDG.Columns[0].Name = "Id";
            UsersDG.Columns[0].Width = 40;
            UsersDG.Columns[1].Name = "Прізвище";
            UsersDG.Columns[2].Name = "Ім'я";
            UsersDG.Columns[3].Name = "Вік";
            
            var users = db.Users;
            foreach (Users u in users)
            {
                UsersDG.Rows.Add(u.id, u.surname, u.name, u.age);
            }

            Users user = db.Users
                .Where(o => o.id == userLogin.userId)
                .FirstOrDefault();

            if (user != null)
            {
                surnameTB.Text = user.surname;
                nameTB.Text = user.name;
                loginTB.Text = user.login;
                ageTB.Text = user.age.ToString();
            }
        }

        private void chgBtn_Click(object sender, EventArgs e)
        {
            Users oldData = db.Users
                .Where(o => o.id == userLogin.userId)
                .FirstOrDefault();

            if (surnameTB.Text.Length == 0 || nameTB.Text.Length == 0 || loginTB.Text.Length == 0 || ageTB.Text.Length == 0 ||
                oldPasswordTB.Text.Length == 0 || newPasswordTB.Text.Length == 0)
            {
                MessageBox.Show("Потрібно ввести всі дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (user != null && !string.Equals(loginTB.Text, userLogin.userLogin))
            {
                MessageBox.Show("Користувач з таким логіном уже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(oldPasswordTB.Text, oldData.password))
            {
                MessageBox.Show("Старий пароль введено не вірно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            oldData.name = nameTB.Text;
            oldData.surname = surnameTB.Text;
            oldData.password = newPasswordTB.Text;
            oldData.login = loginTB.Text;
            oldData.age = Convert.ToInt32(ageTB.Text);

            UserLogin.setInstance(oldData.id, loginTB.Text);

            db.SaveChanges();

            MessageBox.Show("Успішно змінено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
