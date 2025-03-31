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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string type = typeInput.Text;
            string quantity = quantityInput.Text;
            string supplier = supplierInput.Text;

            bool isAllFieldsFilled = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(quantity) || string.IsNullOrWhiteSpace(supplier);

            if (isAllFieldsFilled)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(quantity, out int parsedQuantity))
            {
                MessageBox.Show("Quantidade inválida! Digite um número inteiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmPrincipal.Produto newProdut = new frmPrincipal.Produto
            {
                id = frmPrincipal.Produtos.Count + 1,
                name = name,
                type = type,
                quantity = int.Parse(quantity),
                supplier = supplier
            };

            frmPrincipal.AdicionarProduto(newProdut);
            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nameInput.Clear();
            typeInput.Text = "";
            quantityInput.Clear();
            supplierInput.Clear();
        }
    }
}
