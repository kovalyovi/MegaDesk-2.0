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
        private List<string> materials;
        private List<string> rushOptions;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            rushOptionsForm.BackColor = Color.White;
            materialForm.BackColor = Color.White;


            materials = new List<string>(File.ReadAllLines("../materials.txt"));
            foreach (String m in materials)
            {
                materialForm.Items.Add(m);
            }

            rushOptions = new List<string>(File.ReadAllLines("../rushOptions.txt"));
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
            if (String.IsNullOrEmpty(rushOptionsForm.Text) && String.IsNullOrEmpty(materialForm.Text) && String.IsNullOrEmpty(fullNameBox.Text))
            {
                MessageBox.Show("\"Rush options\", \"Materials\", and \"Full name\" cannot be empty!");
            }
            else if (String.IsNullOrEmpty(rushOptionsForm.Text) && String.IsNullOrEmpty(materialForm.Text))
            {
                MessageBox.Show("\"Rush options\" and \"Materials\" cannot be empty!");
            }
            else if (String.IsNullOrEmpty(rushOptionsForm.Text) && String.IsNullOrEmpty(fullNameBox.Text))
            {
                MessageBox.Show("\"Rush options\" and \"Full name\" cannot be empty!");
            }
            else if (String.IsNullOrEmpty(materialForm.Text) && String.IsNullOrEmpty(fullNameBox.Text))
            {
                MessageBox.Show("\"Materials\" and \"Full name\" cannot be empty!");
            }
            else if (String.IsNullOrEmpty(materialForm.Text))
            {
                MessageBox.Show("\"Materials\" cannot be empty!");
            }
            else if (String.IsNullOrEmpty(rushOptionsForm.Text))
            {
                MessageBox.Show("\"Rush options\" cannot be empty!");
            }
            else if (String.IsNullOrEmpty(fullNameBox.Text))
            {
                MessageBox.Show("\"Full name\" cannot be empty!");
            }
            else
            {
                var my_desk = new Desk((float)numWidthForm.Value, (float)numDepthForm.Value, Decimal.ToInt16(numDrawersForm.Value), materialForm.Text);
                var my_quote = new DeskQuote(fullNameBox.Text, rushOptionsForm.Text, my_desk, DateTime.Now);

                var json_my_quote = Newtonsoft.Json.JsonConvert.SerializeObject(my_quote);
                File.AppendAllText(orderPath, json_my_quote);
                File.AppendAllText(orderPath, "\n\n");

                clearForms();
            }

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
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void RushOptionsForm_Leave(object sender, EventArgs e)
        {
            bool result = false;

            foreach(String rushOption in rushOptions)
            {
                if (rushOption.Equals(rushOptionsForm.Text))
                {
                    result = true;
                }
            }
           
            rushOptionsForm.Text = result ? rushOptionsForm.Text : "";
        }

        private void MaterialForm_Leave(object sender, EventArgs e)
        {
            bool result = false;

            foreach (String material in materials)
            {
                if (material.Equals(materialForm.Text))
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

        private void NumDepthForm_Click(object sender, EventArgs e)
        {
            NumericUpDown depthForm = sender as NumericUpDown;

            if (depthForm != null)
            {
                int lengthOfAnswer = depthForm.Value.ToString().Length;
                depthForm.Select(0, lengthOfAnswer + 2);
            }
        }
    }
}
