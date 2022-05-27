namespace FactoryDesignPattern
{
    partial class Form1
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblGetData = new System.Windows.Forms.Label();
            this.cmbGetDataLocation = new System.Windows.Forms.ComboBox();
            this.cmbGetDataOffice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(334, 59);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 0;
            this.btnGetData.Text = "Get Data ";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblGetData
            // 
            this.lblGetData.AutoSize = true;
            this.lblGetData.Location = new System.Drawing.Point(304, 107);
            this.lblGetData.Name = "lblGetData";
            this.lblGetData.Size = new System.Drawing.Size(135, 13);
            this.lblGetData.TabIndex = 1;
            this.lblGetData.Text = "Data will be displayed Here";
            // 
            // cmbGetDataLocation
            // 
            this.cmbGetDataLocation.FormattingEnabled = true;
            this.cmbGetDataLocation.Location = new System.Drawing.Point(224, 140);
            this.cmbGetDataLocation.Name = "cmbGetDataLocation";
            this.cmbGetDataLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbGetDataLocation.TabIndex = 2;
            this.cmbGetDataLocation.SelectedIndexChanged += new System.EventHandler(this.cmbGetDataLocation_SelectedIndexChanged);
            // 
            // cmbGetDataOffice
            // 
            this.cmbGetDataOffice.FormattingEnabled = true;
            this.cmbGetDataOffice.Location = new System.Drawing.Point(392, 140);
            this.cmbGetDataOffice.Name = "cmbGetDataOffice";
            this.cmbGetDataOffice.Size = new System.Drawing.Size(121, 21);
            this.cmbGetDataOffice.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbGetDataOffice);
            this.Controls.Add(this.cmbGetDataLocation);
            this.Controls.Add(this.lblGetData);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lblGetData;
        private System.Windows.Forms.ComboBox cmbGetDataLocation;
        private System.Windows.Forms.ComboBox cmbGetDataOffice;
    }
}

