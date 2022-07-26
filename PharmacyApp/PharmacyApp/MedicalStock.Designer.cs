
namespace PharmacyApp
{
    partial class MedicalStock
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
            this.tableMedicine = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMedicine
            // 
            this.tableMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMedicine.Location = new System.Drawing.Point(0, 0);
            this.tableMedicine.Name = "tableMedicine";
            this.tableMedicine.Size = new System.Drawing.Size(240, 150);
            this.tableMedicine.TabIndex = 0;
            this.tableMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMedicine_CellContentClick);
            // 
            // MedicalStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 314);
            this.Controls.Add(this.tableMedicine);
            this.Name = "MedicalStock";
            this.Text = "MedicalStock";
            this.Load += new System.EventHandler(this.MedicalStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView tableMedicine;
    }
}