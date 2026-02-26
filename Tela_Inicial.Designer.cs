namespace App_Saúde_Bucal
{
    partial class Tela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            this.txt_BemVindo = new System.Windows.Forms.Label();
            this.txt_AquiVoceAprendera = new System.Windows.Forms.Label();
            this.btn_Comecar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Sobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_BemVindo
            // 
            this.txt_BemVindo.AutoSize = true;
            this.txt_BemVindo.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BemVindo.Location = new System.Drawing.Point(272, 29);
            this.txt_BemVindo.Name = "txt_BemVindo";
            this.txt_BemVindo.Size = new System.Drawing.Size(0, 35);
            this.txt_BemVindo.TabIndex = 0;
            this.txt_BemVindo.Click += new System.EventHandler(this.txt_BemVindo_Click);
            // 
            // txt_AquiVoceAprendera
            // 
            this.txt_AquiVoceAprendera.AutoSize = true;
            this.txt_AquiVoceAprendera.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AquiVoceAprendera.Location = new System.Drawing.Point(93, 93);
            this.txt_AquiVoceAprendera.Name = "txt_AquiVoceAprendera";
            this.txt_AquiVoceAprendera.Size = new System.Drawing.Size(0, 35);
            this.txt_AquiVoceAprendera.TabIndex = 1;
            this.txt_AquiVoceAprendera.Click += new System.EventHandler(this.txt_AquiVoceAprendera_Click);
            // 
            // btn_Comecar
            // 
            this.btn_Comecar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Comecar.BackgroundImage")));
            this.btn_Comecar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Comecar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Comecar.Location = new System.Drawing.Point(190, 176);
            this.btn_Comecar.Name = "btn_Comecar";
            this.btn_Comecar.Size = new System.Drawing.Size(250, 100);
            this.btn_Comecar.TabIndex = 2;
            this.btn_Comecar.UseVisualStyleBackColor = true;
            this.btn_Comecar.Click += new System.EventHandler(this.btn_Comecar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Location = new System.Drawing.Point(190, 501);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(250, 100);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Sobre
            // 
            this.btn_Sobre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sobre.BackgroundImage")));
            this.btn_Sobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sobre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sobre.Location = new System.Drawing.Point(190, 333);
            this.btn_Sobre.Name = "btn_Sobre";
            this.btn_Sobre.Size = new System.Drawing.Size(250, 100);
            this.btn_Sobre.TabIndex = 4;
            this.btn_Sobre.UseVisualStyleBackColor = true;
            this.btn_Sobre.Click += new System.EventHandler(this.btn_Sobre_Click);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.btn_Sobre);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Comecar);
            this.Controls.Add(this.txt_AquiVoceAprendera);
            this.Controls.Add(this.txt_BemVindo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Inicial";
            this.Text = "App Saúde Bucal - Tela Inicial";
            this.Load += new System.EventHandler(this.Tela_Inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_BemVindo;
        private System.Windows.Forms.Label txt_AquiVoceAprendera;
        private System.Windows.Forms.Button btn_Comecar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Sobre;
    }
}

