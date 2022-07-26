
namespace PharmacyApp
{
    partial class MainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDrugList = new System.Windows.Forms.Label();
            this.lblMedID = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblMedName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtBxQuantity = new System.Windows.Forms.TextBox();
            this.txtBxMedName = new System.Windows.Forms.TextBox();
            this.txtBxMedID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblDrugList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 48);
            this.panel1.TabIndex = 0;
            // 
            // lblDrugList
            // 
            this.lblDrugList.AutoSize = true;
            this.lblDrugList.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrugList.Location = new System.Drawing.Point(43, 9);
            this.lblDrugList.Name = "lblDrugList";
            this.lblDrugList.Size = new System.Drawing.Size(181, 28);
            this.lblDrugList.TabIndex = 1;
            this.lblDrugList.Text = "Add New Drug to Stock";
            // 
            // lblMedID
            // 
            this.lblMedID.AutoSize = true;
            this.lblMedID.Location = new System.Drawing.Point(5, 63);
            this.lblMedID.Name = "lblMedID";
            this.lblMedID.Size = new System.Drawing.Size(58, 13);
            this.lblMedID.TabIndex = 2;
            this.lblMedID.Text = "Medical ID";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(142, 117);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(61, 13);
            this.lblExpiryDate.TabIndex = 3;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblMedName
            // 
            this.lblMedName.AutoSize = true;
            this.lblMedName.Location = new System.Drawing.Point(142, 63);
            this.lblMedName.Name = "lblMedName";
            this.lblMedName.Size = new System.Drawing.Size(81, 13);
            this.lblMedName.TabIndex = 4;
            this.lblMedName.Text = "Medicine Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(5, 117);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtBxQuantity
            // 
            this.txtBxQuantity.Location = new System.Drawing.Point(5, 133);
            this.txtBxQuantity.Name = "txtBxQuantity";
            this.txtBxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBxQuantity.TabIndex = 8;
            // 
            // txtBxMedName
            // 
            this.txtBxMedName.Location = new System.Drawing.Point(145, 79);
            this.txtBxMedName.Name = "txtBxMedName";
            this.txtBxMedName.Size = new System.Drawing.Size(100, 20);
            this.txtBxMedName.TabIndex = 9;
            this.txtBxMedName.TextChanged += new System.EventHandler(this.txtBxMedName_TextChanged);
            // 
            // txtBxMedID
            // 
            this.txtBxMedID.Location = new System.Drawing.Point(5, 79);
            this.txtBxMedID.Name = "txtBxMedID";
            this.txtBxMedID.Size = new System.Drawing.Size(100, 20);
            this.txtBxMedID.TabIndex = 10;
            this.txtBxMedID.TextChanged += new System.EventHandler(this.txtBxMedID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(145, 171);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 213);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxMedID);
            this.Controls.Add(this.txtBxMedName);
            this.Controls.Add(this.txtBxQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblMedName);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblMedID);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "Pharmacological Management ";
          //  this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDrugList;
        private System.Windows.Forms.Label lblMedID;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblMedName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtBxQuantity;
        private System.Windows.Forms.TextBox txtBxMedName;
        private System.Windows.Forms.TextBox txtBxMedID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}