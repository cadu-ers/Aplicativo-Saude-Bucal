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
    public partial class Tela_Creditos : Form
    {

        Thread threadVoltar;
        public Tela_Creditos()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.DoubleBuffered = true;

        }

        private void Tela_Creditos_Resize(object sender, EventArgs e)
        {

        }

        private void Tela_Creditos_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Tela_Creditos_Resize);
        }


        private void abrirTelaTopico(object obj)
        {
            Application.Run(new Tela_Topicos());
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            threadVoltar = new Thread(abrirTelaTopico);
            threadVoltar.SetApartmentState(ApartmentState.STA);
            threadVoltar.Start();
        }
    }
}
