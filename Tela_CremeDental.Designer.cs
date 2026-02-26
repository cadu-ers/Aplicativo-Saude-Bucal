namespace App_Saúde_Bucal
{
    partial class Tela_CremeDental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_CremeDental));
            this.btnVoltarTopicos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarTopicos
            // 
            this.btnVoltarTopicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarTopicos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarTopicos.BackgroundImage")));
            this.btnVoltarTopicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarTopicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarTopicos.Location = new System.Drawing.Point(12, 499);
            this.btnVoltarTopicos.Name = "btnVoltarTopicos";
            this.btnVoltarTopicos.Size = new System.Drawing.Size(200, 100);
            this.btnVoltarTopicos.TabIndex = 0;
            this.btnVoltarTopicos.UseVisualStyleBackColor = true;
            this.btnVoltarTopicos.Click += new System.EventHandler(this.btnVoltarTopicos_Click);
            // 
            // Tela_CremeDental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btnVoltarTopicos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_CremeDental";
            this.Text = "App Saúde Bucal - Creme Dental";
            this.Load += new System.EventHandler(this.Tela_CremeDental_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarTopicos;
    }
}