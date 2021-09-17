using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorCinema_WebApi.Model.ModuleFilme;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GerenciadorCinema_WebApi.Controllers.ModuleControladorFilme
{
    [ApiController]
    [Route("api/filme")]
    public class ControladorFilme
    {
        [HttpGet]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }

        public string Inserir(Filme registro)
        {
            throw new NotImplementedException();
        }
        public string Editar(int id, Filme registro)
        {
            throw new NotImplementedException();
        }

        public bool Existe(int id)
        {
            throw new NotImplementedException();
        }
        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Filme> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public Filme SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
  