namespace ItemIQ
{
    partial class addingproducts
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
            txtlink = new TextBox();
            txtname = new TextBox();
            txtdes = new TextBox();
            txtprice = new TextBox();
            txtid = new TextBox();
            btnadd = new Button();
            SuspendLayout();
            // 
            // txtlink
            // 
            txtlink.Location = new Point(181, 80);
            txtlink.Name = "txtlink";
            txtlink.Size = new Size(456, 23);
            txtlink.TabIndex = 0;
            // 
            // txtname
            // 
            txtname.Location = new Point(181, 118);
            txtname.Name = "txtname";
            txtname.Size = new Size(456, 23);
            txtname.TabIndex = 1;
            txtname.TextChanged += textBox1_TextChanged;
            // 
            // txtdes
            // 
            txtdes.Location = new Point(181, 161);
            txtdes.Name = "txtdes";
            txtdes.Size = new Size(456, 23);
            txtdes.TabIndex = 2;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(181, 208);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(456, 23);
            txtprice.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Location = new Point(181, 37);
            txtid.Name = "txtid";
            txtid.Size = new Size(456, 23);
            txtid.TabIndex = 4;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(370, 261);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 5;
            btnadd.Text = "button1";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // addingproducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnadd);
            Controls.Add(txtid);
            Controls.Add(txtprice);
            Controls.Add(txtdes);
            Controls.Add(txtname);
            Controls.Add(txtlink);
            Name = "addingproducts";
            Text = "addingproducts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlink;
        private TextBox txtname;
        private TextBox txtdes;
        private TextBox txtprice;
        private TextBox txtid;
        private Button btnadd;
    }
}