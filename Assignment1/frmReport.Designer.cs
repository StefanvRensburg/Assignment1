
namespace Assignment1
{
    partial class frmReport
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
            this.lbxReports = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxReports
            // 
            this.lbxReports.FormattingEnabled = true;
            this.lbxReports.Items.AddRange(new object[] {
            " "});
            this.lbxReports.Location = new System.Drawing.Point(12, 12);
            this.lbxReports.Name = "lbxReports";
            this.lbxReports.Size = new System.Drawing.Size(474, 342);
            this.lbxReports.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 389);
            this.Controls.Add(this.lbxReports);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxReports;
    }
}