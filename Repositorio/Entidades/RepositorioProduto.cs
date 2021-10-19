using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using SistemaVendas.Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Repositorio.Contexto;

namespace Repositorio.Entidades
{
    public class RepositorioProduto : Repositorio<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
