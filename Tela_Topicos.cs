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
    public partial class Tela_Topicos : Form
    {
        Thread threadTelaPrevencao;
        Thread threadMelhorEscova;
        Thread threadCremeDental;
        Thread threadUsoFioDental;
        Thread threadComoSaberSeEstou;
        Thread threadMetodoEscovacao;
        Thread threadCreditos;
        Thread threadVoltarTelaInicial;

        public Tela_Topicos()
        {
            InitializeComponent();

            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Resize += new EventHandler(Tela_Topicos_Resize);
            Tela_Topicos_Resize(null, null);

            this.DoubleBuffered = true;
        }

        private void Tela_Topicos_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int buttonWidth = formWidth / 6;
            int buttonHeight = formHeight / 6;
            int horizontalSpacing = formWidth / 10;
            int verticalSpacing = formHeight / 20;

            int startY = formHeight / 3;

            btn_Prevencao.Width = buttonWidth;
            btn_Prevencao.Height = buttonHeight;
            btn_Prevencao.Left = horizontalSpacing;
            btn_Prevencao.Top = startY;

            btn_MetodoDeEscovacao.Width = buttonWidth;
            btn_MetodoDeEscovacao.Height = buttonHeight;
            btn_MetodoDeEscovacao.Left = horizontalSpacing;
            btn_MetodoDeEscovacao.Top = btn_Prevencao.Bottom + verticalSpacing;

            btn_Creditos.Width = buttonWidth;
            btn_Creditos.Height = buttonHeight;
            btn_Creditos.Left = horizontalSpacing;
            btn_Creditos.Top = btn_MetodoDeEscovacao.Bottom + verticalSpacing;

            btn_MelhorEscova.Width = buttonWidth;
            btn_MelhorEscova.Height = buttonHeight;
            btn_MelhorEscova.Left = (formWidth - buttonWidth) / 2;
            btn_MelhorEscova.Top = startY;

            btn_ComoSaberSeEstou.Width = buttonWidth;
            btn_ComoSaberSeEstou.Height = buttonHeight;
            btn_ComoSaberSeEstou.Left = (formWidth - buttonWidth) / 2;
            btn_ComoSaberSeEstou.Top = btn_MelhorEscova.Bottom + verticalSpacing;

            btn_CremeDental.Width = buttonWidth;
            btn_CremeDental.Height = buttonHeight;
            btn_CremeDental.Left = formWidth - horizontalSpacing - buttonWidth;
            btn_CremeDental.Top = startY;

            btn_UsoDoFioDental.Width = buttonWidth;
            btn_UsoDoFioDental.Height = buttonHeight;
            btn_UsoDoFioDental.Left = formWidth - horizontalSpacing - buttonWidth;
            btn_UsoDoFioDental.Top = btn_CremeDental.Bottom + verticalSpacing;

            btn_VoltarAoMenu.Width = buttonWidth;
            btn_VoltarAoMenu.Height = buttonHeight;
            btn_VoltarAoMenu.Left = formWidth - horizontalSpacing - buttonWidth;
            btn_VoltarAoMenu.Top = btn_UsoDoFioDental.Bottom + verticalSpacing;
        }

        private void Tela_Topicos_Load(object sender, EventArgs e)
        {
        }


        private void txt_EscolhaUmDosTopicos_Click(object sender, EventArgs e)
        {

        }

        private void abrirTelaPrevencao(object obj)
        {
            Application.Run(new Tela_Prevencao());
        }

        private void btn_Prevencao_Click(object sender, EventArgs e)
        {
            this.Close();
            threadTelaPrevencao = new Thread(abrirTelaPrevencao);
            threadTelaPrevencao.SetApartmentState(ApartmentState.STA);
            threadTelaPrevencao.Start();
        }

        private void abrirTelaMelhorEscolha(object obj)
        {
            Application.Run(new Tela_MelhorEscova());
        }

        private void btn_MelhorEscova_Click(object sender, EventArgs e)
        {
            this.Close();
            threadMelhorEscova = new Thread(abrirTelaMelhorEscolha);
            threadMelhorEscova.SetApartmentState(ApartmentState.STA);
            threadMelhorEscova.Start();
        }

        private void abrirTelaCremeDental(object obj)
        {
            Application.Run(new Tela_CremeDental());
        }

        private void btn_CremeDental_Click(object sender, EventArgs e)
        {
            this.Close();
            threadCremeDental = new Thread(abrirTelaCremeDental);
            threadCremeDental.SetApartmentState(ApartmentState.STA);
            threadCremeDental.Start();
        }

        private void abrirTelaUsoFioDental(object obj)
        {
            Application.Run(new Tela_UsoFioDental());
        }

        private void btn_UsoDoFioDental_Click(object sender, EventArgs e)
        {
            this.Close();
            threadUsoFioDental = new Thread(abrirTelaUsoFioDental);
            threadUsoFioDental.SetApartmentState(ApartmentState.STA);
            threadUsoFioDental.Start();
        }

        private void abrirTelaComoSaberSeEstou(object obj)
        {
            Application.Run(new Tela_ComoSaberSeEstou());
        }

        private void btn_ComoSaberSeEstou_Click(object sender, EventArgs e)
        {
            this.Close();
            threadComoSaberSeEstou = new Thread(abrirTelaComoSaberSeEstou);
            threadComoSaberSeEstou.SetApartmentState(ApartmentState.STA);
            threadComoSaberSeEstou.Start();
        }

        private void abrirTelaMetodoEscovacao(object obj)
        {
            Application.Run(new Tela_MetodoEscovacao());
        }

        private void btn_MetodoDeEscovacao_Click(object sender, EventArgs e)
        {
            this.Close();
            threadMetodoEscovacao = new Thread(abrirTelaMetodoEscovacao);
            threadMetodoEscovacao.SetApartmentState(ApartmentState.STA);
            threadMetodoEscovacao.Start();
        }

        private void abrirTelaCreditos(object obj)
        {
            Application.Run(new Tela_Creditos());
        }

        private void btn_Creditos_Click(object sender, EventArgs e)
        {
            this.Close();
            threadCreditos = new Thread(abrirTelaCreditos);
            threadCreditos.SetApartmentState(ApartmentState.STA);
            threadCreditos.Start();
        }

        private void voltarTela_Inicial(object obj)
        {
            Application.Run(new Tela_Inicial());
        }

        private void btn_VoltarAoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            threadVoltarTelaInicial = new Thread(voltarTela_Inicial);
            threadVoltarTelaInicial.SetApartmentState(ApartmentState.STA);
            threadVoltarTelaInicial.Start();
        }
    }
}
