using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211065
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        double saldo_total = 0;

        private void btn_add_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txt_valor.Text);
            int qnt = int.Parse(txt_qnt.Text);
            double total_livro = valor * qnt;

            ListViewItem lstv = new ListViewItem(txt_nome.Text);
            lstv.SubItems.Add(txt_qnt.Text);
            lstv.SubItems.Add(txt_valor.Text);
            lstv.SubItems.Add(total_livro.ToString("C"));

            lstCarrinho.Items.Add(lstv);

            saldo_total += total_livro;
            txt_total.Text = saldo_total.ToString("C");

        }

        private void limpar()
        {
            txt_nome.Clear();
            txt_valor.Clear();
            txt_qnt.Clear();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            limpar();
            lstCarrinho.Items.Clear();
            saldo_total = 0;
            txt_total.Text = "R$ 00,00";
        }
    }

}