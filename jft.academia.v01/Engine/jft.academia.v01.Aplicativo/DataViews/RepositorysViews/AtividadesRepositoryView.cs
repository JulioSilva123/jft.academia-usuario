using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Aplicativo.ModelsEntities;
using jft.academia.v01.Core.Entities;
using jft.academia.v01.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jft.academia.v01.Aplicativo.DataViews.RepositorysViews
{
    public class AtividadesRepositoryView : BasePageModelView<Atividades, AtividadesModel>, IDataStoreViewAsync<AtividadesModel>
    {

        



        public Task<bool> DeleteViewItemAsync(AtividadesModel item)
        {
            throw new NotImplementedException();
        }

        public Task<List<AtividadesModel>> GetViewItemsAsync(bool forceRefresh = false)
        {
             

            var _result = this.dbAcademia.Atividades.GetItemsAsync().ContinueWith(t =>
            {
                
                var atividades = t.Result;
                var listAtividadesView = new List<AtividadesModel>();


                //var dataGruposAtividades = new GruposAtividadesService();
                //var dataTiposAtividades = new TiposAtividadesService();
                
                foreach (var atividade in atividades)
                {
                    //var _grupoatividade = dataGruposAtividades.GetItemAsync(atividade.id_grupo_atividade);
                    //var _tipoatividade = dataTiposAtividades.GetItemAsync(atividade.id_tipo_atividade);
                    var _view = new AtividadesModel
                    {
                        id_atividade = atividade.id_atividade,
                        nm_atividade = atividade.nm_atividade,
                        te_descricao = atividade.te_descricao,
                        
                    };
                    listAtividadesView.Add(_view);
                }
                return listAtividadesView;
            });


            return _result;


        }

        public Task<bool> SaveViewItemAsync(AtividadesModel item)
        {
            throw new NotImplementedException();
        }
    }
}
