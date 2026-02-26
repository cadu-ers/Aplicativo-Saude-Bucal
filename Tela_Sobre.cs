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
    public partial class Tela_Sobre : Form
    {

        Thread threadVoltar;
        public Tela_Sobre()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.DoubleBuffered = true;
        }

        private void Tela_Sobre_Resize(object sender, EventArgs e)
        {

        }

        private void Tela_Sobre_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Tela_Sobre_Resize);

        }

        private void abrirTelaTopicos(object obj)
        {
            Application.Run(new Tela_Inicial());
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            threadVoltar = new Thread(abrirTelaTopicos);
            threadVoltar.SetApartmentState(ApartmentState.STA);
            threadVoltar.Start();
        }
    }
}
