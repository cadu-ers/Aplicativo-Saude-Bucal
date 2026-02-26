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
    public partial class Tela_ComoSaberSeEstou : Form
    {

        Thread threadVoltarTela;
        public Tela_ComoSaberSeEstou()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.DoubleBuffered = true;

        }

        private void Tela_ComoSaberSeEstou_Resize(object sender, EventArgs e)
        {

        }

        private void Tela_ComoSaberSeEstou_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Tela_ComoSaberSeEstou_Resize);
        }

        private void abrirTelaTopico(object obj)
        {
            Application.Run(new Tela_Topicos());
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            threadVoltarTela = new Thread(abrirTelaTopico);
            threadVoltarTela.SetApartmentState(ApartmentState.STA);
            threadVoltarTela.Start();
        }
    }
}
