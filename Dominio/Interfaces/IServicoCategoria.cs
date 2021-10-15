using SistemaVendas.Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IServicoCategoria
    {
        IEnumerable<Categoria> Listagem();

        void Cadastrar(Categoria categoria);

        Categoria CarregarRegistro(int id);

        void Excluir(int id);
    }
}