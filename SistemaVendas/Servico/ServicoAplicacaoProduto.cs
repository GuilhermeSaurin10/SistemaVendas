﻿using Aplicacao.Servico.Intefaces;
using Dominio.Interfaces;
using SistemaVendas.Dominio.Entidades;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoProduto : IServicoAplicacaoProduto
    {
        private readonly IServicoProduto ServicoProduto;
        public ServicoAplicacaoProduto(IServicoProduto servicoProduto)
        {
            ServicoProduto = servicoProduto;
        }

        public void Cadastrar(ProdutoViewModel produto)
        {
            Produto item = new Produto()
            {
                Codigo = produto.Codigo,
                Descricao = produto.Descricao,
                Quantidade = produto.Quantidade,
                Valor = (decimal)produto.Valor,
                CodigoCategoria = (int)produto.CodigoCategoria
            };

            ServicoProduto.Cadastrar(item);
        }

        public ProdutoViewModel CarregarRegistro(int codigoProduto)
        {

            var registro = ServicoProduto.CarregarRegistro(codigoProduto);

            ProdutoViewModel produto = new ProdutoViewModel()
            {
                Codigo = registro.Codigo,
                Descricao = registro.Descricao,
                Quantidade = registro.Quantidade,
                Valor = (decimal)registro.Valor,
                CodigoCategoria = (int)registro.CodigoCategoria
            };

            return produto;
        }

        public void Excluir(int id)
        {
            ServicoProduto.Excluir(id);
        }

        public IEnumerable<ProdutoViewModel> Listagem()
        {
            var lista = ServicoProduto.Listagem();
            List<ProdutoViewModel> ListaProduto = new List<ProdutoViewModel>();

            foreach (var item in lista)
            {
                ProdutoViewModel produto = new ProdutoViewModel()
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao,
                    Quantidade = item.Quantidade,
                    Valor = (decimal)item.Valor,
                    CodigoCategoria = (int)item.CodigoCategoria,
                    DescricaoCategoria = item.Categoria.Descricao
                };
                ListaProduto.Add(produto);
            }

            return ListaProduto;
        }
    }
}