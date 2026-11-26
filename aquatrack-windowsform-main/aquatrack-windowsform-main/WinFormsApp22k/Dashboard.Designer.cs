namespace WinFormsApp22k
{
    partial class Dashboard
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
            lblJugType = new Label();
            lblAddress = new Label();
            lblName = new Label();
            label1 = new Label();
            picaqua = new PictureBox();
            lblTitle = new Label();
            lblQuantity = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            lblDistance = new Label();
            label3 = new Label();
            lblShippingFee = new Label();
            lblJugPrice = new Label();
            lblSubtotal = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)picaqua).BeginInit();
            SuspendLayout();
            // 
            // lblJugType
            // 
            lblJugType.AutoSize = true;
            lblJugType.BackColor = Color.LightSkyBlue;
            lblJugType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugType.ForeColor = Color.MidnightBlue;
            lblJugType.Location = new Point(262, 205);
            lblJugType.Name = "lblJugType";
            lblJugType.Size = new Size(77, 20);
            lblJugType.TabIndex = 19;
            lblJugType.Text = "Jug Type:";
            lblJugType.Click += lblJugType_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.LightSkyBlue;
            lblAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.MidnightBlue;
            lblAddress.Location = new Point(263, 185);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(72, 20);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.LightSkyBlue;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(263, 165);
            lblName.Name = "lblName";
            lblName.Size = new Size(128, 20);
            lblName.TabIndex = 17;
            lblName.Text = "Customer Name:";
            lblName.Click += lblName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(371, 104);
            label1.Name = "label1";
            label1.Size = new Size(184, 31);
            label1.TabIndex = 16;
            label1.Text = "AQUATRACK";
            // 
            // picaqua
            // 
            picaqua.BackColor = Color.LightSkyBlue;
            picaqua.Location = new Point(212, 93);
            picaqua.Margin = new Padding(3, 2, 3, 2);
            picaqua.Name = "picaqua";
            picaqua.Size = new Size(482, 370);
            picaqua.TabIndex = 13;
            picaqua.TabStop = false;
            picaqua.Click += picaqua_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.LightSkyBlue;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(391, 135);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 20);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Order Confirmation";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.LightSkyBlue;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.MidnightBlue;
            lblQuantity.Location = new Point(263, 225);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 21;
            lblQuantity.Text = "Quantity:";
            // 
            // btnConfirm
            // 
            btnConfirm.ForeColor = Color.MidnightBlue;
            btnConfirm.Location = new Point(338, 426);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(96, 23);
            btnConfirm.TabIndex = 22;
            btnConfirm.Text = "Confirm Order";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.MidnightBlue;
            btnCancel.Location = new Point(480, 426);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.BackColor = Color.LightSkyBlue;
            lblDistance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistance.ForeColor = Color.MidnightBlue;
            lblDistance.Location = new Point(263, 284);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(190, 20);
            lblDistance.TabIndex = 24;
            lblDistance.Text = "Distance from Caganhao:";
            lblDistance.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(391, 264);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 25;
            label3.Text = "Order Details";
            label3.Click += label3_Click;
            // 
            // lblShippingFee
            // 
            lblShippingFee.AutoSize = true;
            lblShippingFee.BackColor = Color.LightSkyBlue;
            lblShippingFee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShippingFee.ForeColor = Color.MidnightBlue;
            lblShippingFee.Location = new Point(263, 304);
            lblShippingFee.Name = "lblShippingFee";
            lblShippingFee.Size = new Size(107, 20);
            lblShippingFee.TabIndex = 26;
            lblShippingFee.Text = "Shipping Fee:";
            // 
            // lblJugPrice
            // 
            lblJugPrice.AutoSize = true;
            lblJugPrice.BackColor = Color.LightSkyBlue;
            lblJugPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugPrice.ForeColor = Color.MidnightBlue;
            lblJugPrice.Location = new Point(263, 324);
            lblJugPrice.Name = "lblJugPrice";
            lblJugPrice.Size = new Size(78, 20);
            lblJugPrice.TabIndex = 27;
            lblJugPrice.Text = "Jug Price:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.LightSkyBlue;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.MidnightBlue;
            lblSubtotal.Location = new Point(263, 344);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(191, 20);
            lblSubtotal.TabIndex = 28;
            lblSubtotal.Text = "SubTotal (Jug x Quantity):";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.LightSkyBlue;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.MidnightBlue;
            lblTotal.Location = new Point(263, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(108, 20);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total Amount:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources._6af8a2c9_bda3_400a_9a2d_83c82351fcaa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 562);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(lblJugPrice);
            Controls.Add(lblShippingFee);
            Controls.Add(label3);
            Controls.Add(lblDistance);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblQuantity);
            Controls.Add(lblTitle);
            Controls.Add(lblJugType);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(picaqua);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            Text = "Order Confirmation";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)picaqua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbJugType;
        private Button btnorder;
        private Label lblJugType;
        private Label lblAddress;
        private Label lblName;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtName;
        private PictureBox picaqua;
        private Label lblTitle;
        private Label lblQuantity;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lblDistance;
        private Label label3;
        private Label lblShippingFee;
        private Label lblJugPrice;
        private Label lblSubtotal;
        private Label lblTotal;
    }
}