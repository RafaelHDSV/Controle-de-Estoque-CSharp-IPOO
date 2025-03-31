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
    public partial class frmControle : Form
    {
        public frmControle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string idEntry = idEntryInput.Text;
            string nameEntry = nameEntryInput.Text;
            string quantityEntry = quantityEntryInput.Text;

            var produto = frmPrincipal.Produtos.FirstOrDefault(p =>
                (int.TryParse(idEntry, out int parsedId) && p.id == parsedId) ||
                string.Equals(p.name, nameEntry, StringComparison.OrdinalIgnoreCase));

            if (!int.TryParse(quantityEntry, out int parsedQuantity))
            {
                MessageBox.Show("Quantidade inválida! Digite um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (produto != null)
            {
                produto.quantity += int.Parse(quantityEntry);

                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O produto não foi cadastrado ou está sem estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string idExit = idExitInput.Text;
            string nameExit = nameExitInput.Text;
            string quantityExit = quantityExitInput.Text;

            var produto = frmPrincipal.Produtos.FirstOrDefault(p =>
                (int.TryParse(idExit, out int parsedId) && p.id == parsedId) ||
                string.Equals(p.name, nameExit, StringComparison.OrdinalIgnoreCase));

            if (!int.TryParse(quantityExit, out int parsedQuantity))
            {
                MessageBox.Show("Quantidade inválida! Digite um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (produto != null && produto.quantity > 0)
            {
                produto.quantity -= int.Parse(quantityExit);

                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("O produto não foi cadastrado ou está sem estoque!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
