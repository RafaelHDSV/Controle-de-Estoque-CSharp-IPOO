using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Controle_de_Estoque.frmPrincipal;

namespace Controle_de_Estoque
{
    public partial class frmPrincipal: Form
    {
        public class Produto
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public int quantity { get; set; }
            public string supplier { get; set; }
        }

        public static List<Produto> Produtos = new List<Produto>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public static void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro CadastroDeProduto = new frmCadastro();
            CadastroDeProduto.MdiParent = this;
            CadastroDeProduto.Show();
        }

        private void controleDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Produtos.Count < 1)
            {
                MessageBox.Show("Não existem produtos cadastrados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else
            {
                frmControle ControleDeProduto = new frmControle();
                ControleDeProduto.MdiParent = this;
                ControleDeProduto.Show();
            }
        }

        private void consultaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Produtos.Count < 1)
            {
                MessageBox.Show("Não existem produtos cadastrados!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmConsulta ConsultaDeProduto = new frmConsulta();
                ConsultaDeProduto.MdiParent = this;
                ConsultaDeProduto.Show();
            }
        }
    }
}
