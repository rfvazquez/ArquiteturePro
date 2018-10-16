namespace ArchitecturePro.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBtnMenus = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstJanelas = new System.Windows.Forms.ListBox();
            this.pnlGoogleDrive = new System.Windows.Forms.Panel();
            this.lblGoogleDriveImage = new System.Windows.Forms.Label();
            this.lblGoogleDriveText = new System.Windows.Forms.Label();
            this.pnlMenuTop = new System.Windows.Forms.Panel();
            this.btnMsg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlGoogleDrive.SuspendLayout();
            this.pnlMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBtnMenus);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 570);
            this.panel1.TabIndex = 1;
            // 
            // pnlBtnMenus
            // 
            this.pnlBtnMenus.AutoScroll = true;
            this.pnlBtnMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtnMenus.Location = new System.Drawing.Point(0, 0);
            this.pnlBtnMenus.Name = "pnlBtnMenus";
            this.pnlBtnMenus.Size = new System.Drawing.Size(161, 402);
            this.pnlBtnMenus.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstJanelas);
            this.groupBox1.Controls.Add(this.pnlGoogleDrive);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Janelas Abertas";
            // 
            // lstJanelas
            // 
            this.lstJanelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstJanelas.FormattingEnabled = true;
            this.lstJanelas.Location = new System.Drawing.Point(3, 16);
            this.lstJanelas.Name = "lstJanelas";
            this.lstJanelas.ScrollAlwaysVisible = true;
            this.lstJanelas.Size = new System.Drawing.Size(155, 104);
            this.lstJanelas.TabIndex = 2;
            this.lstJanelas.DoubleClick += new System.EventHandler(this.lstJanelas_DoubleClick);
            // 
            // pnlGoogleDrive
            // 
            this.pnlGoogleDrive.Controls.Add(this.lblGoogleDriveImage);
            this.pnlGoogleDrive.Controls.Add(this.lblGoogleDriveText);
            this.pnlGoogleDrive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGoogleDrive.Location = new System.Drawing.Point(3, 120);
            this.pnlGoogleDrive.Name = "pnlGoogleDrive";
            this.pnlGoogleDrive.Size = new System.Drawing.Size(155, 45);
            this.pnlGoogleDrive.TabIndex = 1;
            // 
            // lblGoogleDriveImage
            // 
            this.lblGoogleDriveImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoogleDriveImage.Location = new System.Drawing.Point(0, 0);
            this.lblGoogleDriveImage.Name = "lblGoogleDriveImage";
            this.lblGoogleDriveImage.Size = new System.Drawing.Size(155, 32);
            this.lblGoogleDriveImage.TabIndex = 2;
            this.lblGoogleDriveImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoogleDriveText
            // 
            this.lblGoogleDriveText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGoogleDriveText.Location = new System.Drawing.Point(0, 32);
            this.lblGoogleDriveText.Name = "lblGoogleDriveText";
            this.lblGoogleDriveText.Size = new System.Drawing.Size(155, 13);
            this.lblGoogleDriveText.TabIndex = 1;
            this.lblGoogleDriveText.Text = "Google Drive";
            this.lblGoogleDriveText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenuTop
            // 
            this.pnlMenuTop.Controls.Add(this.btnMsg);
            this.pnlMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuTop.Location = new System.Drawing.Point(161, 0);
            this.pnlMenuTop.Name = "pnlMenuTop";
            this.pnlMenuTop.Size = new System.Drawing.Size(984, 51);
            this.pnlMenuTop.TabIndex = 3;
            // 
            // btnMsg
            // 
            this.btnMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsg.ForeColor = System.Drawing.Color.Red;
            this.btnMsg.Image = ((System.Drawing.Image)(resources.GetObject("btnMsg.Image")));
            this.btnMsg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMsg.Location = new System.Drawing.Point(939, 0);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(45, 51);
            this.btnMsg.TabIndex = 0;
            this.btnMsg.Text = "0";
            this.btnMsg.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 570);
            this.Controls.Add(this.pnlMenuTop);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlGoogleDrive.ResumeLayout(false);
            this.pnlMenuTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBtnMenus;
        private System.Windows.Forms.ListBox lstJanelas;
        private System.Windows.Forms.Panel pnlGoogleDrive;
        private System.Windows.Forms.Label lblGoogleDriveImage;
        private System.Windows.Forms.Label lblGoogleDriveText;
        private System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.Button btnMsg;
    }
}