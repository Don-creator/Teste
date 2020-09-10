using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.MaisVagas.WebApi.Domains;
using Senai.MaisVagas.WebApi.Interfaces;
using Senai.MaisVagas.WebApi.Repositories;

namespace Senai.MaisVagas.WebApi.Controllers
{
    public class CandidatoController : ControllerBase
    {
        private ICandidatoRepository _candidatoRepository;

        public CandidatoController()
        {
            _candidatoRepository = new CandidatoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_candidatoRepository.Listar());
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Candidato novoCandidato)
        {
            _candidatoRepository.Cadastrar(novoCandidato);

            return StatusCode(201);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Candidato candidatoAtualizado)
        {
            _candidatoRepository.Atualizar(id, candidatoAtualizado);

            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _candidatoRepository.Deletar(id);

            return StatusCode(204);


        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_candidatoRepository.BuscarPorId(id));
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            _candidatoRepository.RedefinirEmail(id, usuarioAtualizado);
            _candidatoRepository.RedefinirSenha(id, usuarioAtualizado);

            return StatusCode(204);
        }
    }
}