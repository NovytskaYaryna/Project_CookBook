using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCreator = Microsoft.Office.Interop.Word;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;

namespace CookBook.UI
{
    public partial class UIRecipes : UserControl
    {
        CookBookDB db = CookBookDB.getInstance();
        UserLogin userLogin = UserLogin.getInstance();

        public UIRecipes()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public void fillComboBoxes(int selectLevel = 0, int selectCat = 0, int selectUser = 0)
        {
            levelCB.DisplayMember = "Text";
            levelCB.ValueMember = "Value";

            List<ComboboxItem> Items = new List<ComboboxItem>
            {
                new ComboboxItem{Value = 1, Text = "Легкий"},
                new ComboboxItem{Value = 2, Text = "Середній"},
                new ComboboxItem{Value = 3, Text = "Складний"}
            };
            levelCB.DataSource = Items;

            if (selectLevel != 0)
                levelCB.SelectedValue = selectLevel;
            else
                levelCB.SelectedIndex = 0;

            var categories = db.Categories;

            categoriesCB.DisplayMember = "Text";
            categoriesCB.ValueMember = "Value";

            List<ComboboxItem> Items2 = new List<ComboboxItem>();

            foreach (Categories t in categories)
                Items2.Add(new ComboboxItem { Text = t.name, Value = t.id });

            categoriesCB.DataSource = Items2;

            if (selectCat != 0)
                categoriesCB.SelectedValue = selectCat;
            else
                categoriesCB.SelectedIndex = 0;


            var users = db.Users;

            userCB.DisplayMember = "Text";
            userCB.ValueMember = "Value";

            List<ComboboxItem> Items3 = new List<ComboboxItem>();

            foreach (Users u in users)
                Items3.Add(new ComboboxItem { Text = string.Concat(u.id, ".", u.surname, " ", u.name), Value = u.id });

            userCB.DataSource = Items3;

            if (selectUser != 0)
                userCB.SelectedValue = selectUser;
            else
                userCB.SelectedIndex = 0;
        }

