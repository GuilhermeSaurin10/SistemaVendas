﻿using System.Collections.Generic;

namespace Dominio.Repositorio
{
    public interface IRepositorio<TEntidade>
        where TEntidade : class
    {
        void Create(TEntidade Entity);

        TEntidade Read<T>(int id);

        void Delete(int id);

        IEnumerable<TEntidade> Read();
    }
}