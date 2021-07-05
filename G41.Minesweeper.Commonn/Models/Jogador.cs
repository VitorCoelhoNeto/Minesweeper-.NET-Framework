using System;
using System.Collections.Generic;
using System.Text;

namespace G41.Minesweeper.Common.Models
{
    public class Jogador
    {
        public string nome { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string pais { get; set; }
        public string foto { get; set; }

        public Jogador(string _nome, string user, string pass, string _email, string _pais, string pic)
        {
            this.nome = _nome;
            this.username = user;
            this.password = pass;
            this.email = _email;
            this.pais = _pais;
            this.foto = pic;
        }
    }
}
