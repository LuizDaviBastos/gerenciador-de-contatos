using GerenciadorContatos.DataBase;
using GerenciadorContatos.Models;
using GerenciadorContatos.Repositorio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GerenciadorContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {

        private ContatoContext _banco;
        public ContatoRepositorio(ContatoContext banco)
        {
            _banco = banco;
        }

        public void Adicionar(Contato contato)
        {
            _banco.Contatos.Add(contato);
            _banco.SaveChanges();
        }

        public void Atualizar(Contato contato)
        {
            _banco.Contatos.Update(contato);
            _banco.SaveChanges();
        }

        public IEnumerable<Contato> Buscar()
        {
            return _banco.Contatos.ToList();
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> expression)
        {
            return _banco.Contatos.Where(expression).ToList();
        }

        public void Excluir(int id)
        {
            var contato = Buscar(c => c.Id == id).FirstOrDefault();
            if (contato != null) _banco.Contatos.Remove(contato);
            _banco.SaveChanges();
        }
    }
}
