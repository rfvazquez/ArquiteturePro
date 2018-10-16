namespace ArchitecturePro.Componentes
{
    partial class BotaoMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotaoMenu));
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(144, 90);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Texto";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // BotaoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMenu);
            this.Name = "BotaoMenu";
            this.Size = new System.Drawing.Size(144, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
    }
}
