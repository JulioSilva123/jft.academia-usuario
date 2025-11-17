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
    public class GruposItemPageModelView : BaseItemPageModelView<Grupos, GruposModel>
    {


        public GruposItemPageModelView()
        {

            Title = "Grupo";
           
        }

 

        //private int _id_grupo_atividade;
        //public int id_grupo_atividade
        //{
        //    get
        //    {
        //        if (this.ItemId != null)
        //        {
        //            _id_grupo_atividade = int.Parse(this.ItemId);
        //        }

        //        return _id_grupo_atividade;

        //    }
        //    set
        //    {
        //        _id_grupo_atividade = value;
        //        this.LoadItemId(value.ToString());
        //    }
        //}


        //private string _nm_grupo_atividade;
        //public string nm_grupo_atividade
        //{
        //    get => _nm_grupo_atividade;
        //    set => SetProperty(ref _nm_grupo_atividade, value);
        //}



        //public override void LoadItemId(string _id)
        //{
        //    throw new NotImplementedException();
        //}
        public override async void LoadItemId(string itemId)
        {
            try
            {
                //var item = await DataStore.GetItemAsync(int.Parse(itemId));
                var item = await this.dbAcademia.Grupos.GetItemAsync(int.Parse(itemId));


                this.SelectedItem.id_grupo_atividade = item.id_grupo_atividade;
                this.SelectedItem.nm_grupo_atividade = item.nm_grupo_atividade;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }



  
    }
}
