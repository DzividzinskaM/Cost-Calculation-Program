namespace Cost_Calculation_Program
{
    partial class AddingProductForm
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
            this.ExitBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNewProductBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.SeaShell;
            this.ExitBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Maroon;
            this.ExitBtn.Location = new System.Drawing.Point(739, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(37, 34);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(151, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ціна";
            // 
            // AddNewProductBtn
            // 
            this.AddNewProductBtn.BackColor = System.Drawing.Color.SeaShell;
            this.AddNewProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewProductBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.AddNewProductBtn.FlatAppearance.BorderSize = 3;
            this.AddNewProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProductBtn.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewProductBtn.ForeColor = System.Drawing.Color.Maroon;
            this.AddNewProductBtn.Location = new System.Drawing.Point(35, 326);
            this.AddNewProductBtn.Name = "AddNewProductBtn";
            this.AddNewProductBtn.Size = new System.Drawing.Size(202, 71);
            this.AddNewProductBtn.TabIndex = 13;
            this.AddNewProductBtn.Text = "Додати новий";
            this.AddNewProductBtn.UseVisualStyleBackColor = false;
            this.AddNewProductBtn.Click += new System.EventHandler(this.AddNewProductBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.SeaShell;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BackBtn.FlatAppearance.BorderSize = 3;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.ForeColor = System.Drawing.Color.Maroon;
            this.BackBtn.Location = new System.Drawing.Point(545, 326);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(202, 71);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.BackColor = System.Drawing.Color.Ivory;
            this.ProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductNameTextBox.Location = new System.Drawing.Point(274, 112);
            this.ProductNameTextBox.Multiline = true;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(296, 44);
            this.ProductNameTextBox.TabIndex = 15;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.BackColor = System.Drawing.Color.Ivory;
            this.ProductPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceTextBox.Location = new System.Drawing.Point(274, 169);
            this.ProductPriceTextBox.Multiline = true;
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(296, 40);
            this.ProductPriceTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(137, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 87);
            this.label1.TabIndex = 8;
            this.label1.Text = "Новий продукт";
            // 
            // AddingProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cost_Calculation_Program.Properties.Resources.addingProductFormBackground;
            this.ClientSize = new System.Drawing.Size(775, 419);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddNewProductBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddingProductForm";
            this.Text = "AddingProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddNewProductBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label label1;
    }
}