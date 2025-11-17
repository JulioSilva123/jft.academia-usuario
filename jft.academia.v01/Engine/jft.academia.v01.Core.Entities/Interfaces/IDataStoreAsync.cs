using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jft.academia.v01.Core.Entities.Interfaces
{
    public interface IDataStoreAsync<T>
    {

        Task<bool> SaveItemAsync(T item);
        //public Task<int> SavePersonAsync(Person person)
        //{
        //    return _database.InsertAsync(person);
        //}

        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        //public Task<int> UpdatePersonAsync(Person person)
        //{
        //    return _database.UpdateAsync(person);
        //}

        Task<bool> DeleteItemAsync(T item);
        //public Task<int> DeletePersonAsync(Person person)
        //{
        //    return _database.DeleteAsync(person);
        //}


        Task<List<T>> GetListAsync();
        //public Task<List<Person>> GetPeopleAsync()
        //{
        //    return _database.Table<Person>().ToListAsync();
        //}

        Task<T> GetItemAsync(int id);
        Task<List<T>> GetItemsAsync(bool forceRefresh = false);
        Task<IEnumerable<T>> GetItemsAsyncEnumerable(bool forceRefresh = false);


        Task<List<T>> GetQueryAsync(string _select, string _from, string _where);
        //public Task<List<Person>> QuerySubscribedAsync()
        //{
        //    return _database.QueryAsync<Person>("SELECT * FROM Person WHERE Subscribed = true");
        //}

        //public Task<List<Person>> LinqNotSubscribedAsync()
        //{
        //    return _database.Table<Person>().Where(p => p.Subscribed == false).ToListAsync();
        //}


    }




}
