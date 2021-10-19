﻿using Dominio.Entidades;
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
        where TEntidade : EntityBase, new()
    {
        DbContext Db;
        DbSet<TEntidade> DbSetContext;

        public Repositorio(DbContext dbContext)
        {
            Db = dbContext;
            DbSetContext = Db.Set<TEntidade>();
        }

        public void Create(TEntidade Entity)
        {
            if (Entity.Codigo == null)
            {
                DbSetContext.Add(Entity);
            }
            else
            {
                Db.Entry(Entity).State = EntityState.Modified;
            }

            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var ent = new TEntidade { Codigo = id };
            DbSetContext.Attach(ent);
            DbSetContext.Remove(ent);
            Db.SaveChanges();

        }

        public TEntidade Read(int id)
        {
            return DbSetContext.Where(x => x.Codigo == id).FirstOrDefault();
        }

        public IEnumerable<TEntidade> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
