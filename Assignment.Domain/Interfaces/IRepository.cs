using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Domain.Interfaces

    //Ett interface är ett kontrakt
    //Beskriver vad något i det här fallet repositoryn ska kunna göra
    //, utan att säga hur
    //Vi definerar repository - interfacet här i Domain
    //och senare implementerar INfrastructure det.
    //Det betyder: att den som ska uppfylla metoderna i interfacet. Den lovar 
    //att alla metoder finns som interfacet kräver. 
    //om en metod inte är med så interfacet tvingar den att uppfylla kontraktet. 
{
    public interface IRepository<T> where T : class
    {
                Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}

