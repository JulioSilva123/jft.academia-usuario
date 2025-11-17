using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jft.academia.v01.Core.Entities.Interfaces
{
    public interface IDataStoreViewAsync<TEntity, TEntityView>
    {

        Task<List<TEntityView>> GetViewItemsAsync(bool forceRefresh = false);
        Task<TEntityView> GetViewItemAsync(int id);
        Task<List<TEntityView>> GetQueryViewAsync(string _select, string _from, string _where);




        Task<TEntityView> GetEntityToModelAsync(TEntity _entity);
        Task<TEntity> GetModelToEntityAsync(TEntityView _entityModel);





        Task<bool> SaveViewItemAsync(TEntityView item);
        Task<bool> DeleteViewItemAsync(TEntityView item);


        

    }
}
