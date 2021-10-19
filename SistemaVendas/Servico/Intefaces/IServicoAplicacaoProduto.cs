﻿using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico.Intefaces
{
    public interface IServicoAplicacaoProduto
    {
        IEnumerable<ProdutoViewModel> Listagem();
        ProdutoViewModel CarregarRegistro(int codigoProduto);
        void Cadastrar(ProdutoViewModel produto);
        void Excluir(int id);
    }
}
