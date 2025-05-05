namespace GymCustomersManagementApp
{
    partial class frmActivity
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboSpace = new System.Windows.Forms.ComboBox();
            this.cboHour = new System.Windows.Forms.ComboBox();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.lblParticipate = new System.Windows.Forms.Label();
            this.btnParticipate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(202, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(38, 73);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(35, 13);
            this.lblIDNumber.TabIndex = 1;
            this.lblIDNumber.Text = "label2";
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(41, 89);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(175, 20);
            this.txtProvider.TabIndex = 2;
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Location = new System.Drawing.Point(38, 133);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(35, 13);
            this.lblSpace.TabIndex = 3;
            this.lblSpace.Text = "label3";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(38, 192);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(35, 13);
            this.lblHour.TabIndex = 4;
            this.lblHour.Text = "label4";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(285, 73);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(35, 13);
            this.lblActivity.TabIndex = 5;
            this.lblActivity.Text = "label5";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(285, 133);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "label6";
            // 
            // cboSpace
            // 
            this.cboSpace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpace.FormattingEnabled = true;
            this.cboSpace.Location = new System.Drawing.Point(41, 150);
            this.cboSpace.Name = "cboSpace";
            this.cboSpace.Size = new System.Drawing.Size(175, 21);
            this.cboSpace.TabIndex = 7;
            // 
            // cboHour
            // 
            this.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHour.FormattingEnabled = true;
            this.cboHour.Location = new System.Drawing.Point(41, 208);
            this.cboHour.Name = "cboHour";
            this.cboHour.Size = new System.Drawing.Size(175, 21);
            this.cboHour.TabIndex = 8;
            // 
            // cboActivity
            // 
            this.cboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(288, 89);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(200, 21);
            this.cboActivity.TabIndex = 9;
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.Location = new System.Drawing.Point(288, 151);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(200, 20);
            this.dtpSchedule.TabIndex = 10;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(288, 205);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(199, 23);
            this.btnSchedule.TabIndex = 11;
            this.btnSchedule.Text = "button1";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // lblParticipate
            // 
            this.lblParticipate.AutoSize = true;
            this.lblParticipate.Location = new System.Drawing.Point(190, 267);
            this.lblParticipate.Name = "lblParticipate";
            this.lblParticipate.Size = new System.Drawing.Size(35, 13);
            this.lblParticipate.TabIndex = 12;
            this.lblParticipate.Text = "label1";
            // 
            // btnParticipate
            // 
            this.btnParticipate.Location = new System.Drawing.Point(411, 262);
            this.btnParticipate.Name = "btnParticipate";
            this.btnParticipate.Size = new System.Drawing.Size(75, 23);
            this.btnParticipate.TabIndex = 13;
            this.btnParticipate.UseVisualStyleBackColor = true;
            this.btnParticipate.Click += new System.EventHandler(this.btnParticipate_Click);
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.btnParticipate);
            this.Controls.Add(this.lblParticipate);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.cboActivity);
            this.Controls.Add(this.cboHour);
            this.Controls.Add(this.cboSpace);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblSpace);
            this.Controls.Add(this.txtProvider);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Up an Activity";
            this.Load += new System.EventHandler(this.frmActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboSpace;
        private System.Windows.Forms.ComboBox cboHour;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Label lblParticipate;
        private System.Windows.Forms.Button btnParticipate;
    }
}