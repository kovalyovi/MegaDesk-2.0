using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        private String orderPath;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            rushOptionsForm.BackColor = Color.White;
            materialForm.BackColor = Color.White;

            string[] materials = File.ReadAllLines("../materials.txt");
            foreach (String m in materials)
            {
                materialForm.Items.Add(m);
            }

            string[] rushOptions = File.ReadAllLines("../rushOptions.txt");
            foreach (String ro in rushOptions)
            {
                rushOptionsForm.Items.Add(ro);
            }

            orderPath = @"..\orders.txt";


        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FullNameBox_TextChanged(object sender, EventArgs e)
        {
            lblRem.Text = (64 - fullNameBox.TextLength).ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var my_desk = new Desk((float)numWidthForm.Value, (float)numDepthForm.Value, Decimal.ToInt16(numDrawersForm.Value), materialForm.Text);
            var my_quote = new DeskQuote(fullNameBox.Text, rushOptionsForm.Text, my_desk, DateTime.Now);

            var json_my_quote = Newtonsoft.Json.JsonConvert.SerializeObject(my_quote);
            File.AppendAllText(orderPath, json_my_quote);
            File.AppendAllText(orderPath, "\n\n");

            //fullName = fullNameBox.Text;
            //numDrawers = Decimal.ToInt16(numDrawersForm.Value);
            //depth = (float)numDepthForm.Value;
            //width = (float)numWidthForm.Value;
            //rushOption = rushOptionsForm.Text;
            //material = materialForm.Text;

            //Desk myDesk = new Desk(width, depth, numDrawers, material);
            //DeskQuote myQuote = new DeskQuote(fullName, myDesk, rushOption);
            clearForms();
        }

        private void clearForms()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(ComboBox))
                {
                    c.Text = "";
                }
                else if (c.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)c).Value = 0;
                }
            }
            numDepthForm.Value = 12.0M;
            numWidthForm.Value = 24.0M;
            fullNameBox.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _mainMenu.Show();
            Close();
            // Close();
            // _mainMenu.Show();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void RushOptionsForm_Leave(object sender, EventArgs e)
        {
            bool result = false;
            var rushOps = new List<String>
            {
                "3 days",
                "5 days",
                "7 days",
                "regular"
            };

            foreach(String rushOp in rushOps)
            {
                if (rushOp.Equals(rushOptionsForm.Text))
                {
                    result = true;
                }
            }
           
            rushOptionsForm.Text = result ? rushOptionsForm.Text : "";
        }

        private void MaterialForm_Leave(object sender, EventArgs e)
        {
            bool result = false;
            var mats = new List<String>() {
                "laminate",
                "oak",
                "rosewood",
                "veneer",
                "pine"
            };

            foreach (String mat in mats)
            {
                if (mat.Equals(materialForm.Text))
                {
                    result = true;
                }
            }

            materialForm.Text = result ? materialForm.Text : "";        
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
        }

        private void AddQuote_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
