﻿using Dominio.Interfaces;
using SistemaVendas.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico.Interfaces
{
    public class ServicoAplicacaoCategoria : IServicoAplicacaoCategoria
    {
        private readonly IServicoCategoria ServicoCategoria;

        public ServicoAplicacaoCategoria(IServicoCategoria servicoCategoria)
        {
            ServicoCategoria = servicoCategoria;
        }

        public IEnumerable<CategoriaViewModel> Listagem()
        {
            var lista = ServicoCategoria.Listagem();
            List<CategoriaViewModel> listaCategoria = new List<CategoriaViewModel>();

            foreach (var item in lista)
            {
                CategoriaViewModel categoria = new CategoriaViewModel()
                {
                    Codigo = item.Codigo,
                    Descricao = item.Descricao
                };
                listaCategoria.Add(categoria);
            }
            return listaCategoria;
        }
    }
}