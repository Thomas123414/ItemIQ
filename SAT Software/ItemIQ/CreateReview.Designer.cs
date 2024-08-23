namespace ItemIQ
{
    partial class CreateReview
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtDate = new TextBox();
            txtReviewInfo = new TextBox();
            txtReviewRating = new TextBox();
            btnClose = new Button();
            btnReview = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 43);
            label1.TabIndex = 0;
            label1.Text = "Create Review!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 66);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 139);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "Review Infomation:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 2;
            label4.Text = "Date (dd/mm/yyyy):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 319);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 3;
            label5.Text = "Review Rating (?/10):";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(153, 66);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(348, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(153, 103);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(348, 27);
            txtDate.TabIndex = 5;
            // 
            // txtReviewInfo
            // 
            txtReviewInfo.Location = new Point(153, 139);
            txtReviewInfo.MaximumSize = new Size(348, 175);
            txtReviewInfo.MinimumSize = new Size(348, 175);
            txtReviewInfo.Name = "txtReviewInfo";
            txtReviewInfo.Size = new Size(348, 175);
            txtReviewInfo.TabIndex = 6;
            // 
            // txtReviewRating
            // 
            txtReviewRating.Location = new Point(153, 319);
            txtReviewRating.Name = "txtReviewRating";
            txtReviewRating.Size = new Size(348, 27);
            txtReviewRating.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Cyan;
            btnClose.Location = new Point(68, 359);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 35);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close Review!";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnReview
            // 
            btnReview.BackColor = Color.Cyan;
            btnReview.Location = new Point(277, 359);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(147, 35);
            btnReview.TabIndex = 9;
            btnReview.Text = "Confirm Review!";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click;
            // 
            // CreateReview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(521, 406);
            Controls.Add(btnReview);
            Controls.Add(btnClose);
            Controls.Add(txtReviewRating);
            Controls.Add(txtReviewInfo);
            Controls.Add(txtDate);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateReview";
            Text = "CreateReview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtDate;
        private TextBox txtReviewInfo;
        private TextBox txtReviewRating;
        private Button btnClose;
        private Button btnReview;
    }
}