namespace CafeShopManagementSystem
{
    partial class CashierMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMainForm));
            this.logout_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customer_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminDashboardForm1 = new CafeShopManagementSystem.AdminDashboardForm();
            this.adminAddProducts1 = new CafeShopManagementSystem.AdminAddProducts();
            this.cashierOrderForm1 = new CafeShopManagementSystem.CashierOrderForm();
            this.cashierCustomersForm1 = new CafeShopManagementSystem.CashierCustomersForm();
            this.close = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Black;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.DimGray;
            this.logout_btn.Location = new System.Drawing.Point(20, 717);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(214, 46);
            this.logout_btn.TabIndex = 30;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.order_btn.Location = new System.Drawing.Point(20, 487);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(214, 46);
            this.order_btn.TabIndex = 29;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addProducts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.addProducts_btn.Location = new System.Drawing.Point(20, 417);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(214, 46);
            this.addProducts_btn.TabIndex = 28;
            this.addProducts_btn.Text = "Add Products";
            this.addProducts_btn.UseVisualStyleBackColor = false;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dashboard_btn.Location = new System.Drawing.Point(20, 343);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(214, 46);
            this.dashboard_btn.TabIndex = 26;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(50, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cashier\'s Portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1500, 793);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // customer_btn
            // 
            this.customer_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.customer_btn.Location = new System.Drawing.Point(20, 559);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(214, 46);
            this.customer_btn.TabIndex = 31;
            this.customer_btn.Text = "Customers";
            this.customer_btn.UseVisualStyleBackColor = false;
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminDashboardForm1);
            this.panel1.Controls.Add(this.adminAddProducts1);
            this.panel1.Controls.Add(this.cashierOrderForm1);
            this.panel1.Controls.Add(this.cashierCustomersForm1);
            this.panel1.Location = new System.Drawing.Point(248, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 698);
            this.panel1.TabIndex = 32;
            // 
            // adminDashboardForm1
            // 
            this.adminDashboardForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.adminDashboardForm1.Location = new System.Drawing.Point(-9, 0);
            this.adminDashboardForm1.Name = "adminDashboardForm1";
            this.adminDashboardForm1.Size = new System.Drawing.Size(1240, 701);
            this.adminDashboardForm1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1240, 701);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // cashierOrderForm1
            // 
            this.cashierOrderForm1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierOrderForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierOrderForm1.Name = "cashierOrderForm1";
            this.cashierOrderForm1.Size = new System.Drawing.Size(1240, 701);
            this.cashierOrderForm1.TabIndex = 1;
            // 
            // cashierCustomersForm1
            // 
            this.cashierCustomersForm1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cashierCustomersForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCustomersForm1.Name = "cashierCustomersForm1";
            this.cashierCustomersForm1.Size = new System.Drawing.Size(1240, 701);
            this.cashierCustomersForm1.TabIndex = 0;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1459, 21);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 21);
            this.close.TabIndex = 33;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(77, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Welcome!";
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 790);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customer_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.addProducts_btn);
            this.Controls.Add(this.dashboard_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierMainForm";
            this.Text = "CashierMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private AdminDashboardForm adminDashboardForm1;
        private AdminAddProducts adminAddProducts1;
        private CashierOrderForm cashierOrderForm1;
        private CashierCustomersForm cashierCustomersForm1;
        private System.Windows.Forms.Label label3;
    }
}