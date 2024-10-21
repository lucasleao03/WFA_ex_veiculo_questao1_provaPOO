using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFA_ex_veiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mtb_Placa.Mask = "aaa-0000";
            lvl_Dados.View = View.Details; //Exibe detalhes
            lvl_Dados.Columns.Add("Placa", 100, HorizontalAlignment.Left);
            lvl_Dados.Columns.Add("Ano", 50, HorizontalAlignment.Left);
            lvl_Dados.Columns.Add("Assentos", 100, HorizontalAlignment.Left);
            lvl_Dados.Columns.Add("Eixos", 50, HorizontalAlignment.Left);
            lvl_Dados.Columns.Add("Aluguel", 100, HorizontalAlignment.Left);
        }

        private void rb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            pbImagem.Image = Properties.Resources.onibus;

            lb_Quantidade.Text = "Qtd Assentos";
            //tb_assentos_ou_eixos.Visible = true;
        }

        private void rb_Caminhao_CheckedChanged(object sender, EventArgs e)
        {
            pbImagem.Image = Properties.Resources.caminhao;

            lb_Quantidade.Text = "Qtd Eixos";

           
            //tb_assentos_ou_eixos.Visible = false;
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            string[] dados = new string[5];
            if (rb_Onibus.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(mtb_Placa.Text) || string.IsNullOrWhiteSpace(tb_Ano.Text) 
                        || string.IsNullOrWhiteSpace(tb_assentos_ou_eixos.Text))
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    if (int.TryParse(tb_Ano.Text, out int ano) && int.TryParse(tb_assentos_ou_eixos.Text, out int assentos))
                    {
                        Onibus v = new Onibus(mtb_Placa.Text, int.Parse(tb_Ano.Text), int.Parse(tb_assentos_ou_eixos.Text));
                        double aluguel = v.Alugar();

                        string Text = "R$" + aluguel + ",00";

                        dados[0] = v.Placa;
                        dados[1] = Convert.ToString(v.Ano);
                        dados[2] = Convert.ToString(v.Assentos);
                        dados[3] = "";
                        dados[4] = Text;
                        lvl_Dados.Items.Add(new ListViewItem(dados));
                    }
                }
            }


            if (rb_Caminhao.Checked == true)
            {
                if(string.IsNullOrWhiteSpace(mtb_Placa.Text) || string.IsNullOrWhiteSpace(tb_Ano.Text) 
                    || string.IsNullOrWhiteSpace(tb_assentos_ou_eixos.Text))
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else 
                {
                    Caminhao k = new Caminhao(mtb_Placa.Text, int.Parse(tb_Ano.Text), int.Parse(tb_assentos_ou_eixos.Text));
                    double aluguel = k.Alugar();

                    string Text = "R$" + aluguel + ",00";

                    dados[0] = k.Placa;
                    dados[1] = Convert.ToString(k.Ano);
                    dados[2] = "";
                    dados[3] = Convert.ToString(k.Eixos);
                    dados[4] = Text;
                    lvl_Dados.Items.Add(new ListViewItem(dados));
                }
            }
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            mtb_Placa.Text = "";
            tb_Ano.Text = "";
            tb_assentos_ou_eixos.Text = "";
            tb_assentos_ou_eixos.Text = "";
        }
    }
}
