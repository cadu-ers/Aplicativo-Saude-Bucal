namespace App_Saúde_Bucal
{
    partial class Tela_Prevencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Prevencao));
            this.btnVoltarPrevencao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarPrevencao
            // 
            this.btnVoltarPrevencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltarPrevencao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarPrevencao.BackgroundImage")));
            this.btnVoltarPrevencao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarPrevencao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarPrevencao.Location = new System.Drawing.Point(12, 499);
            this.btnVoltarPrevencao.Name = "btnVoltarPrevencao";
            this.btnVoltarPrevencao.Size = new System.Drawing.Size(200, 100);
            this.btnVoltarPrevencao.TabIndex = 0;
            this.btnVoltarPrevencao.UseVisualStyleBackColor = true;
            this.btnVoltarPrevencao.Click += new System.EventHandler(this.btnVoltarPrevencao_Click);
            // 
            // Tela_Prevencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btnVoltarPrevencao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Prevencao";
            this.Text = "App Saúde Bucal - Prevenção";
            this.Load += new System.EventHandler(this.Tela_Prevencao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarPrevencao;
    }
}