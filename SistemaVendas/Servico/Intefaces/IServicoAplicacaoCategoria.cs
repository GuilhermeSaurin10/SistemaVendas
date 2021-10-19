using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico.Intefaces
{
    public interface IServicoAplicacaoCategoria
    {
        IEnumerable<CategoriaViewModel> Listagem();
        CategoriaViewModel CarregarRegistro(int codigoCliente);
        void Cadastrar(CategoriaViewModel cliente);
        void Excluir(int id);
    }
}
