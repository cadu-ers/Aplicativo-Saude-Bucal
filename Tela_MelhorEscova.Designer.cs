namespace App_Saúde_Bucal
{
    partial class Tela_MelhorEscova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_MelhorEscova));
            this.btnVoltarMelhorEscova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarMelhorEscova
            // 
            this.btnVoltarMelhorEscova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarMelhorEscova.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarMelhorEscova.BackgroundImage")));
            this.btnVoltarMelhorEscova.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarMelhorEscova.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarMelhorEscova.Location = new System.Drawing.Point(12, 499);
            this.btnVoltarMelhorEscova.Name = "btnVoltarMelhorEscova";
            this.btnVoltarMelhorEscova.Size = new System.Drawing.Size(200, 100);
            this.btnVoltarMelhorEscova.TabIndex = 0;
            this.btnVoltarMelhorEscova.UseVisualStyleBackColor = true;
            this.btnVoltarMelhorEscova.Click += new System.EventHandler(this.btnVoltarMelhorEscova_Click);
            // 
            // Tela_MelhorEscova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btnVoltarMelhorEscova);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_MelhorEscova";
            this.Text = "App Saúde Bucal - Melhor Escova Dental";
            this.Load += new System.EventHandler(this.Tela_MelhorEscova_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarMelhorEscova;
    }
}