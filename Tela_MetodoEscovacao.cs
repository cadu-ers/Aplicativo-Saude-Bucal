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
    public partial class Tela_MetodoEscovacao : Form
    {
        Thread threadVoltarTopicos;
        public Tela_MetodoEscovacao()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.DoubleBuffered = true;

        }

        private void Tela_MetodoEscovacao_Resize(object sender, EventArgs e)
        {
        }

        private void Tela_MetodoEscovacao_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Tela_MetodoEscovacao_Resize);
        }

        private void abrirTelaTopicos(object obj)
        {
            Application.Run(new Tela_Topicos());
        }

        private void btn_VoltarTopicos_Click(object sender, EventArgs e)
        {
            this.Close();
            threadVoltarTopicos = new Thread(abrirTelaTopicos);
            threadVoltarTopicos.SetApartmentState(ApartmentState.STA);
            threadVoltarTopicos.Start();
        }
    }
}
