namespace WinFormsApp22k
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picaqua = new PictureBox();
            txtName = new TextBox();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblJugType = new Label();
            btnorder = new Button();
            colorDialog1 = new ColorDialog();
            cmbJugType = new ComboBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            cmbBarangay = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picaqua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // picaqua
            // 
            picaqua.BackColor = Color.LightSkyBlue;
            picaqua.Location = new Point(206, 95);
            picaqua.Margin = new Padding(3, 2, 3, 2);
            picaqua.Name = "picaqua";
            picaqua.Size = new Size(482, 370);
            picaqua.TabIndex = 0;
            picaqua.TabStop = false;
            picaqua.Click += picaqua_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(282, 222);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 180);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(347, 140);
            label2.Name = "label2";
            label2.Size = new Size(184, 31);
            label2.TabIndex = 6;
            label2.Text = "AQUATRACK";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.LightSkyBlue;
            lblName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(282, 202);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 16);
            lblName.TabIndex = 8;
            lblName.Text = "NAME:";
            lblName.Click += label3_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.LightSkyBlue;
            lblAddress.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.MidnightBlue;
            lblAddress.Location = new Point(282, 262);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(76, 16);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "ADDRESS:";
            lblAddress.Click += label4_Click;
            // 
            // lblJugType
            // 
            lblJugType.AutoSize = true;
            lblJugType.BackColor = Color.LightSkyBlue;
            lblJugType.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugType.ForeColor = Color.MidnightBlue;
            lblJugType.Location = new Point(282, 319);
            lblJugType.Name = "lblJugType";
            lblJugType.Size = new Size(158, 16);
            lblJugType.TabIndex = 10;
            lblJugType.Text = "TYPES OF CONTAINER:";
            lblJugType.Click += label5_Click;
            // 
            // btnorder
            // 
            btnorder.BackgroundImageLayout = ImageLayout.None;
            btnorder.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnorder.ForeColor = Color.MidnightBlue;
            btnorder.Location = new Point(399, 384);
            btnorder.Margin = new Padding(3, 2, 3, 2);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(82, 22);
            btnorder.TabIndex = 11;
            btnorder.Text = "ORDER";
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnOrder_Click;
            // 
            // cmbJugType
            // 
            cmbJugType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJugType.FormattingEnabled = true;
            cmbJugType.Location = new Point(282, 341);
            cmbJugType.Margin = new Padding(3, 2, 3, 2);
            cmbJugType.Name = "cmbJugType";
            cmbJugType.Size = new Size(158, 23);
            cmbJugType.TabIndex = 12;
            cmbJugType.SelectedIndexChanged += cmbJugType_SelectedIndexChanged_1;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.LightSkyBlue;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.MidnightBlue;
            lblQuantity.Location = new Point(467, 319);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(93, 16);
            lblQuantity.TabIndex = 13;
            lblQuantity.Text = "No. of Quantity";
            lblQuantity.Click += label3_Click_1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(467, 341);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(132, 23);
            numQuantity.TabIndex = 14;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // cmbBarangay
            // 
            cmbBarangay.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarangay.FormattingEnabled = true;
            cmbBarangay.Location = new Point(282, 285);
            cmbBarangay.Name = "cmbBarangay";
            cmbBarangay.Size = new Size(317, 23);
            cmbBarangay.TabIndex = 15;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6af8a2c9_bda3_400a_9a2d_83c82351fcaa;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(859, 562);
            Controls.Add(cmbBarangay);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbJugType);
            Controls.Add(btnorder);
            Controls.Add(lblJugType);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(picaqua);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form1";
            Text = "AquaTrack";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picaqua).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picaqua;
        private TextBox txtName;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private Label lblName;
        private Label lblAddress;
        private Label lblJugType;
        private Button btnorder;
        private ColorDialog colorDialog1;
        private ComboBox cmbJugType;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private ComboBox cmbBarangay;
    }
}
