using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Core.Entities;
using jft.academia.v01.Core.EntitiesViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.ModelsPagesViews
{

    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class AtividadesItemPageModelView : BaseItemPageModelView<Atividades, AtividadesModel>
    {


        public AtividadesItemPageModelView()
        {

            Title = "Grupo";
           
        }





        
        public override async void LoadItemId(string itemId)
        {
            try
            {
                //var item = await DataStore.GetItemAsync(int.Parse(itemId));
                var item = this.dbAcademia.Atividades.GetItemAsync(int.Parse(itemId)).Result;
                var _r = this.dbAcademiaViews.Atividades.GetEntityToModelAsync(item).Result;






                var ag = this.dbAcademiaViews.Atividades_Grupos 
                                .GetViewItemsAsync()
                                .Result
                                .Where(x => x.Atividades.id_atividade == int.Parse(itemId))
                                .ToList();

                
                
                ag.ForEach(x => _r.Atividades_Grupos.Add(x) );


                var ia = this.dbAcademiaViews.Itens_Atividade
                                .GetViewItemsAsync()
                                .Result
                                .Where(x => x.Atividades.id_atividade == int.Parse(itemId))
                                .ToList();

                ia.ForEach(x => _r.Itens_Atividade.Add(x));

                this.SelectedItem = _r;


                //this.SelectedItem = new AtividadesModel();
                //this.SelectedItem.id_atividade = item.id_atividade;
                //this.SelectedItem.nm_atividade = item.nm_atividade;
                //this.SelectedItem.te_descricao = item.te_descricao;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }



  
    }
}
