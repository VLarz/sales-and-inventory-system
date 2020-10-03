namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class Send_To_Gmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_To_Gmail));
            this.btnOrderNow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtToEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSubject = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAttachment = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblEmailValidation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.ActiveBorderThickness = 1;
            this.btnOrderNow.ActiveCornerRadius = 10;
            this.btnOrderNow.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.ActiveForecolor = System.Drawing.Color.White;
            this.btnOrderNow.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.BackColor = System.Drawing.Color.White;
            this.btnOrderNow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrderNow.BackgroundImage")));
            this.btnOrderNow.ButtonText = "Send";
            this.btnOrderNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderNow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.btnOrderNow.IdleBorderThickness = 1;
            this.btnOrderNow.IdleCornerRadius = 10;
            this.btnOrderNow.IdleFillColor = System.Drawing.Color.White;
            this.btnOrderNow.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.btnOrderNow.Location = new System.Drawing.Point(12, 382);
            this.btnOrderNow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(405, 47);
            this.btnOrderNow.TabIndex = 4;
            this.btnOrderNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // txtToEmail
            // 
            this.txtToEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtToEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtToEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtToEmail.BorderThickness = 2;
            this.txtToEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtToEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtToEmail.isPassword = false;
            this.txtToEmail.Location = new System.Drawing.Point(124, 87);
            this.txtToEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(255, 30);
            this.txtToEmail.TabIndex = 0;
            this.txtToEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtToEmail.Leave += new System.EventHandler(this.txtToEmail_Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 96);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(27, 21);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "To";
            // 
            // txtSubject
            // 
            this.txtSubject.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtSubject.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtSubject.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtSubject.BorderThickness = 2;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtSubject.isPassword = false;
            this.txtSubject.Location = new System.Drawing.Point(124, 139);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(255, 30);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 148);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Subject";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(26, 194);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(48, 21);
            this.bunifuCustomLabel5.TabIndex = 23;
            this.bunifuCustomLabel5.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtBody.Location = new System.Drawing.Point(124, 194);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(255, 102);
            this.txtBody.TabIndex = 2;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(18, 319);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(100, 21);
            this.bunifuCustomLabel6.TabIndex = 26;
            this.bunifuCustomLabel6.Text = "Attachment:";
            // 
            // txtAttachment
            // 
            this.txtAttachment.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtAttachment.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.txtAttachment.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(213)))), ((int)(((byte)(165)))));
            this.txtAttachment.BorderThickness = 2;
            this.txtAttachment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttachment.Enabled = false;
            this.txtAttachment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAttachment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.txtAttachment.isPassword = false;
            this.txtAttachment.Location = new System.Drawing.Point(124, 310);
            this.txtAttachment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(177, 30);
            this.txtAttachment.TabIndex = 27;
            this.txtAttachment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnBrowse
            // 
            this.btnBrowse.ActiveBorderThickness = 1;
            this.btnBrowse.ActiveCornerRadius = 1;
            this.btnBrowse.ActiveFillColor = System.Drawing.Color.White;
            this.btnBrowse.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnBrowse.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.ButtonText = "Browse";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnBrowse.IdleBorderThickness = 1;
            this.btnBrowse.IdleCornerRadius = 1;
            this.btnBrowse.IdleFillColor = System.Drawing.Color.White;
            this.btnBrowse.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnBrowse.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(26)))));
            this.btnBrowse.Location = new System.Drawing.Point(305, 306);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 38);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblEmailValidation
            // 
            this.lblEmailValidation.AutoSize = true;
            this.lblEmailValidation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmailValidation.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidation.Location = new System.Drawing.Point(121, 117);
            this.lblEmailValidation.Name = "lblEmailValidation";
            this.lblEmailValidation.Size = new System.Drawing.Size(0, 15);
            this.lblEmailValidation.TabIndex = 31;
            // 
            // Send_To_Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 432);
            this.Controls.Add(this.lblEmailValidation);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtToEmail);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnOrderNow);
            this.MaximizeBox = false;
            this.Name = "Send_To_Gmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send PDF to Gmail";
            this.Load += new System.EventHandler(this.Send_To_Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnOrderNow;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtToEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSubject;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox txtBody;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAttachment;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmailValidation;
    }
}