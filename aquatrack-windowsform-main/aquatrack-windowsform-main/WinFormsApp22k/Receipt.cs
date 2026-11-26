
using System;
using System.Windows.Forms;

namespace WinFormsApp22k
{
    public partial class Receipt : Form
    {
        public Receipt(
            string name,
            string address,
            string jugtype,
            int quantity,
            double distance,
            int jugPrice,
            int subtotal,
            int shippingFee,
            int total)
        {
            InitializeComponent();

            lblCustomer.Text = "Customer Name: " + name;
            lblAddress.Text = "Address: " + address;
            lblJugType.Text = "Jug Type: " + jugtype;
            lblQuantity.Text = "Quantity: " + quantity;

            lblDistance.Text = "Distance: " + distance + " km";
            lblJugPrice.Text = "Jug Price: ₱" + jugPrice.ToString("N2");
            lblSubtotal.Text = "Subtotal: ₱" + subtotal.ToString("N2");
            lblShippingFee.Text = "Shipping Fee: ₱" + shippingFee.ToString("N2");
            lblTotal.Text = "TOTAL AMOUNT: ₱" + total.ToString("N2");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblCustomer_Click(object sender, EventArgs e)
        {

        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void lblShippingFee_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
