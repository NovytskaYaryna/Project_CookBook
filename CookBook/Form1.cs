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
    public partial class Form1 : Form
    {
        bool drag = false;
        Point startPoint = new Point(0, 0);
        UI.UIRecipes UIRecipes = new UI.UIRecipes();
        UI.UIUsers UIUsers = new UI.UIUsers();
        UserLogin userLogin = UserLogin.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(btnHeader);
            btnHeader.Location = new Point(usersBtn.Location.X, btnHeader.Location.Y);
            bunifuTransition1.Show(btnHeader);

            mainPanel.Hide();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(UIUsers);
            bunifuTransition2.Show(mainPanel);

            UIUsers.showUsers();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(btnHeader);
            btnHeader.Location = new Point(extBtn.Location.X, btnHeader.Location.Y);
            bunifuTransition1.Show(btnHeader);

            this.Hide();
            new Login.Login().Show(); 
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(btnHeader);
            btnHeader.Location = new Point(recipesBtn.Location.X, btnHeader.Location.Y);
            bunifuTransition1.Show(btnHeader);

            mainPanel.Hide();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(UIRecipes);
            bunifuTransition2.Show(mainPanel);

            UIRecipes.fillComboBoxes();
            UIRecipes.showRecipes();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            CookBookDB.getInstance();
            mainPanel.Controls.Add(UIRecipes);
            bunifuTransition2.Show(mainPanel);

            UIRecipes.fillComboBoxes();
            UIRecipes.showRecipes();
        }
    }
}
