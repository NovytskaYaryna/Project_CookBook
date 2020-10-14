using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook
{
    public partial class CategoryForm : Form
    {
        CookBookDB db = CookBookDB.getInstance();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            if (nameTB.Text.Length == 0)
            {
                MessageBox.Show("Введіть назву!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categories category = new Categories();
            category.name = nameTB.Text;

            db.Categories.Add(category);
            db.SaveChanges();

            MessageBox.Show("Успішно додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
