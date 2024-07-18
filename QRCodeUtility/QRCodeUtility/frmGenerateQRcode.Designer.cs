namespace QRCodeUtility
{
    partial class frmGenerateQRcode
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.pbQrCode = new System.Windows.Forms.PictureBox();
            this.panelLink = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).BeginInit();
            this.panelLink.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(72, 48);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 40);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(72, 8);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(608, 27);
            this.txtLink.TabIndex = 1;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(16, 8);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(37, 20);
            this.lblLink.TabIndex = 2;
            this.lblLink.Text = "Link";
            // 
            // pbQrCode
            // 
            this.pbQrCode.BackColor = System.Drawing.Color.DimGray;
            this.pbQrCode.Location = new System.Drawing.Point(8, 8);
            this.pbQrCode.Name = "pbQrCode";
            this.pbQrCode.Size = new System.Drawing.Size(672, 424);
            this.pbQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbQrCode.TabIndex = 3;
            this.pbQrCode.TabStop = false;
            // 
            // panelLink
            // 
            this.panelLink.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLink.Controls.Add(this.btnClear);
            this.panelLink.Controls.Add(this.txtLink);
            this.panelLink.Controls.Add(this.btnGenerate);
            this.panelLink.Controls.Add(this.lblLink);
            this.panelLink.Location = new System.Drawing.Point(24, 16);
            this.panelLink.Name = "panelLink";
            this.panelLink.Size = new System.Drawing.Size(688, 100);
            this.panelLink.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.pbQrCode);
            this.panel2.Location = new System.Drawing.Point(24, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 440);
            this.panel2.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.GhostWhite;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(200, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmGenerateQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(727, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLink);
            this.Name = "frmGenerateQRcode";
            this.Text = "QR Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).EndInit();
            this.panelLink.ResumeLayout(false);
            this.panelLink.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.PictureBox pbQrCode;
        private System.Windows.Forms.Panel panelLink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
    }
}

