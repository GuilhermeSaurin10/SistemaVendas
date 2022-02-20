using Dominio.Interfaces;
using Dominio.Repositorio;
using SistemaVendas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Servicos
{
    public class ServicoVenda : IServicoVenda
    {
        IRepositorioVenda RepositorioVenda;

        public ServicoVenda(IRepositorioVenda repositorioVenda)
        {
            RepositorioVenda = repositorioVenda;
        }

        public void Cadastrar(Venda venda)
        {
            RepositorioVenda.Create(venda);
        }

        public Venda CarregarRegistro(int id)
        {
            return RepositorioVenda.Read(id);
        }

        public void Excluir(int id)
        {
            RepositorioVenda.Delete(id);
        }

        public IEnumerable<Venda> Listagem()
        {
            return RepositorioVenda.Read();
        }
    }
}
