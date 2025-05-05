namespace GymCustomersManagementApp
{
    partial class frmEnrollment
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.cboSpace = new System.Windows.Forms.ComboBox();
            this.cboHour = new System.Windows.Forms.ComboBox();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(47, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "label1";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(47, 111);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(35, 13);
            this.lblActivity.TabIndex = 1;
            this.lblActivity.Text = "label2";
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Location = new System.Drawing.Point(47, 291);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(35, 13);
            this.lblSpace.TabIndex = 2;
            this.lblSpace.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(47, 171);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label4";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(50, 72);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(174, 20);
            this.txtDNI.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(79, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "label5";
            // 
            // cboActivity
            // 
            this.cboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(50, 127);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(174, 21);
            this.cboActivity.TabIndex = 6;
            this.cboActivity.SelectedIndexChanged += new System.EventHandler(this.cboActivity_SelectedIndexChanged);
            // 
            // cboSpace
            // 
            this.cboSpace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpace.FormattingEnabled = true;
            this.cboSpace.Location = new System.Drawing.Point(50, 307);
            this.cboSpace.Name = "cboSpace";
            this.cboSpace.Size = new System.Drawing.Size(174, 21);
            this.cboSpace.TabIndex = 7;
            // 
            // cboHour
            // 
            this.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHour.FormattingEnabled = true;
            this.cboHour.Location = new System.Drawing.Point(50, 248);
            this.cboHour.Name = "cboHour";
            this.cboHour.Size = new System.Drawing.Size(174, 21);
            this.cboHour.TabIndex = 8;
            this.cboHour.SelectedIndexChanged += new System.EventHandler(this.cboHour_SelectedIndexChanged);
            // 
            // cboDate
            // 
            this.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Location = new System.Drawing.Point(50, 187);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(174, 21);
            this.cboDate.TabIndex = 9;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(149, 354);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(75, 23);
            this.btnEnroll.TabIndex = 10;
            this.btnEnroll.Text = "button1";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(47, 232);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(35, 13);
            this.lblHour.TabIndex = 11;
            this.lblHour.Text = "label1";
            // 
            // frmEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 394);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.cboHour);
            this.Controls.Add(this.cboSpace);
            this.Controls.Add(this.cboActivity);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSpace);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblID);
            this.Name = "frmEnrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment In An Activity";
            this.Load += new System.EventHandler(this.frmEnrollment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.ComboBox cboSpace;
        private System.Windows.Forms.ComboBox cboHour;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Label lblHour;
    }
}