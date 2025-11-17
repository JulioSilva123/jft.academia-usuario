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
//    public class AtividadesRepositoryView : 
//        BasePageModelView<Atividades, AtividadesModel>, 
//        IDataStoreViewAsync<Atividades, AtividadesModel>
//    {

        



//        public Task<bool> DeleteViewItemAsync(AtividadesModel item)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<AtividadesModel> GetEntityToModelAsync(Atividades _entity)
//        {
//            var _r = new AtividadesModel
//            {
//                id_atividade = _entity.id_atividade,
//                nm_atividade = _entity.nm_atividade,
//                te_descricao = _entity.te_descricao,

//            };

//            return Task.FromResult(_r);

//        }

//        public Task<Atividades> GetModelToEntityAsync(AtividadesModel _entityModel)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<AtividadesModel> GetViewItemAsync(int id)
//        {
//            var _result = this.dbAcademia.Atividades.GetItemAsync(id).Result;


//            return this.GetEntityToModelAsync(_result);
//        }

//        public Task<List<AtividadesModel>> GetViewItemsAsync(bool forceRefresh = false)
//        {
             

//            var _result = this.dbAcademia.Atividades.GetItemsAsync().ContinueWith(t =>
//            {
                
//                var atividades = t.Result;
//                var listAtividadesView = new List<AtividadesModel>();
                
//                foreach (var _item in atividades)
//                {
//                    var _view = this.GetEntityToModelAsync(_item).Result;
//                    listAtividadesView.Add(_view);
//                }
//                return listAtividadesView;
//            });


//            return _result;


//        }

//        public Task<bool> SaveViewItemAsync(AtividadesModel item)
//        {
//            throw new NotImplementedException();
//        }






//    }
//}
