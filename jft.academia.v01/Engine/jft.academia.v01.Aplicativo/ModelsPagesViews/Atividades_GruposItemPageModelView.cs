using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Aplicativo.ModelsEntities;
using jft.academia.v01.Core.Entities;
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
                var item = await this.dbAcademia.Atividades_Grupos.GetItemAsync(int.Parse(itemId));
                 

                this.SelectedItem.id_atividade_grupo = item.id_atividade_grupo;
                this.SelectedItem.id_atividade = item.id_atividade;
                this.SelectedItem.id_grupo_atividade = item.id_grupo_atividade;
                this.SelectedItem.nr_ordem = item.nr_ordem;
                this.SelectedItem.te_descricao = item.te_descricao;
                 



            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }



  
    }
}
