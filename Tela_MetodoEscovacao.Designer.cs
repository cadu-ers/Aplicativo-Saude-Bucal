namespace App_Saúde_Bucal
{
    partial class Tela_MetodoEscovacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_MetodoEscovacao));
            this.btn_VoltarTopicos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_VoltarTopicos
            // 
            this.btn_VoltarTopicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_VoltarTopicos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_VoltarTopicos.BackgroundImage")));
            this.btn_VoltarTopicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_VoltarTopicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VoltarTopicos.Location = new System.Drawing.Point(12, 499);
            this.btn_VoltarTopicos.Name = "btn_VoltarTopicos";
            this.btn_VoltarTopicos.Size = new System.Drawing.Size(200, 100);
            this.btn_VoltarTopicos.TabIndex = 0;
            this.btn_VoltarTopicos.UseVisualStyleBackColor = true;
            this.btn_VoltarTopicos.Click += new System.EventHandler(this.btn_VoltarTopicos_Click);
            // 
            // Tela_MetodoEscovacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btn_VoltarTopicos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_MetodoEscovacao";
            this.Text = " App Saúde Bucal - Método De Escovação";
            this.Load += new System.EventHandler(this.Tela_MetodoEscovacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VoltarTopicos;
    }
}