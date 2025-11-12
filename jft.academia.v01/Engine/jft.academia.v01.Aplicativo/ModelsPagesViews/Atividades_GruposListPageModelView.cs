using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Aplicativo.ModelsEntities;
using jft.academia.v01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.ModelsPagesViews
{
    public class Atividades_GruposListPageModelView : BaseListPageModelView<Atividades_Grupos, Atividades_GruposModel>
    {



        public Atividades_GruposListPageModelView()
        {
            Title = "Grupos de Atividades";

        }

        public override Task<List<Atividades_GruposModel>> GetItemsView()
        {
            return this.dbAcademiaViews.Atividades_Grupos.GetViewItemsAsync(); //  null; // await this.dbAcademia.Atividades.GetItemsAsync();
        }

        public override void OnAddItem(object obj)
        {
            throw new NotImplementedException();
        }

        public override void OnAppearing()
        {
            base.OnAppearingBaseListPage();
        }

        public async override void OnItemSelected(Atividades_GruposModel item)
        {
            if (item == null)
                return;

            await Shell.Current.GoToAsync($"Atividades_GruposItem?{nameof(Atividades_GruposItemPageModelView.ItemId)}={item.id_grupo_atividade}");

            return;
        }
    }
}
