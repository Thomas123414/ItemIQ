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
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.DarkSlateBlue;
            btnLogOut.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
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
            btnProfile.BackColor = Color.DarkSlateBlue;
            btnProfile.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
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
            btnChecklist.BackColor = Color.DarkSlateBlue;
            btnChecklist.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
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
            btnCheckout.BackColor = Color.DarkSlateBlue;
            btnCheckout.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
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
            btnHome.BackColor = Color.DarkSlateBlue;
            btnHome.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Bold);
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
            // Checklist
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1014, 480);
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
        }

        #endregion

        private Button btnLogOut;
        private Button btnProfile;
        private Button btnChecklist;
        private Button btnCheckout;
        private Button btnHome;
    }
}