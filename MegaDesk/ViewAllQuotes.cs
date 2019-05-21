using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private Form _mainMenu;
        private DataGridView viewOfQuotes = new DataGridView();
        private List<DeskQuote> quotes = new List<DeskQuote>();

        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
            displayGrid();
        }

        void displayGrid()
        {
            fillData();
            viewOfQuotes.AutoSize = true;
            _mainMenu.AutoSize = true;
            viewOfQuotes.DataSource = ToDataTable(quotes);
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
                    if (jObject != null)
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
            //using (var reader = ObjectReader.Create(orders))
            //{
            //    try
            //    {
            //        table.Load(reader);
            //    }
            //    catch (Exception e)
            //    {
            //        MessageBox.Show(e.ToString());
            //    }
            //}
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
                row["QuotePrice"] = item.QuotePrice.ToString();
                row["ShippingType"] = item.ShippingType.ToString();
                row["Date"] = item.Date.ToString("MM/dd/yy");
                table.Rows.Add(row);
            }
            return table;        
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
