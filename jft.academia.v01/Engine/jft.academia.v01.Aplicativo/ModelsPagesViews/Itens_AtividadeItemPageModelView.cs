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
    public class Itens_AtividadeItemPageModelView : BaseItemPageModelView<Itens_Atividade, Itens_AtividadeModel>
    {


        public Itens_AtividadeItemPageModelView()
        {

            Title = "Grupo";
           
        }

 
         
        public override async void LoadItemId(string itemId)
        {
            try
            {
                //var item = await DataStore.GetItemAsync(int.Parse(itemId));
                var item = await this.dbAcademiaViews.Itens_Atividade.GetViewItemAsync(int.Parse(itemId));


                this.SelectedItem = item;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }



  
    }
}
