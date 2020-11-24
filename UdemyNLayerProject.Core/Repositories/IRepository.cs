using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UdemyNLayerProject.Core.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int Id);

        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> Find();

    }
}
