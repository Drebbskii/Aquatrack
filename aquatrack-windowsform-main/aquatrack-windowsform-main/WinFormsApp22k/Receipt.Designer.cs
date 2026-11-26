namespace WinFormsApp22k
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            lblQuantity = new Label();
            lblReceiptTitle = new Label();
            lblJugType = new Label();
            lblAddress = new Label();
            lblCustomer = new Label();
            label1 = new Label();
            picaqua = new PictureBox();
            lblDistance = new Label();
            lblJugPrice = new Label();
            lblShippingFee = new Label();
            lblSubtotal = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)picaqua).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.ForeColor = Color.MidnightBlue;
            btnClose.Location = new Point(325, 427);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(261, 23);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnCancel_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.LightSkyBlue;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.MidnightBlue;
            lblQuantity.Location = new Point(262, 260);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 30;
            lblQuantity.Text = "Quantity:";
            // 
            // lblReceiptTitle
            // 
            lblReceiptTitle.AutoSize = true;
            lblReceiptTitle.BackColor = Color.LightSkyBlue;
            lblReceiptTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceiptTitle.ForeColor = Color.MidnightBlue;
            lblReceiptTitle.Location = new Point(390, 147);
            lblReceiptTitle.Name = "lblReceiptTitle";
            lblReceiptTitle.Size = new Size(108, 20);
            lblReceiptTitle.TabIndex = 29;
            lblReceiptTitle.Text = "Order Receipt";
            // 
            // lblJugType
            // 
            lblJugType.AutoSize = true;
            lblJugType.BackColor = Color.LightSkyBlue;
            lblJugType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugType.ForeColor = Color.MidnightBlue;
            lblJugType.Location = new Point(262, 236);
            lblJugType.Name = "lblJugType";
            lblJugType.Size = new Size(77, 20);
            lblJugType.TabIndex = 28;
            lblJugType.Text = "Jug Type:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.LightSkyBlue;
            lblAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.MidnightBlue;
            lblAddress.Location = new Point(262, 196);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(72, 20);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "Address:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.BackColor = Color.LightSkyBlue;
            lblCustomer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomer.ForeColor = Color.MidnightBlue;
            lblCustomer.Location = new Point(262, 176);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(128, 20);
            lblCustomer.TabIndex = 26;
            lblCustomer.Text = "Customer Name:";
            lblCustomer.Click += lblCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(370, 116);
            label1.Name = "label1";
            label1.Size = new Size(184, 31);
            label1.TabIndex = 25;
            label1.Text = "AQUATRACK";
            // 
            // picaqua
            // 
            picaqua.BackColor = Color.LightSkyBlue;
            picaqua.Location = new Point(211, 95);
            picaqua.Margin = new Padding(3, 2, 3, 2);
            picaqua.Name = "picaqua";
            picaqua.Size = new Size(482, 370);
            picaqua.TabIndex = 24;
            picaqua.TabStop = false;
            // 
            // label2
            // 
            lblDistance.AutoSize = true;
            lblDistance.BackColor = Color.LightSkyBlue;
            lblDistance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistance.ForeColor = Color.MidnightBlue;
            lblDistance.Location = new Point(262, 216);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(76, 20);
            lblDistance.TabIndex = 34;
            lblDistance.Text = "Distance:";
            // 
            // label3
            // 
            lblJugPrice.AutoSize = true;
            lblJugPrice.BackColor = Color.LightSkyBlue;
            lblJugPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugPrice.ForeColor = Color.MidnightBlue;
            lblJugPrice.Location = new Point(262, 303);
            lblJugPrice.Name = "lblJugPrice";
            lblJugPrice.Size = new Size(78, 20);
            lblJugPrice.TabIndex = 35;
            lblJugPrice.Text = "Jug Price:";
            // 
            // label4
            // 
            lblShippingFee.AutoSize = true;
            lblShippingFee.BackColor = Color.LightSkyBlue;
            lblShippingFee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShippingFee.ForeColor = Color.MidnightBlue;
            lblShippingFee.Location = new Point(262, 340);
            lblShippingFee.Name = "lblShippingFee";
            lblShippingFee.Size = new Size(107, 20);
            lblShippingFee.TabIndex = 36;
            lblShippingFee.Text = "Shipping Fee:";
            lblShippingFee.Click += lblShippingFee_Click;
            // 
            // label5
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.LightSkyBlue;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.MidnightBlue;
            lblSubtotal.Location = new Point(263, 323);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(73, 20);
            lblSubtotal.TabIndex = 37;
            lblSubtotal.Text = "Subtotal:";
            // 
            // label6
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.LightSkyBlue;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.MidnightBlue;
            lblTotal.Location = new Point(262, 373);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(108, 20);
            lblTotal.TabIndex = 38;
            lblTotal.Text = "Total Amount:";
            lblTotal.Click += lblTotal_Click;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6af8a2c9_bda3_400a_9a2d_83c82351fcaa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 562);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(lblShippingFee);
            Controls.Add(lblJugPrice);
            Controls.Add(lblDistance);
            Controls.Add(btnClose);
            Controls.Add(lblQuantity);
            Controls.Add(lblReceiptTitle);
            Controls.Add(lblJugType);
            Controls.Add(lblAddress);
            Controls.Add(lblCustomer);
            Controls.Add(label1);
            Controls.Add(picaqua);
            Name = "Receipt";
            Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)picaqua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lblQuantity;
        private Label lblReceiptTitle;
        private Label lblJugType;
        private Label lblAddress;
        private Label lblCustomer;
        private Label label1;
        private PictureBox picaqua;
        private Label lblDistance;
        private Label lblJugPrice;
        private Label lblShippingFee;
        private Label lblSubtotal;
        private Label lblTotal;
    }
}