using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace WinFormsApp22k
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();

            cmbJugType.Items.Clear();
            cmbJugType.Items.Add("1 Gallon Jug - Php50");
            cmbJugType.Items.Add("2 Gallon Jug - Php100");
            cmbJugType.Items.Add("0.5 Gallon Jug Php25");

            cmbJugType.SelectedIndex = 0;

            LoadBarangays();
        }

        private void LoadBarangays()
        {
            var barangays = new List<KeyValuePair<string, double>>
    {
        new("Agot", 7.0),
        new("Agumaymayan", 10.5),
        new("Amoingon", 1.4),
        new("Apitong", 10.8),
        new("Balagasan", 13.5),
        new("Balaring", 1.5),
        new("Balimbing", 8.5),
        new("Balogo", 6.1),
        new("Bamban", 7.4),
        new("Bangbangalon", 5.6),
        new("Bantad", 5.3),
        new("Bantay", 7.5),
        new("Bayuti", 21.0),
        new("Binunga", 14.8),
        new("Boi", 17.0),
        new("Boton", 17.8),
        new("Buliasnin", 6.8),
        new("Bunganay", 3.5),
        new("Can-at (Canat)", 15.5),
        new("Caganhao", 0),
        new("Catubugan", 8.8),
        new("Cawit", 3.0),
        new("Daig", 5.8),
        new("Daypay", 9.6),
        new("Duyay", 7.2),
        new("Hinapulan", 14.0),
        new("Ihatub", 2.3),
        new("Isok I (Pob.)", 4.5),
        new("Isok II Pob. (Kalamias)", 4.8),
        new("Laylay", 3.4),
        new("Lupac", 5.5),
        new("Mahinhin", 9.8),
        new("Mainit", 11.0),
        new("Maligaya", 7.8),
        new("Malbog", 18.5),
        new("Malusak (Pob.)", 4.4),
        new("Mansiwat", 9.1),
        new("Mataas na Bayan (Pob.)", 4.4),
        new("Maybo", 2.6),
        new("Mercado (Pob.)", 4.6),
        new("Murallon (Pob.)", 4.7),
        new("Ogbac", 7.9),
        new("Pawa", 5.0),
        new("Pili", 12.6),
        new("Poctoy", 12.2),
        new("Poras", 3.2),
        new("Puyog", 8.2),
        new("Puting Buhangin", 16.2),
        new("Sabong", 19.2),
        new("Santol", 5.4),
        new("San Miguel (Pob.)", 4.6),
        new("Sawi", 10.2),
        new("Tabi", 5.2),
        new("Tabigue", 6.5),
        new("Tagwak", 9.4),
        new("Tambunan", 11.4),
        new("Tampus (Pob.)", 4.3),
        new("Tanza", 5.8),
        new("Tumagabok", 11.8),
        new("Tumapon", 20.0),
        new("Tugos", 6.3)
    };

            cmbBarangay.DataSource = barangays;
            cmbBarangay.DisplayMember = "Key";
            cmbBarangay.ValueMember = "Value";
            cmbBarangay.SelectedIndex = 0;
        }
        private void picaqua_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = cmbBarangay.Text;
            string jugtype = cmbJugType.Text;

            int quantity = (int)numQuantity.Value;

            if (name == "" || address == "" || jugtype == "")
            {
                MessageBox.Show("Please complete all information!");
                return;
            }

            double distance = Convert.ToDouble(cmbBarangay.SelectedValue);

            int shippingFee = (int)Math.Ceiling(distance / 5.0) * 5;

            int jugPrice = 0;

            if (jugtype.Contains("1 Gallon"))
            {
                jugPrice = 50;
            }
            else if (jugtype.Contains("2 Gallon"))
            {
                jugPrice = 100;
            }
            else if (jugtype.Contains("0.5 Gallon"))
            {
                jugPrice = 25;
            }

            int subtotal = jugPrice * quantity;
            int total = subtotal + shippingFee;

            Dashboard confirm = new Dashboard(
                name,
                address,
                jugtype,
                quantity,
                distance,
                jugPrice,
                subtotal,
                shippingFee,
                total
            );

            confirm.ShowDialog();
        }


        private void cmbJugType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}