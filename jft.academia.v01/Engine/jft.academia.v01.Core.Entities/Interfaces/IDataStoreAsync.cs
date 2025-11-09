using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jft.academia.v01.Core.Entities.Interfaces
{
    public interface IDataStoreAsync<T>
    {

        Task<bool> SaveItemAsync(T item);
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(T item);




        Task<T> GetItemAsync(int id);
        Task<List<T>> GetItemsAsync(bool forceRefresh = false);
         

        Task<IEnumerable<T>> GetItemsAsyncEnumerable(bool forceRefresh = false);
    }
}
