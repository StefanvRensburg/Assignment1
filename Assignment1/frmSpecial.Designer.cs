
namespace Assignment1
{
    partial class frmSpecial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxYes = new System.Windows.Forms.CheckBox();
            this.cbxNo = new System.Windows.Forms.CheckBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Is Item On Special";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Price:";
            // 
            // cbxYes
            // 
            this.cbxYes.AutoSize = true;
            this.cbxYes.Location = new System.Drawing.Point(107, 35);
            this.cbxYes.Name = "cbxYes";
            this.cbxYes.Size = new System.Drawing.Size(44, 17);
            this.cbxYes.TabIndex = 3;
            this.cbxYes.Text = "Yes";
            this.cbxYes.UseVisualStyleBackColor = true;
            // 
            // cbxNo
            // 
            this.cbxNo.AutoSize = true;
            this.cbxNo.Location = new System.Drawing.Point(107, 64);
            this.cbxNo.Name = "cbxNo";
            this.cbxNo.Size = new System.Drawing.Size(40, 17);
            this.cbxNo.TabIndex = 4;
            this.cbxNo.Text = "No";
            this.cbxNo.UseVisualStyleBackColor = true;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(95, 98);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(56, 20);
            this.tbxPrice.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Special";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.cbxNo);
            this.Controls.Add(this.cbxYes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmSpecial";
            this.Text = "frmSpecial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxYes;
        private System.Windows.Forms.CheckBox cbxNo;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Button button1;
    }
}