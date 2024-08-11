namespace ItemIQ
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            btnLogOut = new Button();
            btnProfile = new Button();
            btnChecklist = new Button();
            btnCheckout = new Button();
            btnHome = new Button();
            lsvCartList = new ListView();
            ItemName = new ColumnHeader();
            Price = new ColumnHeader();
            NumberOfItems = new ColumnHeader();
            TotalItemPrice = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            txtCardNumber = new TextBox();
            txtCardDate = new TextBox();
            txtCardName = new TextBox();
            txtCardCvc = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnPay = new Button();
            lblTotalPrice = new Label();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.DarkSlateBlue;
            btnLogOut.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(813, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(202, 63);
            btnLogOut.TabIndex = 13;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.DarkSlateBlue;
            btnProfile.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(605, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(202, 63);
            btnProfile.TabIndex = 12;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnChecklist
            // 
            btnChecklist.BackColor = Color.DarkSlateBlue;
            btnChecklist.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnChecklist.Image = (Image)resources.GetObject("btnChecklist.Image");
            btnChecklist.ImageAlign = ContentAlignment.MiddleRight;
            btnChecklist.Location = new Point(396, 2);
            btnChecklist.Name = "btnChecklist";
            btnChecklist.Size = new Size(202, 63);
            btnChecklist.TabIndex = 11;
            btnChecklist.Text = "Checklist";
            btnChecklist.UseVisualStyleBackColor = false;
            btnChecklist.Click += btnChecklist_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.DarkSlateBlue;
            btnCheckout.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnCheckout.Image = (Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.ImageAlign = ContentAlignment.MiddleRight;
            btnCheckout.Location = new Point(198, 2);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(202, 63);
            btnCheckout.TabIndex = 10;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkSlateBlue;
            btnHome.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleRight;
            btnHome.Location = new Point(3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(202, 63);
            btnHome.TabIndex = 9;
            btnHome.Text = "HomePage";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lsvCartList
            // 
            lsvCartList.Columns.AddRange(new ColumnHeader[] { ItemName, Price, NumberOfItems, TotalItemPrice });
            lsvCartList.Location = new Point(3, 119);
            lsvCartList.Name = "lsvCartList";
            lsvCartList.Size = new Size(1012, 277);
            lsvCartList.TabIndex = 14;
            lsvCartList.UseCompatibleStateImageBehavior = false;
            lsvCartList.View = View.Details;
            // 
            // ItemName
            // 
            ItemName.Text = "ItemName:";
            ItemName.Width = 400;
            // 
            // Price
            // 
            Price.Text = "Price:";
            Price.Width = 180;
            // 
            // NumberOfItems
            // 
            NumberOfItems.Text = "# of Item";
            NumberOfItems.Width = 180;
            // 
            // TotalItemPrice
            // 
            TotalItemPrice.Text = "Total Price for Item";
            TotalItemPrice.Width = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(166, 44);
            label2.TabIndex = 15;
            label2.Text = "Checkout:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 399);
            label1.Name = "label1";
            label1.Size = new Size(161, 44);
            label1.TabIndex = 16;
            label1.Text = "Payment:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(541, 457);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(204, 23);
            txtCardNumber.TabIndex = 17;
            // 
            // txtCardDate
            // 
            txtCardDate.Location = new Point(541, 498);
            txtCardDate.Name = "txtCardDate";
            txtCardDate.Size = new Size(204, 23);
            txtCardDate.TabIndex = 18;
            // 
            // txtCardName
            // 
            txtCardName.Location = new Point(541, 418);
            txtCardName.Name = "txtCardName";
            txtCardName.Size = new Size(204, 23);
            txtCardName.TabIndex = 19;
            // 
            // txtCardCvc
            // 
            txtCardCvc.Location = new Point(541, 538);
            txtCardCvc.Name = "txtCardCvc";
            txtCardCvc.Size = new Size(204, 23);
            txtCardCvc.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(438, 418);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 21;
            label3.Text = "Card Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(422, 457);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 22;
            label4.Text = "Card Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(394, 498);
            label5.Name = "label5";
            label5.Size = new Size(134, 19);
            label5.TabIndex = 23;
            label5.Text = "Card Expiry Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(451, 538);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 24;
            label6.Text = "Card CVC:";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.DarkSlateBlue;
            btnPay.Font = new Font("Bernard MT Condensed", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(781, 470);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(195, 47);
            btnPay.TabIndex = 25;
            btnPay.Text = "Pay for items!";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(28, 531);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(217, 28);
            lblTotalPrice.TabIndex = 26;
            lblTotalPrice.Text = "Total Price for cart:";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1017, 572);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnPay);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCardCvc);
            Controls.Add(txtCardName);
            Controls.Add(txtCardDate);
            Controls.Add(txtCardNumber);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lsvCartList);
            Controls.Add(btnLogOut);
            Controls.Add(btnProfile);
            Controls.Add(btnChecklist);
            Controls.Add(btnCheckout);
            Controls.Add(btnHome);
            Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnProfile;
        private Button btnChecklist;
        private Button btnCheckout;
        private Button btnHome;
        private ListView lsvCartList;
        private ColumnHeader ItemName;
        private ColumnHeader Price;
        private ColumnHeader NumberOfItems;
        private ColumnHeader TotalItemPrice;
        private Label label2;
        private Label label1;
        private TextBox txtCardNumber;
        private TextBox txtCardDate;
        private TextBox txtCardName;
        private TextBox txtCardCvc;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnPay;
        private Label lblTotalPrice;
    }
}