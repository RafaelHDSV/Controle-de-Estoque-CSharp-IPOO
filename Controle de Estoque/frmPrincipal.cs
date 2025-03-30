using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class frmPrincipal: Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro CadastroDeProduto = new frmCadastro();
            CadastroDeProduto.MdiParent = this;
            CadastroDeProduto.Show();
        }

        private void controleDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControle ControleDeProduto = new frmControle();
            ControleDeProduto.MdiParent = this;
            ControleDeProduto.Show();
        }

        private void consultaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta ConsultaDeProduto = new frmConsulta();
            ConsultaDeProduto.MdiParent = this;
            ConsultaDeProduto.Show();
        }
    }
}
