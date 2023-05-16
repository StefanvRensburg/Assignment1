
namespace Assignment1
{
    partial class frmStaff
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUpdateDrinks = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteDrink = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(642, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 223);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(642, 191);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnUpdateDrinks
            // 
            this.btnUpdateDrinks.Location = new System.Drawing.Point(678, 12);
            this.btnUpdateDrinks.Name = "btnUpdateDrinks";
            this.btnUpdateDrinks.Size = new System.Drawing.Size(123, 24);
            this.btnUpdateDrinks.TabIndex = 2;
            this.btnUpdateDrinks.Text = "Update";
            this.btnUpdateDrinks.UseVisualStyleBackColor = true;
            this.btnUpdateDrinks.Click += new System.EventHandler(this.btnUpdateDrinks_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(678, 42);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 29);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Add New Item";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(678, 223);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateFood.TabIndex = 4;
            this.btnUpdateFood.Text = "Update";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(678, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add New Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteDrink
            // 
            this.btnDeleteDrink.Location = new System.Drawing.Point(679, 77);
            this.btnDeleteDrink.Name = "btnDeleteDrink";
            this.btnDeleteDrink.Size = new System.Drawing.Size(122, 26);
            this.btnDeleteDrink.TabIndex = 6;
            this.btnDeleteDrink.Text = "Delete Drink Item";
            this.btnDeleteDrink.UseVisualStyleBackColor = true;
            this.btnDeleteDrink.Click += new System.EventHandler(this.btnDeleteDrink_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(679, 284);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(122, 26);
            this.btnDeleteFood.TabIndex = 7;
            this.btnDeleteFood.Text = "Delete Food Item";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(678, 145);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 37);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Daily Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 427);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnDeleteDrink);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdateFood);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdateDrinks);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUpdateDrinks;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnGenerate;
    }
}