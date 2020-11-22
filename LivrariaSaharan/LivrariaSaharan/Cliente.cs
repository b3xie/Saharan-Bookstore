using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaSaharan
{
    class Cliente
    {
        private int Id; private String Nome; private String Fone; private String Email;private String CPF;private String UF;private String Cidade;private String Bairro;
        private String CEP;private String Endereco;private String Complemento;

        public int id { get { return Id; } set { this.Id = id; } }

        public String nome { get { return Nome; } set { this.Nome = nome; } }

        public String fone { get { return Fone; } set { this.Fone = fone; } }

        public String email { get { return Email; } set { this.Email = email; } }

        public String cpf { get { return CPF; } set { this.CPF = cpf; } }

        public String uf { get { return UF; } set { this.UF = uf; } }

        public String cidade { get { return Cidade; } set { this.Cidade = cidade; } }

        public String bairro { get { return Bairro; } set { this. Bairro = bairro; } }

        public String cep { get { return CEP; } set { this.CEP = cep; } }

        public String endereco { get { return Endereco; } set { this.Endereco = endereco; } }

        public String complemento { get { return Complemento; } set { this.Complemento = complemento; } }
    }
    class Funcionario
    {
        private int Id; private String Nome; private String Fone; private String Email; private String CPF; private String UF; private String Cidade; private String Bairro;
        private String CEP; private String Endereco; private String Complemento;
    }
}
