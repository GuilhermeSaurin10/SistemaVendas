using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using SistemaVendas.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio
{
    public abstract class Repositorio<TEntidade> : DbContext, IRepositorio<TEntidade>
        where TEntidade : class, new()
    {
        DbContext Db;
        DbSet<TEntidade> DbSetContext;

        public Repositorio(DbContext DbContext)
        {
            Db = DbContext;
            DbSetContext = Db.Set<TEntidade>();
        }
        public void Create(TEntidade Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TEntidade Read<T>(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidade> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
