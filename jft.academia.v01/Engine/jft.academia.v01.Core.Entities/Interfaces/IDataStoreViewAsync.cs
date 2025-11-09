using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jft.academia.v01.Core.Entities.Interfaces
{
    public interface IDataStoreViewAsync<TEntityView>
    {

        Task<List<TEntityView>> GetViewItemsAsync(bool forceRefresh = false);


        Task<bool> SaveViewItemAsync(TEntityView item);


        Task<bool> DeleteViewItemAsync(TEntityView item);


    }
}
