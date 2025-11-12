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
    public class Atividades_GruposRepositoryView : 
        BasePageModelView<Atividades_Grupos, Atividades_GruposModel>, 
        IDataStoreViewAsync<Atividades_GruposModel>
    {

        



        public Task<bool> DeleteViewItemAsync(Atividades_GruposModel item)
        {
            throw new NotImplementedException();
        }

        public Task<List<Atividades_GruposModel>> GetViewItemsAsync(bool forceRefresh = false)
        {
             

            var _result = this.dbAcademia.Atividades_Grupos.GetItemsAsync().ContinueWith(t =>
            {
                
                var atividades = t.Result;
                var listAtividadesView = new List<Atividades_GruposModel>();


                //var dataGruposAtividades = new GruposAtividadesService();
                //var dataTiposAtividades = new TiposAtividadesService();
                
                foreach (var atividade in atividades)
                {
                    //var _grupoatividade = dataGruposAtividades.GetItemAsync(atividade.id_grupo_atividade);
                    //var _tipoatividade = dataTiposAtividades.GetItemAsync(atividade.id_tipo_atividade);
                    var _view = new Atividades_GruposModel
                    {
                         id_atividade_grupo = atividade.id_atividade_grupo,
                         id_atividade = atividade.id_atividade,
                         id_grupo_atividade = atividade.id_grupo_atividade,
                         nr_ordem = atividade.nr_ordem,
                         te_descricao = atividade.te_descricao

                    };
                    listAtividadesView.Add(_view);
                }
                return listAtividadesView;
            });


            return _result;


        }

        public Task<bool> SaveViewItemAsync(Atividades_GruposModel item)
        {
            throw new NotImplementedException();
        }
    }
}
