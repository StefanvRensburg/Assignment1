
namespace Assignment1
{
    partial class frmAdd
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
            this.tbxType = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(106, 31);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(100, 20);
            this.tbxType.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(106, 71);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(106, 114);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(100, 20);
            this.tbxStock.TabIndex = 2;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(106, 158);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(106, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(54, 38);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(54, 121);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(54, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.label4_Click);
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 259);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxStock);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxType);
            this.Name = "New";
            this.Text = "frmNewDrink";
            this.Load += new System.EventHandler(this.frmNewDrink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
    }
}