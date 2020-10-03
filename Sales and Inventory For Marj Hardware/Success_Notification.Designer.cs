namespace Sales_and_Inventory_For_Marj_Hardware
{
    partial class Success_Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success_Notification));
            this.btnText = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnText.BackColor = System.Drawing.Color.SeaGreen;
            this.btnText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnText.BorderRadius = 0;
            this.btnText.ButtonText = "bunifuFlatButton1";
            this.btnText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnText.DisabledColor = System.Drawing.Color.Gray;
            this.btnText.Iconcolor = System.Drawing.Color.Transparent;
            this.btnText.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnText.Iconimage")));
            this.btnText.Iconimage_right = null;
            this.btnText.Iconimage_right_Selected = null;
            this.btnText.Iconimage_Selected = null;
            this.btnText.IconMarginLeft = 0;
            this.btnText.IconMarginRight = 0;
            this.btnText.IconRightVisible = true;
            this.btnText.IconRightZoom = 0D;
            this.btnText.IconVisible = true;
            this.btnText.IconZoom = 130D;
            this.btnText.IsTab = false;
            this.btnText.Location = new System.Drawing.Point(-2, 0);
            this.btnText.Name = "btnText";
            this.btnText.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnText.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnText.OnHoverTextColor = System.Drawing.Color.White;
            this.btnText.selected = false;
            this.btnText.Size = new System.Drawing.Size(432, 90);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "bunifuFlatButton1";
            this.btnText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnText.Textcolor = System.Drawing.Color.White;
            this.btnText.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Success_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 94);
            this.ControlBox = false;
            this.Controls.Add(this.btnText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Success_Notification";
            this.Text = "Success_Notification";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnText;
    }
}