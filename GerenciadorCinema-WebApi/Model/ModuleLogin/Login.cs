using GerenciadorCinema_WebApi.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCinema_WebApi.Model.ModuleLogin
{
    public class Login : EntidadeBase
    {
        public int Id { get; set; }
        public string Email { get; }
        public string Senha { get; }

        public Login(int id,string email, string senha)
        {
            Id = id;
            Email = email;
            Senha = senha;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Login);
        }

        public bool Equals(Login obj)
        {
            return obj is Login login &&
                   Id == login.Id &&
                   Email == login.Email &&
                   Senha == login.Senha;
        }

        public override int GetHashCode()
        {
            int hashCode = -1397370338;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Senha);
            return hashCode;
        }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
