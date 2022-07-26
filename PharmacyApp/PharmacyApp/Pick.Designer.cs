
namespace PharmacyApp
{
    partial class Pick
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would you like to do?";
            // 
            // btnMedicine
            // 
            this.btnMedicine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMedicine.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicine.Location = new System.Drawing.Point(302, 85);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(230, 41);
            this.btnMedicine.TabIndex = 3;
            this.btnMedicine.Text = "Add new medicine";
            this.btnMedicine.UseVisualStyleBackColor = false;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStock.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(12, 85);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(205, 41);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "See Medicine Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            // 
            // btnExit1
            // 
            this.btnExit1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit1.Location = new System.Drawing.Point(471, 150);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(75, 31);
            this.btnExit1.TabIndex = 5;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = false;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // Pick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 181);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.label1);
            this.Name = "Pick";
            this.Text = "Pick";
            this.Load += new System.EventHandler(this.Pick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnExit1;
    }
}