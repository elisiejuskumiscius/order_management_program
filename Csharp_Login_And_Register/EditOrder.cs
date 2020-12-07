using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Login_And_Register
{
    public partial class EditOrder : Form
    {
        Order ord;
        OrderList orderListForm;

        public EditOrder(Order order, OrderList orderList )
        {
            InitializeComponent();
            ord = order;
            orderListForm = orderList;
            loadList();
        }

        private void loadList() {
            listBox1.Items.Clear();
            foreach(Item item in ord.Items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<Item> newItemList = new List<Item>();

            foreach(var listBoxItem in listBox1.Items)
            {
                newItemList.Add(new Item { ItemName = listBoxItem.ToString() });
            }

            ord.OrderNum = int.Parse(textBox1.Text);
            ord.Items = newItemList;
            List<Customer> customers = new List<Customer>();
            foreach (string input in this.textBox3.Lines)
            {
                customers.Add(new Customer { CustName = input });
            }
            ord.Customers = customers;
            orderListForm.loadList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                ord.Items.RemoveAt(listBox1.SelectedIndex);
                loadList();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
