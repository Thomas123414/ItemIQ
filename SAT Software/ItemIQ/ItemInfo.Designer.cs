namespace ItemIQ
{
    partial class ItemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInfo));
            btnClose = new Button();
            label1 = new Label();
            PicItem = new PictureBox();
            lblItemName = new Label();
            lblItemPrice = new Label();
            lblItemDes = new Label();
            lblItemIngredients = new Label();
            label2 = new Label();
            lsvReviews = new ListView();
            lsvUsername = new ColumnHeader();
            lsvDate = new ColumnHeader();
            lsvReviewInfo = new ColumnHeader();
            lsvReviewRating = new ColumnHeader();
            btnCreateReview = new Button();
            ((System.ComponentModel.ISupportInitialize)PicItem).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Cyan;
            btnClose.Location = new Point(344, 700);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(207, 48);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close Item Infomation";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(486, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 43);
            label1.TabIndex = 1;
            label1.Text = "Item info:";
            // 
            // PicItem
            // 
            PicItem.Image = (Image)resources.GetObject("PicItem.Image");
            PicItem.Location = new Point(6, 67);
            PicItem.Name = "PicItem";
            PicItem.Size = new Size(484, 307);
            PicItem.SizeMode = PictureBoxSizeMode.StretchImage;
            PicItem.TabIndex = 2;
            PicItem.TabStop = false;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(496, 67);
            lblItemName.MaximumSize = new Size(328, 0);
            lblItemName.MinimumSize = new Size(328, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(328, 23);
            lblItemName.TabIndex = 3;
            lblItemName.Text = "Item:";
            lblItemName.Click += lblItemName_Click;
            // 
            // lblItemPrice
            // 
            lblItemPrice.AutoSize = true;
            lblItemPrice.Location = new Point(496, 100);
            lblItemPrice.MaximumSize = new Size(328, 0);
            lblItemPrice.MinimumSize = new Size(328, 0);
            lblItemPrice.Name = "lblItemPrice";
            lblItemPrice.Size = new Size(328, 23);
            lblItemPrice.TabIndex = 4;
            lblItemPrice.Text = "Price:";
            // 
            // lblItemDes
            // 
            lblItemDes.AutoSize = true;
            lblItemDes.Location = new Point(496, 133);
            lblItemDes.MaximumSize = new Size(328, 238);
            lblItemDes.MinimumSize = new Size(328, 238);
            lblItemDes.Name = "lblItemDes";
            lblItemDes.Size = new Size(328, 238);
            lblItemDes.TabIndex = 5;
            lblItemDes.Text = "ItemDescription";
            // 
            // lblItemIngredients
            // 
            lblItemIngredients.AutoSize = true;
            lblItemIngredients.Location = new Point(832, 67);
            lblItemIngredients.MaximumSize = new Size(300, 300);
            lblItemIngredients.MinimumSize = new Size(300, 300);
            lblItemIngredients.Name = "lblItemIngredients";
            lblItemIngredients.Size = new Size(300, 300);
            lblItemIngredients.TabIndex = 6;
            lblItemIngredients.Text = "ItemIngredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 377);
            label2.Name = "label2";
            label2.Size = new Size(152, 45);
            label2.TabIndex = 7;
            label2.Text = "Reviews:";
            // 
            // lsvReviews
            // 
            lsvReviews.Columns.AddRange(new ColumnHeader[] { lsvUsername, lsvDate, lsvReviewInfo, lsvReviewRating });
            lsvReviews.Location = new Point(12, 425);
            lsvReviews.Name = "lsvReviews";
            lsvReviews.Size = new Size(1120, 269);
            lsvReviews.TabIndex = 8;
            lsvReviews.UseCompatibleStateImageBehavior = false;
            lsvReviews.View = View.Details;
            // 
            // lsvUsername
            // 
            lsvUsername.Text = "Username:";
            lsvUsername.Width = 200;
            // 
            // lsvDate
            // 
            lsvDate.Text = "Date: (dd/mm/yyyy)";
            lsvDate.Width = 170;
            // 
            // lsvReviewInfo
            // 
            lsvReviewInfo.Text = "Review Info:";
            lsvReviewInfo.Width = 570;
            // 
            // lsvReviewRating
            // 
            lsvReviewRating.Text = "Review Rating: (?/10)";
            lsvReviewRating.Width = 175;
            // 
            // btnCreateReview
            // 
            btnCreateReview.BackColor = Color.Cyan;
            btnCreateReview.Location = new Point(606, 700);
            btnCreateReview.Name = "btnCreateReview";
            btnCreateReview.Size = new Size(207, 48);
            btnCreateReview.TabIndex = 9;
            btnCreateReview.Text = "Create Item Review!";
            btnCreateReview.UseVisualStyleBackColor = false;
            btnCreateReview.Click += btnCreateReview_Click;
            // 
            // ItemInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1139, 749);
            Controls.Add(btnCreateReview);
            Controls.Add(lsvReviews);
            Controls.Add(label2);
            Controls.Add(lblItemIngredients);
            Controls.Add(lblItemDes);
            Controls.Add(lblItemPrice);
            Controls.Add(lblItemName);
            Controls.Add(PicItem);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ItemInfo";
            Text = "ItemInfo";
            Load += ItemInfo_Load;
            ((System.ComponentModel.ISupportInitialize)PicItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private PictureBox PicItem;
        private Label lblItemName;
        private Label lblItemPrice;
        private Label lblItemDes;
        private Label lblItemIngredients;
        private Label label2;
        private ListView lsvReviews;
        private Button btnCreateReview;
        private ColumnHeader lsvUsername;
        private ColumnHeader lsvDate;
        private ColumnHeader lsvReviewInfo;
        private ColumnHeader lsvReviewRating;
    }
}