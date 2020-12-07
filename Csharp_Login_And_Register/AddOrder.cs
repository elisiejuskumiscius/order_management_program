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

    public partial class AddOrder : Form
    {

        OrderList orderListForm;

        public AddOrder(OrderList orderList)
        {
            InitializeComponent();
            this.orderListForm = orderList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderListForm.Show();

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int inOrdNum))
            {
                if (!orderExist(orderListForm.Orders, inOrdNum))
                {
                    orderListForm.Orders.Add(new Order { OrderNum = inOrdNum });
                    orderListForm.loadList();
                }
                else
                {
                    string text = "Order number is already exist";
                    MessageBox.Show(text);
                }
            }
            else
            {
                string text = "Wrong order number";
                MessageBox.Show(text);
            }
        }

        private bool orderExist(List<Order> ordList, int ordNum) => ordList.Any(c => c.OrderNum == ordNum);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

    }
}
