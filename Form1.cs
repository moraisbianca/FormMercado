using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//COISAS PARA RESOLVER: Botão remover linhas do dgv e botão de aumento em 10%

namespace ProjetoLoja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Definindo algumas funções da grid a mão
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLoja.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLoja.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";
            dgvLoja.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLoja.Columns[5].DefaultCellStyle.Format = "###,###,##0.00";
        }


        //Declarando variáveis
        double selecao;

        //Função para limpar campos
        private void LimparCampos()
        {
            txtboxCodigo.Clear();
            txtboxDescricao.Clear();
            txtboxCompra.Clear();
            txtboxRevenda.Clear();
            txtboxEstoque.Clear();
        }

        //Botão fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        //Botão que importa o arquivo de texto para dentro da grid
        private void btnImportar_Click(object sender, EventArgs e)
        {
            dgvLoja.RowCount = 0;

            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdArquivo.FileName);

            String linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                int ID = int.Parse(dados[0]);
                string EAN = dados[1];
                string produto = dados[2];
                double preco_compra = Convert.ToDouble(dados[3]);
                double preco_revenda = Convert.ToDouble(dados[4]);
                int estoque = int.Parse(dados[5]);

                dgvLoja.Rows.Add(false, ID, EAN, produto, preco_compra, preco_revenda, estoque);

                //Altera a cor da linha onde o valor de revenda é mais baixo que o valor da compra (SEM LUCRO)
                foreach (DataGridViewRow row in dgvLoja.Rows)
                    if (Convert.ToInt32(row.Cells[4].Value) >= Convert.ToInt32(row.Cells[5].Value))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
            }

        }


        //Botão que marca todas as caixas de seleção
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgvLoja.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[0].Value);
            }

            LimparCampos();
        }


        //Botão que desmarca todas as caixas de seleção
        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgvLoja.Rows)
                linha.Cells[0].Value = false;

            LimparCampos();
        }


        //Clique individual em uma caixa de seleção dentro da grid
        private void dgvLoja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Essa condição impede que dê erro no sistema caso o botão tente alterar linhas inexistentes
            if (dgvLoja.Rows.Count > 0)
            {
                txtboxCodigo.Text = dgvLoja.CurrentRow.Cells["EAN"].Value.ToString();
                txtboxDescricao.Text = dgvLoja.CurrentRow.Cells["produto"].Value.ToString();
                txtboxCompra.Text = dgvLoja.CurrentRow.Cells["preco_compra"].Value.ToString();
                txtboxRevenda.Text = dgvLoja.CurrentRow.Cells["preco_revenda"].Value.ToString();
                txtboxEstoque.Text = dgvLoja.CurrentRow.Cells["estoque"].Value.ToString();

            }

            if (dgvLoja.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgvLoja.CurrentRow.Cells[0].Value) == false)
                {
                    dgvLoja.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dgvLoja.CurrentRow.Cells[0].Value);
                }
                else
                {
                    dgvLoja.CurrentRow.Cells[0].Value = false;
                    selecao -= Convert.ToDouble(dgvLoja.CurrentRow.Cells[0].Value);
                }
            }
        }


        //Botão que altera as linhas da grid
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtboxCodigo.Text != "" && txtboxDescricao.Text != "" && txtboxCompra.Text != "" && txtboxRevenda.Text != "" && txtboxEstoque.Text != "")
            {
                //Caminho contrário da seleção da linha
                dgvLoja.CurrentRow.Cells["EAN"].Value = txtboxCodigo.Text;
                dgvLoja.CurrentRow.Cells["produto"].Value = txtboxDescricao.Text;
                dgvLoja.CurrentRow.Cells["preco_compra"].Value = txtboxCompra.Text;
                dgvLoja.CurrentRow.Cells["preco_revenda"].Value = txtboxRevenda.Text;
                dgvLoja.CurrentRow.Cells["estoque"].Value = txtboxEstoque.Text;
            }
        }

        //Aumento de 10% no valor de revenda
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            double NovoValor = 0;
            if (Convert.ToBoolean(dgvLoja.CurrentRow.Cells[0].Value) != false)
            {
                double ValorAumento = Convert.ToDouble(dgvLoja.CurrentRow.Cells["preco_revenda"].Value) * 0.1;
                NovoValor = Convert.ToDouble(dgvLoja.CurrentRow.Cells["preco_revenda"].Value) + ValorAumento;
                dgvLoja.CurrentRow.Cells["preco_revenda"].Value = NovoValor;
            }
        }


        //Botão que remove linhas da grid
        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            //Apagando a linha do dgv
            if (dgvLoja.Rows.Count > 0)
            {
                bool teste = Convert.ToBoolean(dgvLoja.CurrentRow.Cells[0].Value);

                if (teste != false)
                {
                    dgvLoja.Rows.RemoveAt(dgvLoja.CurrentCell.RowIndex);
                }

            }
        }
    }
}

