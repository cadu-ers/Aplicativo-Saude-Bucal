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
    public partial class Tela_Prevencao : Form
    {
        Thread threadTelaTopicos;

        public Tela_Prevencao()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.DoubleBuffered = true;

        }

        private void Tela_Prevencao_Resize(object sender, EventArgs e)
        {
        }

        private void Tela_Prevencao_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Tela_Prevencao_Resize);
        }


        private void abrirTelaTopicos(object obj)
        {
            Application.Run(new Tela_Topicos());
        }

        private void btnVoltarPrevencao_Click(object sender, EventArgs e)
        {
            this.Close();
            threadTelaTopicos = new Thread(abrirTelaTopicos);
            threadTelaTopicos.SetApartmentState(ApartmentState.STA);
            threadTelaTopicos.Start();
        }
    }
}
