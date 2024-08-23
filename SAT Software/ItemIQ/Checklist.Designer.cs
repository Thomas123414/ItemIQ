namespace ItemIQ
{
    partial class Checklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checklist));
            btnLogOut = new Button();
            btnProfile = new Button();
            btnChecklist = new Button();
            btnCheckout = new Button();
            btnHome = new Button();
            CLB = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtChecklistName = new TextBox();
            txtChecklistPrice = new TextBox();
            btnChecklistAdd = new Button();
            lblChecklistPrice = new Label();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Cyan;
            btnLogOut.Font = new Font("Impact", 9.75F);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.Location = new Point(811, 1);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(202, 63);
            btnLogOut.TabIndex = 13;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Cyan;
            btnProfile.Font = new Font("Impact", 9.75F);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(603, 1);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(202, 63);
            btnProfile.TabIndex = 12;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnChecklist
            // 
            btnChecklist.BackColor = Color.Cyan;
            btnChecklist.Font = new Font("Impact", 9.75F);
            btnChecklist.Image = (Image)resources.GetObject("btnChecklist.Image");
            btnChecklist.ImageAlign = ContentAlignment.MiddleRight;
            btnChecklist.Location = new Point(394, 1);
            btnChecklist.Name = "btnChecklist";
            btnChecklist.Size = new Size(202, 63);
            btnChecklist.TabIndex = 11;
            btnChecklist.Text = "Checklist";
            btnChecklist.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.Cyan;
            btnCheckout.Font = new Font("Impact", 9.75F);
            btnCheckout.Image = (Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.ImageAlign = ContentAlignment.MiddleRight;
            btnCheckout.Location = new Point(196, 1);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(202, 63);
            btnCheckout.TabIndex = 10;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Cyan;
            btnHome.Font = new Font("Impact", 9.75F);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleRight;
            btnHome.Location = new Point(1, 1);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(202, 63);
            btnHome.TabIndex = 9;
            btnHome.Text = "HomePage";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // CLB
            // 
            CLB.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CLB.FormattingEnabled = true;
            CLB.Items.AddRange(new object[] { "" });
            CLB.Location = new Point(12, 70);
            CLB.Name = "CLB";
            CLB.ScrollAlwaysVisible = true;
            CLB.Size = new Size(682, 274);
            CLB.TabIndex = 14;
            CLB.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(754, 80);
            label1.Name = "label1";
            label1.Size = new Size(198, 34);
            label1.TabIndex = 15;
            label1.Text = "Add to checklist!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(700, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 16;
            label2.Text = "Item Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F);
            label3.Location = new Point(738, 174);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 17;
            label3.Text = "Price:";
            // 
            // txtChecklistName
            // 
            txtChecklistName.Location = new Point(795, 140);
            txtChecklistName.Name = "txtChecklistName";
            txtChecklistName.Size = new Size(207, 23);
            txtChecklistName.TabIndex = 18;
            // 
            // txtChecklistPrice
            // 
            txtChecklistPrice.Location = new Point(795, 174);
            txtChecklistPrice.Name = "txtChecklistPrice";
            txtChecklistPrice.Size = new Size(207, 23);
            txtChecklistPrice.TabIndex = 19;
            // 
            // btnChecklistAdd
            // 
            btnChecklistAdd.BackColor = Color.Cyan;
            btnChecklistAdd.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChecklistAdd.Location = new Point(743, 229);
            btnChecklistAdd.Name = "btnChecklistAdd";
            btnChecklistAdd.Size = new Size(209, 33);
            btnChecklistAdd.TabIndex = 20;
            btnChecklistAdd.Text = "Add item to checklist!";
            btnChecklistAdd.UseVisualStyleBackColor = false;
            btnChecklistAdd.Click += btnChecklistAdd_Click;
            // 
            // lblChecklistPrice
            // 
            lblChecklistPrice.AutoSize = true;
            lblChecklistPrice.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChecklistPrice.Location = new Point(718, 306);
            lblChecklistPrice.Name = "lblChecklistPrice";
            lblChecklistPrice.Size = new Size(145, 23);
            lblChecklistPrice.TabIndex = 21;
            lblChecklistPrice.Text = "Total price of list:";
            // 
            // Checklist
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1014, 353);
            Controls.Add(lblChecklistPrice);
            Controls.Add(btnChecklistAdd);
            Controls.Add(txtChecklistPrice);
            Controls.Add(txtChecklistName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CLB);
            Controls.Add(btnLogOut);
            Controls.Add(btnProfile);
            Controls.Add(btnChecklist);
            Controls.Add(btnCheckout);
            Controls.Add(btnHome);
            Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Checklist";
            Text = "Checklist";
            Load += Checklist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnProfile;
        private Button btnChecklist;
        private Button btnCheckout;
        private Button btnHome;
        private CheckedListBox CLB;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtChecklistName;
        private TextBox txtChecklistPrice;
        private Button btnChecklistAdd;
        private Label lblChecklistPrice;
    }
}