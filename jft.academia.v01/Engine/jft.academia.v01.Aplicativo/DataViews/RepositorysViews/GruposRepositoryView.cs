using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Aplicativo.ModelsEntities;
using jft.academia.v01.Core.Entities;
using jft.academia.v01.Core.EntitiesViews;
using jft.academia.v01.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//namespace jft.academia.v01.Aplicativo.DataViews.RepositorysViews
//{
//    public class GruposRepositoryView : 
//        BasePageModelView<Grupos, GruposModel>, 
//        IDataStoreViewAsync<Grupos, GruposModel>
//    {

        



//        public Task<bool> DeleteViewItemAsync(GruposModel item)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<GruposModel> GetEntityToModelAsync(Grupos _entity)
//        {
//            var _r = new GruposModel
//            {
//                id_grupo_atividade = _entity.id_grupo_atividade,
//                nm_grupo_atividade = _entity.nm_grupo_atividade
//            };

//            return Task.FromResult(_r);
//        }

//        public Task<Grupos> GetModelToEntityAsync(GruposModel _entityModel)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<GruposModel> GetViewItemAsync(int id)
//        {
//            var _result = this.dbAcademia.Grupos.GetItemAsync(id).Result;


//            return this.GetEntityToModelAsync(_result);
//        }

//        public Task<List<GruposModel>> GetViewItemsAsync(bool forceRefresh = false)
//        {
             

//            var _result = this.dbAcademia.Grupos.GetItemsAsync().ContinueWith(t =>
//            {
                
//                var lista = t.Result;
//                var listAtividadesView = new List<GruposModel>();
                
//                foreach (var _item in lista)
//                {

//                    var _view = this.GetEntityToModelAsync(_item).Result;
//                    listAtividadesView.Add(_view);

//                }
//                return listAtividadesView;
//            });


//            return _result;


//        }

//        public Task<bool> SaveViewItemAsync(GruposModel item)
//        {
//            throw new NotImplementedException();
//        }


//    }
//}
