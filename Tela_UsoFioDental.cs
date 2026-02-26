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
    public partial class Tela_UsoFioDental : Form
    {

        Thread threadVoltarTela;
        public Tela_UsoFioDental()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.DoubleBuffered = true;

        }

        private void Tela_UsoFioDental_Resize(object sender, EventArgs e)
        {

        }

        private void Tela_UsoFioDental_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Tela_UsoFioDental_Resize);
        }

        private void CentralizarControles()
        {
            btn_Voltar.Location = new Point(90, 800);
        }

        private void abrirTelaTopicos(object obj)
        {
            Application.Run(new Tela_Topicos());
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            threadVoltarTela = new Thread(abrirTelaTopicos);
            threadVoltarTela.SetApartmentState(ApartmentState.STA);
            threadVoltarTela.Start();
        }
    }
}
