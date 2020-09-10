using Senai.MaisVagas.WebApi.Domains;
using Senai.MaisVagas.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MaisVagas.WebApi.Repositories
{
    public class CandidatoRepository : ICandidatoRepository
    {
        MaisVagasContext ctx = new MaisVagasContext();

        public void Atualizar(int Id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(Id);

            if (usuarioAtualizado.Nome != null)
            {
                usuarioBuscado.Nome = usuarioAtualizado.Nome;
            }

            ctx.Usuario.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public void RedefinirSenha(int Id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(Id);

            if (usuarioAtualizado.Senha != null)
            {
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }

            ctx.Usuario.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public void RedefinirEmail(int Id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(Id);

            if (usuarioAtualizado.Email != null)
            {
                usuarioBuscado.Email = usuarioAtualizado.Email;
            }

            ctx.Usuario.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public Candidato BuscarPorId(int id)
        {
            return ctx.Candidato.FirstOrDefault(p => p.IdCandidato == id);
        }

        public void Cadastrar(Candidato novoCandidato)
        {
            ctx.Candidato.Add(novoCandidato);

            ctx.SaveChanges();
        }

        public void Deletar(int Id)
        {
            Candidato candidatoBuscado = ctx.Candidato.Find(Id);

            ctx.Candidato.Remove(candidatoBuscado);

            ctx.SaveChanges();
        }

        public List<Candidato> Listar()
        {

            return ctx.Candidato.ToList();
        }
    }
}
