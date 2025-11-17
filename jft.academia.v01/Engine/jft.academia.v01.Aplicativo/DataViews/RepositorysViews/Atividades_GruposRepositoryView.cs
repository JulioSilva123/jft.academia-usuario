using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Aplicativo.ModelsEntities;
using jft.academia.v01.Core.Entities;
using jft.academia.v01.Core.Entities.Interfaces;
using jft.academia.v01.Core.EntitiesViews;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//namespace jft.academia.v01.Aplicativo.DataViews.RepositorysViews
//{
//    public class Atividades_GruposRepositoryView : 
//        BasePageModelView<Atividades_Grupos, Atividades_GruposModel>, 
//        IDataStoreViewAsync<Atividades_Grupos, Atividades_GruposModel>
//    {

        



//        public Task<bool> DeleteViewItemAsync(Atividades_GruposModel item)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<Atividades_GruposModel> GetEntityToModelAsync(Atividades_Grupos _entity)
//        {
//            var _atividade = this.dbAcademiaViews.Atividades.GetViewItemAsync(_entity.id_atividade).Result;
//            var _grupos = this.dbAcademiaViews.Grupos.GetViewItemAsync(_entity.id_grupo_atividade).Result;
//            //var _tipoatividade = dataTiposAtividades.GetItemAsync(atividade.id_tipo_atividade);

//            var _r = new Atividades_GruposModel
//            {
//                id_atividade_grupo = _entity.id_atividade_grupo,
//                Atividades = _atividade,
//                Grupos = _grupos,
//                nr_ordem = _entity.nr_ordem,
//                te_descricao = _entity.te_descricao

//            };

//            return Task.FromResult(_r);
//        }

//        public Task<Atividades_Grupos> GetModelToEntityAsync(Atividades_GruposModel _entityModel)
//        {

            
//            var _r = new Atividades_Grupos 
//            {
//                id_atividade_grupo = _entityModel.id_atividade_grupo,
//                id_atividade = _entityModel.Atividades.id_atividade,
//                id_grupo_atividade = _entityModel.Grupos.id_grupo_atividade,
//                nr_ordem = _entityModel.nr_ordem,
//                te_descricao = _entityModel.te_descricao

//            };

//            return Task.FromResult(_r);

//        }

//        public Task<Atividades_GruposModel> GetViewItemAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<List<Atividades_GruposModel>> GetViewItemsAsync(bool forceRefresh = false)
//        {            

//            var _result = this.dbAcademia.Atividades_Grupos.GetItemsAsync().ContinueWith(t =>
//            {
                
//                var lista = t.Result;
//                var listAtividadesView = new List<Atividades_GruposModel>();
                
//                foreach (var _item in lista)
//                {
//                    //var _atividade = this.dbAcademiaViews.Atividades.GetViewItemAsync(atividade.id_atividade).Result;
//                    //var _grupos = this.dbAcademiaViews.Grupos.GetViewItemAsync(atividade.id_grupo_atividade).Result;
//                    ////var _tipoatividade = dataTiposAtividades.GetItemAsync(atividade.id_tipo_atividade);

//                    var _view = this.GetEntityToModelAsync(_item).Result;
//                    listAtividadesView.Add(_view);
//                }
//                return listAtividadesView;
//            });


//            return _result;


//        }

//        public Task<bool> SaveViewItemAsync(Atividades_GruposModel item)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