        public void showRecipes(int user_id = 0, string resipy = "")
        {
            RecipesDG.Rows.Clear();
            RecipesDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            RecipesDG.ColumnCount = 5;

            RecipesDG.Columns[0].Name = "Id";
            RecipesDG.Columns[0].Width = 40;
            RecipesDG.Columns[1].Name = "Назва";
            RecipesDG.Columns[1].Width = 70;
            RecipesDG.Columns[2].Name = "Категорія";
            RecipesDG.Columns[3].Name = "Складність";
            RecipesDG.Columns[4].Name = "Створив";

            var recipes = db.Resipes;

            foreach (Resipes r in recipes)
            {
                if (user_id != 0 && r.user_id != user_id)
                    continue;

                if (resipy.Length > 0 && !r.name.ToLower().Contains(resipy.ToLower()))
                    continue;

                Users user = db.Users
                    .Where(o => o.id == r.user_id)
                    .FirstOrDefault();

                Categories category = db.Categories
                    .Where(o => o.id == r.category_id)
                    .FirstOrDefault();

                string hard_level = r.hadr_level == 1 ? "Легкий" : r.hadr_level == 2 ? "Середній" : "Важкий";
                RecipesDG.Rows.Add(r.id, r.name, category.name, hard_level, string.Concat(user.id, ".", user.surname, " ", user.name));
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTB.Text.Length == 0 || categoriesCB.SelectedValue == null || levelCB.SelectedValue == null || recipyTB.Text.Length == 0)
            {
                MessageBox.Show("Потрібно ввести всі дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Resipes resipy = new Resipes();
            resipy.name = nameTB.Text;
            resipy.resipes1 = recipyTB.Text;
            resipy.hadr_level = Convert.ToInt32(levelCB.SelectedValue.ToString());
            resipy.category_id = Convert.ToInt32(categoriesCB.SelectedValue.ToString());
            resipy.user_id = userLogin.userId;
            resipy.image = "test";

            db.Resipes.Add(resipy);
            db.SaveChanges();

            RecipesDG.Rows.Add(resipy.id, resipy.name, resipy.category_id, resipy.hadr_level, resipy.user_id);
            chgBtn.Visible = false;
            nameTB.Text = "";
            recipyTB.Text = "";
        }

        private void RecipesDG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (RecipesDG.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int resipy_id = Convert.ToInt32(RecipesDG.Rows[e.RowIndex].Cells[0].Value.ToString());

                Resipes resipy = db.Resipes
                    .Where(o => o.id == resipy_id)
                    .FirstOrDefault();

                nameTB.Text = resipy.name;
                recipyTB.Text = resipy.resipes1;
                fillComboBoxes(resipy.hadr_level, resipy.category_id);

                if (resipy.user_id != userLogin.userId)
                {
                    addBtn.Visible = false;
                    chgBtn.Visible = false;
                    delBtn.Visible = false;
                }
                else
                {
                    chgBtn.Visible = true;
                    delBtn.Visible = true;
                    addBtn.Visible = false;
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            addBtn.Location = new System.Drawing.Point(825, 409);
            addBtn.Visible = true;
            chgBtn.Visible = false;
            delBtn.Visible = false;
            nameTB.Text = "";
            recipyTB.Text = "";
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (RecipesDG.SelectedRows.Count != 0)
            {
                DataGridViewRow row = RecipesDG.SelectedRows[0];
                deleteResipy(Convert.ToInt32(row.Cells[0].Value.ToString()));
                RecipesDG.Rows.RemoveAt(RecipesDG.SelectedRows[0].Index);
            }
        }

        private void chgBtn_Click(object sender, EventArgs e)
        {
            if (RecipesDG.SelectedRows.Count != 0)
            {
                DataGridViewRow row = RecipesDG.SelectedRows[0];
                changeResipy(Convert.ToInt32(row.Cells[0].Value.ToString()));
                showRecipes();
            }
        }

        private void changeResipy(int id)
        {
            Resipes resipy = db.Resipes
                .Where(o => o.id == id)
                .FirstOrDefault();

            resipy.name = nameTB.Text;
            resipy.resipes1 = recipyTB.Text;
            resipy.hadr_level = Convert.ToInt32(levelCB.SelectedValue.ToString());
            resipy.category_id = Convert.ToInt32(categoriesCB.SelectedValue.ToString());
            resipy.user_id = userLogin.userId;
            resipy.image = "test";

            db.SaveChanges();
        }

        private void deleteResipy(int id)
        {
            Resipes resipy = db.Resipes
                .Where(o => o.id == id)
                .FirstOrDefault();

            db.Resipes.Remove(resipy);
            db.SaveChanges();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            new CategoryForm().Show();
            fillComboBoxes();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (userCB.SelectedValue != null)
            {
                showRecipes(Convert.ToInt32(userCB.SelectedValue.ToString()), resipySearch.Text);
            }
            else
            {
                showRecipes(0, resipySearch.Text);
            }
            
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

            if (RecipesDG.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = RecipesDG.SelectedRows[0];

            WordCreator.Application word = new WordCreator.Application(); //создаем COM-объект Word
            WordCreator.Document doc = word.Documents.Add();
            doc.Select();

            var header = doc.Paragraphs.Add();
            header.Range.Font.Name = "Calibri";
            header.Range.Font.Size = 16;
            header.Range.Text = row.Cells[1].Value.ToString();
            header.Range.ParagraphFormat.Alignment = WordCreator.WdParagraphAlignment.wdAlignParagraphCenter;
            header.Range.Font.Bold = 1;
            header.Range.InsertParagraphAfter();

            var category = doc.Paragraphs.Add();
            category.Range.Font.Name = "Calibri";
            category.Range.Font.Size = 14;
            category.Range.Text = String.Format("Категорія: {0}", row.Cells[2].Value.ToString());
            category.Range.ParagraphFormat.Alignment = WordCreator.WdParagraphAlignment.wdAlignParagraphLeft;
            category.Range.Font.Bold = 1;
            category.Range.InsertParagraphAfter();

            var hard_level = doc.Paragraphs.Add();
            hard_level.Range.Font.Name = "Calibri";
            hard_level.Range.Font.Size = 14;
            hard_level.Range.Text = String.Format("Складність: {0}", row.Cells[3].Value.ToString());
            hard_level.Range.ParagraphFormat.Alignment = WordCreator.WdParagraphAlignment.wdAlignParagraphLeft;
            hard_level.Range.Font.Bold = 1;
            hard_level.Range.InsertParagraphAfter();

            var author = doc.Paragraphs.Add();
            author.Range.Font.Name = "Calibri";
            author.Range.Font.Size = 14;
            author.Range.Text = String.Format("Автор: {0}", row.Cells[4].Value.ToString());
            author.Range.ParagraphFormat.Alignment = WordCreator.WdParagraphAlignment.wdAlignParagraphLeft;
            author.Range.Font.Bold = 1;
            author.Range.InsertParagraphAfter();

            var pText2 = doc.Paragraphs.Add();
            pText2.Range.Font.Name = "Calibri";
            pText2.Range.Font.Size = 14;
            pText2.Range.Text = "";
            pText2.Range.ParagraphFormat.Alignment = WordCreator.WdParagraphAlignment.wdAlignParagraphJustify;
            pText2.Range.Font.Bold = 0;
            pText2.Range.InsertParagraphAfter();

            var pText1 = doc.Paragraphs.Add();
            pText1.Range.Font.Name = "Calibri";
            pText1.Range.Font.Size = 14;
            pText1.Range.Text = String.Format("Рецепт: {0}", recipyTB.Text.ToString()); 
            pText1.Range.ParagraphFormat.Alignment = WordCreator.WdParagraphAlignment.wdAlignParagraphJustify;
            pText1.Range.Font.Bold = 0;
            pText1.Range.InsertParagraphAfter();

            word.Visible = true;
        }

    }
}
