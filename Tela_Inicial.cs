using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace App_Saúde_Bucal
{
    public partial class Tela_Inicial : Form
    {
        Thread threadTelaTopicos;
        Thread threadTelaSobre;

        public Tela_Inicial()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.MaximizeBox = false;

            this.Resize += new EventHandler(Tela_Inicial_Resize);
            Tela_Inicial_Resize(null, null);

            this.DoubleBuffered = true;
        }

        private void Tela_Inicial_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int buttonSpacing = 20;
            int offsetY = 120;

            int totalHeight = btn_Comecar.Height + btn_Sobre.Height + btn_Sair.Height + (2 * buttonSpacing);

            int startY = ((formHeight - totalHeight) / 2) + offsetY;

            btn_Comecar.Left = (formWidth - btn_Comecar.Width) / 2;
            btn_Comecar.Top = startY;

            btn_Sobre.Left = (formWidth - btn_Sobre.Width) / 2;
            btn_Sobre.Top = btn_Comecar.Bottom + buttonSpacing;

            btn_Sair.Left = (formWidth - btn_Sair.Width) / 2;
            btn_Sair.Top = btn_Sobre.Bottom + buttonSpacing;
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void txt_BemVindo_Click(object sender, EventArgs e)
        {

        }

        private void txt_AquiVoceAprendera_Click(object sender, EventArgs e)
        {

        }

        private void abrirTela_Topicos(object obj)
        {
            Application.Run(new Tela_Topicos());
        }

        private void btn_Comecar_Click(object sender, EventArgs e)
        {
            this.Close();
            threadTelaTopicos = new Thread(abrirTela_Topicos);
            threadTelaTopicos.SetApartmentState(ApartmentState.STA);
            threadTelaTopicos.Start();
        }

        private void abrirTela_Sobre(object obj)
        {
            Application.Run(new Tela_Sobre());
        }

        private void btn_Sobre_Click(object sender, EventArgs e)
        {
            this.Close();
            threadTelaSobre = new Thread(abrirTela_Sobre);
            threadTelaSobre.SetApartmentState(ApartmentState.STA);
            threadTelaSobre.Start();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
