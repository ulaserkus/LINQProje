using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProje
{
    class Order
    {
        public int OrderId { get; set; }
        
        public string CustomerId { get; set; }
        
        public int EmployeeId { get; set; }

        public DateTime OrderDate { get; set; }

        public Customer Customer;

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            string cmd = @"select o.OrderID,o.CustomerID,o.EmployeeID,OrderDate,c.ContactName from Orders o
                                   join Customers c on o.CustomerID = c.CustomerID";

            DataTable dataTable = GetDataTable(cmd);

            foreach (DataRow item in dataTable.Rows)
            {
                Order order = new Order();
                order.OrderId = (int)(item["OrderId"]);
                order.CustomerId = (string)item["CustomerId"];
                order.EmployeeId = (int)item["EmployeeId"];
                order.OrderDate = (DateTime)item["OrderDate"];
                order.Customer = new Customer();
                order.Customer.ContactName =item["ContactName"].ToString();
                order.Customer.CustomerId = (string)item["CustomerId"];
                orders.Add(order);
                
            }
            return orders;
        }

        private DataTable GetDataTable(string cmd)
        {
            string connection = @"Data Source=DESKTOP-L0NA0DU\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }


    class Customer
    {
        public string CustomerId { get; set; }

        public string ContactName { get; set; }

        public List<Order> Orders { get; set; }

        public int OrderCount { 
            get { return Orders.Count(); } 
             }

    }
}
