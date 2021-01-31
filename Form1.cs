using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQProje
{
    public partial class Form1 : Form
    {
        int[] Numbers = { -9, -6, -5, 3, 8, 12, 25 };
        List<string> Names = new List<string>();
        public Form1()
        {
            Names.Add("Alex");
            Names.Add("Bella");
            Names.Add("Canan");
            Names.Add("Andrea");
            Names.Add("Tiffany");

            InitializeComponent();
        }

        private void btn_all_numbers_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Numbers.ToList();


        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Numbers.Where(x=>x<0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();


           
        }

        private void btn_positive_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Numbers.Where(x => x > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();

        }

        private void btn_even_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Numbers.Where(x => x % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void btn_odd_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Numbers.Where(x => x % 2 != 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            int n = Numbers.Max();
           
            MessageBox.Show (n.ToString());
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            int n = Numbers.Min();
          
            MessageBox.Show(n.ToString());
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            int n = Numbers.Count();

            MessageBox.Show(n.ToString());
        }

        private void btn_names_asc_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Names.OrderBy(x => x).ToList();
            
        }

        private void btn_names_desc_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Names.OrderByDescending(y => y).ToList();
        }

        private void btn_names_length_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Names.Select(x => x.Length).ToList();
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Names.Where(x => x.Contains("a") || x.Contains("A")).ToList();

        }

        private void btn_first_A_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Names.Where(x => x.StartsWith("A") || x.StartsWith("a")).ToList();
        }

        private void btn_orders_all_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            var list = orders.Select(n => new
            {
              OrderId =  n.OrderId,
              CustomerId = n.CustomerId,
              EmployeeId = n.EmployeeId,
              OrderDate = n.OrderDate,
              ContactName = n.Customer.ContactName

            }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
           

        }

        private void btn_date_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Select(x => x.OrderDate).ToList();

        }

        private void btn_top_5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void btn_last_5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderId).Take(5).ToList();
        }

        private void btn_john_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Where(x => x.Customer.ContactName == "John Steel").ToList();
        }

        private void btn_orders_count_Click(object sender, EventArgs e)
        {

            List<Order> orders = new Order().GetOrders();
            
            MessageBox.Show( orders.Count().ToString());
        }
    }
}
