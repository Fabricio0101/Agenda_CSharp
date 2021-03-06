using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Conexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;

        public Conexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String stringConexao
        {
            get { return this._stringConexao; }
            set { this.stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }
    }
}
