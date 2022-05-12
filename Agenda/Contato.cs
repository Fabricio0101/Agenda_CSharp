using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public Contato()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Compromisso = "";
            this.Data = "";
        }
        public Contato(int codigo, string nome, string compromisso, string data)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Compromisso = compromisso;
            this.Data = data;
        }
        
        
        private int con_cod;
        public int Codigo
        {
            get 
            {
                return this.con_cod;
            }
            set
            {
                this.con_cod = value;
            }
        }
        
        private string con_nome;
        public string Nome
        {
            get { return this.con_nome; }
            set { this.con_nome = value; }
        }

        private string con_compromisso;
        public string Compromisso
        {
            get { return this.con_compromisso; }
            set { this.con_compromisso = value; }
        }

        private string con_data;
        public string Data
        {
            get { return this.con_data; }
            set { this.con_data = value; }
        }
    }
}
