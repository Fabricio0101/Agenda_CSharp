using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmCadastroContato : Form
    {
        public string operacao = "";
        public frmCadastroContato()
        {
            InitializeComponent();
        }
        public void AlterarBotoes(int op)
        {
            pDados.Enabled = false;
            btInserir.Enabled = false;
            btLocalizar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;

        if (op == 1)
            {
                btInserir.Enabled = true;
            }
        if (op == 2)
            {
                pDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
        if (op == 3)
            {
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }

        }
        public void LimpaContatos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCompromisso.Clear();
            txtData.Clear();
        }
        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.AlterarBotoes(1);
            this.LimpaContatos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Compromisso = txtCompromisso.Text;
            contato.Data = txtData.Text;
            if(this.operacao == "inserir")
            {
                string strConexao = "Data Source=FabricioPC\SQLEXPRESS;Initial Catalog=Agenda;User ID=sa;Password=***********";
                Conexao conexao = new Conexao(strConexao);
                try
                {
                    conexao.Conectar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                contato.Codigo = Convert.ToInt32(txtCodigo.Text);

            }
        }
    }
}
