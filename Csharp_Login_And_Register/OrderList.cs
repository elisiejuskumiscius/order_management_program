using Newtonsoft.Json;
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

namespace Csharp_Login_And_Register
{
    public partial class OrderList : Form
    {

        public List<Order> Orders = JsonConvert.DeserializeObject<List<Order>>(new StreamReader("Data.json").ReadToEnd());

        private readonly Order order;

        public OrderList()
        {
            InitializeComponent();
            loadList();
        }

        public OrderList(Order order) : this()
        {
            this.order = order;
        }

        public void loadList()
        {
            listBox1.Items.Clear();
            foreach (Order order in Orders)
            {
                listBox1.Items.Add(order);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditOrder.Enabled = btnDeleteOrder.Enabled = listBox1.SelectedIndex >= 0;
        }

        private void btnEditOrder_Click_1(object sender, EventArgs e)
        {
            var editOrder = new EditOrder(Orders[listBox1.SelectedIndex], this);
            editOrder.ShowDialog();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (Orders[listBox1.SelectedIndex].Items.Count > 0)
            {
                string text = "Can not delete order that has at least one item";
                MessageBox.Show(text);
            }
            else
                Orders.RemoveAt(listBox1.SelectedIndex);
            loadList();
        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            var addOrder = new AddOrder(this);
            addOrder.ShowDialog();
            loadList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
