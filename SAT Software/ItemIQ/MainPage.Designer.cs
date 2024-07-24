namespace ItemIQ
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnHome = new Button();
            btnCheckout = new Button();
            btnChecklist = new Button();
            btnProfile = new Button();
            btnLogOut = new Button();
            pictureBox10 = new PictureBox();
            btnNextItem = new Button();
            btnAddtocart = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblRecommendItemText = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            PicCucumber = new PictureBox();
            lblCucumber = new Label();
            btnCucumber = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button2 = new Button();
            flowLayoutPanel8 = new FlowLayoutPanel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            flowLayoutPanel10 = new FlowLayoutPanel();
            flowLayoutPanel11 = new FlowLayoutPanel();
            flowLayoutPanel12 = new FlowLayoutPanel();
            flowLayoutPanel13 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicCucumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 386);
            label1.Name = "label1";
            label1.Size = new Size(415, 57);
            label1.TabIndex = 1;
            label1.Text = "Grocery Store Items:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(722, 404);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search:";
            textBox1.Size = new Size(269, 36);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(361, 57);
            label2.TabIndex = 3;
            label2.Text = "Recommend Item";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkSlateBlue;
            btnHome.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleRight;
            btnHome.Location = new Point(1, 1);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(202, 63);
            btnHome.TabIndex = 4;
            btnHome.Text = "HomePage";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.DarkSlateBlue;
            btnCheckout.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnCheckout.Image = (Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.ImageAlign = ContentAlignment.MiddleRight;
            btnCheckout.Location = new Point(196, 1);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(202, 63);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnChecklist
            // 
            btnChecklist.BackColor = Color.DarkSlateBlue;
            btnChecklist.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnChecklist.Image = (Image)resources.GetObject("btnChecklist.Image");
            btnChecklist.ImageAlign = ContentAlignment.MiddleRight;
            btnChecklist.Location = new Point(394, 1);
            btnChecklist.Name = "btnChecklist";
            btnChecklist.Size = new Size(202, 63);
            btnChecklist.TabIndex = 6;
            btnChecklist.Text = "Checklist";
            btnChecklist.UseVisualStyleBackColor = false;
            btnChecklist.Click += btnChecklist_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.DarkSlateBlue;
            btnProfile.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(603, 1);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(202, 63);
            btnProfile.TabIndex = 7;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.DarkSlateBlue;
            btnLogOut.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(811, 1);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(202, 63);
            btnLogOut.TabIndex = 8;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(12, 129);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(415, 254);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            // 
            // btnNextItem
            // 
            btnNextItem.BackColor = Color.DarkSlateBlue;
            btnNextItem.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextItem.Image = (Image)resources.GetObject("btnNextItem.Image");
            btnNextItem.ImageAlign = ContentAlignment.MiddleRight;
            btnNextItem.Location = new Point(741, 148);
            btnNextItem.Name = "btnNextItem";
            btnNextItem.Size = new Size(272, 71);
            btnNextItem.TabIndex = 11;
            btnNextItem.Text = "Next item";
            btnNextItem.UseVisualStyleBackColor = false;
            // 
            // btnAddtocart
            // 
            btnAddtocart.BackColor = Color.DarkSlateBlue;
            btnAddtocart.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddtocart.Image = (Image)resources.GetObject("btnAddtocart.Image");
            btnAddtocart.ImageAlign = ContentAlignment.MiddleRight;
            btnAddtocart.Location = new Point(741, 244);
            btnAddtocart.Name = "btnAddtocart";
            btnAddtocart.Size = new Size(272, 71);
            btnAddtocart.TabIndex = 12;
            btnAddtocart.Text = "Add To Cart";
            btnAddtocart.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel9);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel10);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel11);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel12);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel13);
            flowLayoutPanel1.Location = new Point(1, 446);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1012, 303);
            flowLayoutPanel1.TabIndex = 13;
            flowLayoutPanel1.Paint += this.flowLayoutPanel1_Paint;
            // 
            // lblRecommendItemText
            // 
            lblRecommendItemText.AutoSize = true;
            lblRecommendItemText.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecommendItemText.Location = new Point(433, 129);
            lblRecommendItemText.MaximumSize = new Size(300, 251);
            lblRecommendItemText.MinimumSize = new Size(300, 251);
            lblRecommendItemText.Name = "lblRecommendItemText";
            lblRecommendItemText.Size = new Size(300, 251);
            lblRecommendItemText.TabIndex = 10;
            lblRecommendItemText.Text = "The Lebanese cucumber is green skinned, white fleshed and only 15 cm long. It has a juicy texture and a tender skin that does not need to be peeled. Price: 1.78 / 1ea";
            lblRecommendItemText.Click += lblRecommendItemText_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top;
            flowLayoutPanel2.Controls.Add(PicCucumber);
            flowLayoutPanel2.Controls.Add(lblCucumber);
            flowLayoutPanel2.Controls.Add(btnCucumber);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(320, 295);
            flowLayoutPanel2.TabIndex = 14;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(pictureBox1);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(button1);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(329, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(320, 295);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(pictureBox2);
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(button2);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(655, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(320, 295);
            flowLayoutPanel4.TabIndex = 15;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Dock = DockStyle.Bottom;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(3, 304);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(320, 295);
            flowLayoutPanel5.TabIndex = 16;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Dock = DockStyle.Bottom;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(329, 304);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(320, 295);
            flowLayoutPanel6.TabIndex = 17;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Dock = DockStyle.Bottom;
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(655, 304);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(320, 295);
            flowLayoutPanel7.TabIndex = 18;
            // 
            // PicCucumber
            // 
            PicCucumber.Cursor = Cursors.Cross;
            PicCucumber.Image = (Image)resources.GetObject("PicCucumber.Image");
            PicCucumber.Location = new Point(3, 3);
            PicCucumber.Name = "PicCucumber";
            PicCucumber.Size = new Size(317, 138);
            PicCucumber.SizeMode = PictureBoxSizeMode.StretchImage;
            PicCucumber.TabIndex = 0;
            PicCucumber.TabStop = false;
            PicCucumber.Click += pictureBox1_Click_1;
            // 
            // lblCucumber
            // 
            lblCucumber.AutoSize = true;
            lblCucumber.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCucumber.Location = new Point(3, 144);
            lblCucumber.MaximumSize = new Size(315, 0);
            lblCucumber.Name = "lblCucumber";
            lblCucumber.Size = new Size(308, 64);
            lblCucumber.TabIndex = 14;
            lblCucumber.Text = "The Lebanese cucumber is green skinned, white fleshed and only 15 cm long. It has a juicy texture and a tender skin that does not need to be peeled. Price: 1.78 / 1ea";
            // 
            // btnCucumber
            // 
            btnCucumber.BackColor = Color.DarkSlateBlue;
            btnCucumber.ForeColor = SystemColors.ActiveCaptionText;
            btnCucumber.Location = new Point(3, 211);
            btnCucumber.Name = "btnCucumber";
            btnCucumber.Size = new Size(308, 27);
            btnCucumber.TabIndex = 0;
            btnCucumber.Text = "Add to cart";
            btnCucumber.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 144);
            label3.MaximumSize = new Size(315, 0);
            label3.Name = "label3";
            label3.Size = new Size(308, 64);
            label3.TabIndex = 17;
            label3.Text = "The Lebanese cucumber is green skinned, white fleshed and only 15 cm long. It has a juicy texture and a tender skin that does not need to be peeled. Price: 1.78 / 1ea";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(3, 211);
            button1.Name = "button1";
            button1.Size = new Size(308, 27);
            button1.TabIndex = 16;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(317, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 144);
            label4.MaximumSize = new Size(315, 0);
            label4.Name = "label4";
            label4.Size = new Size(308, 64);
            label4.TabIndex = 17;
            label4.Text = "The Lebanese cucumber is green skinned, white fleshed and only 15 cm long. It has a juicy texture and a tender skin that does not need to be peeled. Price: 1.78 / 1ea";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(3, 211);
            button2.Name = "button2";
            button2.Size = new Size(308, 27);
            button2.TabIndex = 16;
            button2.Text = "Add to cart";
            button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Dock = DockStyle.Bottom;
            flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel8.Location = new Point(3, 605);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(320, 295);
            flowLayoutPanel8.TabIndex = 19;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Dock = DockStyle.Bottom;
            flowLayoutPanel9.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel9.Location = new Point(329, 605);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(320, 295);
            flowLayoutPanel9.TabIndex = 20;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Dock = DockStyle.Bottom;
            flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel10.Location = new Point(655, 605);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(320, 295);
            flowLayoutPanel10.TabIndex = 21;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.Dock = DockStyle.Bottom;
            flowLayoutPanel11.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel11.Location = new Point(3, 906);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(320, 295);
            flowLayoutPanel11.TabIndex = 22;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.Dock = DockStyle.Bottom;
            flowLayoutPanel12.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel12.Location = new Point(329, 906);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(320, 295);
            flowLayoutPanel12.TabIndex = 23;
            // 
            // flowLayoutPanel13
            // 
            flowLayoutPanel13.Dock = DockStyle.Bottom;
            flowLayoutPanel13.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel13.Location = new Point(655, 906);
            flowLayoutPanel13.Name = "flowLayoutPanel13";
            flowLayoutPanel13.Size = new Size(320, 295);
            flowLayoutPanel13.TabIndex = 24;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1013, 749);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAddtocart);
            Controls.Add(btnNextItem);
            Controls.Add(lblRecommendItemText);
            Controls.Add(pictureBox10);
            Controls.Add(btnLogOut);
            Controls.Add(btnProfile);
            Controls.Add(btnChecklist);
            Controls.Add(btnCheckout);
            Controls.Add(btnHome);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicCucumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnHome;
        private Button btnCheckout;
        private Button btnChecklist;
        private Button btnProfile;
        private Button btnLogOut;
        private PictureBox pictureBox10;
        private Button btnNextItem;
        private Button btnAddtocart;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblRecommendItemText;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel7;
        private PictureBox PicCucumber;
        private Label lblCucumber;
        private Button btnCucumber;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel8;
        private FlowLayoutPanel flowLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel11;
        private FlowLayoutPanel flowLayoutPanel12;
        private FlowLayoutPanel flowLayoutPanel13;
    }
}