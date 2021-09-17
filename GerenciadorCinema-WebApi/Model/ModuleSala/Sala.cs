using GerenciadorCinema_WebApi.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCinema_WebApi.Model.ModuleSala
{
    public class Sala : EntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; }
        public int QtdAssentos { get; }

        public Sala(int id, string nome, int qtdAssentos)
        {
            Id = id;
            Nome = nome;
            QtdAssentos = qtdAssentos;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Sala);
        }

        public bool Equals(Sala obj)
        {
            return obj is Sala sala &&
                   Nome == sala.Nome &&
                   QtdAssentos == sala.QtdAssentos;
        }

        public override int GetHashCode()
        {
            int hashCode = -979129020;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + QtdAssentos.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
