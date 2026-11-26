
using System;
using System.Windows.Forms;

namespace WinFormsApp22k
{
    public partial class Dashboard : Form
    {
        private string customerName;
        private string customerAddress;
        private string selectedJug;
        private int orderQuantity;
        private double orderDistance;
        private int orderJugPrice;
        private int orderSubtotal;
        private int orderShippingFee;
        private int orderTotal;

        public Dashboard(
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

            customerName = name;
            customerAddress = address;
            selectedJug = jugtype;
            orderQuantity = quantity;

            orderDistance = distance;
            orderJugPrice = jugPrice;
            orderSubtotal = subtotal;
            orderShippingFee = shippingFee;
            orderTotal = total;

            // Display order information with labels
            lblName.Text = "Customer Name: " + name;
            lblAddress.Text = "Barangay: " + address;
            lblJugType.Text = "Jug Type: " + jugtype;
            lblQuantity.Text = "Quantity: " + quantity;

            lblDistance.Text = "Distance: " + distance + " km";
            lblJugPrice.Text = "Jug Price: ₱" + jugPrice.ToString("N2");
            lblSubtotal.Text = "Subtotal: ₱" + subtotal.ToString("N2");
            lblShippingFee.Text = "Shipping Fee: ₱" + shippingFee.ToString("N2");
            lblTotal.Text = "Total Amount: ₱" + total.ToString("N2");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void lblJugType_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt(
                customerName,
                customerAddress,
                selectedJug,
                orderQuantity,
                orderDistance,
                orderJugPrice,
                orderSubtotal,
                orderShippingFee,
                orderTotal
            );

            receipt.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void picaqua_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
