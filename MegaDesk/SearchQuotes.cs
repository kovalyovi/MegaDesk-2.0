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
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;
        DataGridView viewOfQuotes = new DataGridView();
        List<DeskQuote> quotes = new List<DeskQuote>();

        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            populateCombobox();
        }

        void populateCombobox()
        {
            string[] materials = File.ReadAllLines("../materials.txt");
            foreach (String m in materials)
            {
                materialForm.Items.Add(m);
            }
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void MaterialForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            quotes.Clear();
            displayGrid();
        }

        void displayGrid()
        {
            fillData();
            viewOfQuotes.Top = 55;
            viewOfQuotes.DataSource = null;
            viewOfQuotes.DataSource = ToDataTable(quotes);
            viewOfQuotes.AutoSize = true;
            Controls.Add(viewOfQuotes);
        }

        void fillData()
        {
            
            string orderPath = @"..\orders.txt";
            IEnumerable<String> orders = File.ReadLines(orderPath);
            foreach (String line in orders)
            {
                try
                {
                    DeskQuote jObject = Newtonsoft.Json.JsonConvert.DeserializeObject<DeskQuote>(line);
                    if (jObject != null && jObject.Desk.SurfaceMaterial == materialForm.Text)
                        quotes.Add(jObject);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        DataTable ToDataTable(List<DeskQuote> orders)
        {
            DataTable table = new DataTable();
            table.Columns.Add("CustomerName");
            table.Columns.Add("DeskWidth");
            table.Columns.Add("DeskDepth");
            table.Columns.Add("NumberOfDrawers");
            table.Columns.Add("SurafaceMaterial");
            table.Columns.Add("QuotePrice");
            table.Columns.Add("ShippingType");
            table.Columns.Add("Date");
            foreach (DeskQuote item in orders)
            {
                var row = table.NewRow();
                row["CustomerName"] = item.CustomerName.ToString();
                row["DeskWidth"] = item.Desk.Width.ToString();
                row["DeskDepth"] = item.Desk.Depth.ToString();
                row["NumberOfDrawers"] = item.Desk.NumberOfDrawers.ToString();
                row["SurafaceMaterial"] = item.Desk.SurfaceMaterial.ToString();
                row["QuotePrice"] = item.QuotePrice.ToString("C2");
                row["ShippingType"] = item.ShippingType.ToString();
                row["Date"] = item.Date.ToString("MM/dd/yy");
                table.Rows.Add(row);
            }
            return table;
        }

        private void MaterialForm_EnabledChanged(object sender, EventArgs e)
        {
            
        }
    }
}
