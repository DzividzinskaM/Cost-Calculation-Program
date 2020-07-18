namespace Cost_Calculation_Program
{
    partial class MainForm
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
            this.StorageBtn = new System.Windows.Forms.Button();
            this.RecipeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StorageBtn
            // 
            this.StorageBtn.BackColor = System.Drawing.Color.LightCoral;
            this.StorageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StorageBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.StorageBtn.FlatAppearance.BorderSize = 4;
            this.StorageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StorageBtn.Font = new System.Drawing.Font("Sitka Subheading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageBtn.ForeColor = System.Drawing.Color.White;
            this.StorageBtn.Location = new System.Drawing.Point(54, 169);
            this.StorageBtn.Name = "StorageBtn";
            this.StorageBtn.Size = new System.Drawing.Size(153, 70);
            this.StorageBtn.TabIndex = 0;
            this.StorageBtn.Text = "Склад";
            this.StorageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StorageBtn.UseVisualStyleBackColor = false;
            this.StorageBtn.Click += new System.EventHandler(this.StorageBtn_Click);
            // 
            // RecipeBtn
            // 
            this.RecipeBtn.BackColor = System.Drawing.Color.LightCoral;
            this.RecipeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecipeBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.RecipeBtn.FlatAppearance.BorderSize = 4;
            this.RecipeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecipeBtn.Font = new System.Drawing.Font("Sitka Subheading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeBtn.ForeColor = System.Drawing.Color.White;
            this.RecipeBtn.Location = new System.Drawing.Point(501, 169);
            this.RecipeBtn.Name = "RecipeBtn";
            this.RecipeBtn.Size = new System.Drawing.Size(181, 70);
            this.RecipeBtn.TabIndex = 1;
            this.RecipeBtn.Text = "Рецепти";
            this.RecipeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RecipeBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.LightCoral;
            this.CloseBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Sitka Subheading", 20F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(677, -2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(46, 51);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "X";
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cost_Calculation_Program.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 286);
            this.ControlBox = false;
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RecipeBtn);
            this.Controls.Add(this.StorageBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StorageBtn;
        private System.Windows.Forms.Button RecipeBtn;
        private System.Windows.Forms.Label CloseBtn;
    }
}