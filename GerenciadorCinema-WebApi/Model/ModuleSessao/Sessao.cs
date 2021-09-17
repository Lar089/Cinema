using GerenciadorCinema_WebApi.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCinema_WebApi.Model.ModuleSessao
{
    public class Sessao : EntidadeBase
    {
        public int Id { get; set; }
        public DateTime Data { get; }
        public TimeSpan HorarioInicial { get; }
        public TimeSpan HorarioFInal { get; }
        public decimal ValorIngresso { get; }
        public string TipoAnimacao { get; }
        public string TipoAudio { get; }
        public int FilmeId { get; }
        public int SalaId { get; }

        public Sessao(int id, DateTime data, TimeSpan horarioInicial, TimeSpan horarioFInal, decimal valorIngresso,
            string tipoAnimacao, string tipoAudio, int filmeId, int salaId)
        {
            Id = id;
            Data = data;
            HorarioInicial = horarioInicial;
            HorarioFInal = horarioFInal;
            ValorIngresso = valorIngresso;
            TipoAnimacao = tipoAnimacao;
            TipoAudio = tipoAudio;
            FilmeId = filmeId;
            SalaId = salaId;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Sessao);
        }

        public bool Equals(Sessao obj)
        {
            return obj is Sessao sessao &&
                   Id == sessao.Id &&
                   Data == sessao.Data &&
                   HorarioInicial.Equals(sessao.HorarioInicial) &&
                   HorarioFInal.Equals(sessao.HorarioFInal) &&
                   ValorIngresso == sessao.ValorIngresso &&
                   TipoAnimacao == sessao.TipoAnimacao &&
                   TipoAudio == sessao.TipoAudio &&
                   FilmeId == sessao.FilmeId &&
                   SalaId == sessao.SalaId;
        }

        public override int GetHashCode()
        {
            int hashCode = 1934698402;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Data.GetHashCode();
            hashCode = hashCode * -1521134295 + HorarioInicial.GetHashCode();
            hashCode = hashCode * -1521134295 + HorarioFInal.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorIngresso.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoAnimacao);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoAudio);
            hashCode = hashCode * -1521134295 + FilmeId.GetHashCode();
            hashCode = hashCode * -1521134295 + SalaId.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            if (ValorIngresso <= 0)
                return "Valor do ingresso inválido";

            return "ESTA_VALIDO";
        }
    }
}
