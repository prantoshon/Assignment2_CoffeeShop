using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class HomeUI : Form
    {
        int count;
        public HomeUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            const int loop = 6;
            int index = 0;
          
            int totalBill;
            string[] customerName = new string[6];
            string[] customerNumber = new string[6];
            string[] address = new string[6];
            string[] order = new string[6];
            int[] quantity = new int[6];
            if (customerNameTextBox.Text == "") 
            {
                MessageBox.Show("Please Insert Name");
            }
            else if(contractNUmberTextBox.Text =="")
            {
            MessageBox.Show("Please Insert Phone Number");
            }
            else if (addressTextBox.Text == "")
            {
                MessageBox.Show("Please Insert Address");
            }
            else if (orderComboBox.Text == "")
            {
                MessageBox.Show("Please Insert Order Item");
            }
            else if (quantityTextBox.Text == "")
            {
                MessageBox.Show("Please Insert Quantity");
            }
            else
            {

                if (count <= loop)
                {
                    customerName[index] = customerNameTextBox.Text;
                    customerNumber[index] = contractNUmberTextBox.Text;
                    address[index] = addressTextBox.Text;
                    order[index] = orderComboBox.Text;
                    quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                   
                    showResultRichTextBox.AppendText("Name :" + customerName[index] + "  ");
                    showResultRichTextBox.AppendText("Number :" + customerNumber[index] + "  ");
                    showResultRichTextBox.AppendText("Address :" + address[index] + "  ");
                    showResultRichTextBox.AppendText("Order :" + order[index] + "  ");

                    if (order[index] == "Black-120")
                    {
                        totalBill = quantity[index] * 120;
                        showResultRichTextBox.AppendText("Quantity :"+ quantity[index]+ "  ");
                        showResultRichTextBox.AppendText("Total Bill :" + totalBill.ToString() + "\n\n");
                    }
                    else if (order[index] == "Cold-100")
                    {
                        totalBill = quantity[index] * 100;
                        showResultRichTextBox.AppendText("Quantity :" + quantity[index] + "  ");
                        showResultRichTextBox.AppendText("Total Bill :" + totalBill.ToString() + "\n\n");

                    }
                    else if (order[index] == "Hot-90")
                    {
                        totalBill = quantity[index] * 90;
                        showResultRichTextBox.AppendText("Quantity :" + quantity[index] + "  ");
                        showResultRichTextBox.AppendText("Total Bill :" + totalBill.ToString() + "\n\n");
                    }
                    else if (order[index] == "Regular-80")
                    {
                        totalBill = quantity[index] * 80;
                        showResultRichTextBox.AppendText("Quantity :" + quantity[index] + "  ");
                        showResultRichTextBox.AppendText("Total Bill :" + totalBill.ToString() + "\n\n");
                    }


                    count++;


                }
                else
                {
                    MessageBox.Show("The Index Is Full", "Warning");
                }

            }
        }
    }
}
