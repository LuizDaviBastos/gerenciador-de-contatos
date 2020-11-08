using GerenciadorContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GerenciadorContatos.Repositorio.Contratos
{
    public interface IContatoRepositorio
    {
        void Adicionar(Contato contato);
        void Excluir(int id);
        void Atualizar(Contato contato);

        IEnumerable<Contato> Buscar();
        IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> expression);

    }
}
