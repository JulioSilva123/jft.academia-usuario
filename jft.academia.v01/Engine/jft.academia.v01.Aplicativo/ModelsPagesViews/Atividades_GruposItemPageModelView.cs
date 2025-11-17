using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Core.Entities;
using jft.academia.v01.Core.EntitiesViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.ModelsPagesViews
{

    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class Atividades_GruposItemPageModelView : BaseItemPageModelView<Atividades_Grupos, Atividades_GruposModel>
    {


        public Atividades_GruposItemPageModelView()
        {

            Title = "Atividades Grupos";
           
        }

 

        public override async void LoadItemId(string itemId)
        {
            try
            {
                //var item = await DataStore.GetItemAsync(int.Parse(itemId));
                var item = await this.dbAcademia.Atividades_Grupos.GetItemAsync(int.Parse(itemId));

                this.SelectedItem = this.dbAcademiaViews.Atividades_Grupos.GetEntityToModelAsync(item).Result;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }



  
    }
}
