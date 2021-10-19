using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico.Intefaces
{
    public interface IServicoAplicacaoCliente
    {
        IEnumerable<ClienteViewModel> Listagem();
        ClienteViewModel CarregarRegistro(int codigoCategoria);
        void Cadastrar(ClienteViewModel categoria);
        void Excluir(int id);
    }
}
