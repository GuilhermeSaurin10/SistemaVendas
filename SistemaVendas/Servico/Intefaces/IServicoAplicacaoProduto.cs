using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico.Intefaces
{
    public interface IServicoAplicacaoProduto
    {
        IEnumerable<ProdutoViewModel> Listagem();
        ProdutoViewModel CarregarRegistro(int codigoCliente);
        void Cadastrar(ProdutoViewModel cliente);
        void Excluir(int id);
    }
}
