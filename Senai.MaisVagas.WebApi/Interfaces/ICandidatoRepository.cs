using Senai.MaisVagas.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.MaisVagas.WebApi.Interfaces
{
    interface ICandidatoRepository
    {
        List<Candidato> Listar();
        void Atualizar(int Id, Usuario usuarioAtualizado);
        void Deletar(int Id);
        Candidato BuscarPorId(int Id);
        void Cadastrar(Candidato novoCandidato);
        void RedefinirEmail(int id, Usuario usuarioAtualizado);
        void RedefinirSenha(int id, Usuario usuarioAtualizado);
    }
}
