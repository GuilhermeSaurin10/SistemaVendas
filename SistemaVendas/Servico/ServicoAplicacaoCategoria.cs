using Aplicacao.Servico.Intefaces;
using Dominio.Interfaces;
using SistemaVendas.Dominio.Entidades;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoCategoria : IServicoAplicacaoCategoria
    {
        private readonly IServicoCategoria ServicoCategoria;
        public ServicoAplicacaoCategoria(IServicoCategoria servicoCategoria)
        {
            ServicoCategoria = servicoCategoria;
        }

        public void Cadastrar(CategoriaViewModel categoria)
        {
            Categoria item = new Categoria()
            {
                Codigo = categoria.Codigo,
                Descricao = categoria.Descricao
            };

            ServicoCategoria.Cadastrar(item);
        }

        public CategoriaViewModel CarregarRegistro(int codigoCategoria)
        {

            var registro = ServicoCategoria.CarregarRegistro(codigoCategoria);

            CategoriaViewModel categoria = new CategoriaViewModel()
            {
                Codigo = registro.Codigo,
                Descricao = registro.Descricao
            };

            return categoria;
        }

        public void Excluir(int id)
        {
            ServicoCategoria.Excluir(id);
        }

        public IEnumerable<CategoriaViewModel> Listagem()
        {
            var lista = ServicoCategoria.Listagem();
            List<CategoriaViewModel> ListaCategoria = new List<CategoriaViewModel>();

            foreach (var item in lista)
            {
                CategoriaViewModel categoria = new CategoriaViewModel()
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao
                };
                ListaCategoria.Add(categoria);
            }

            return ListaCategoria;
        }
    }
}
