using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Core.Entities;
using jft.academia.v01.Core.EntitiesViews;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.ModelsPagesViews
{
    public class GruposListPageModelView : BaseListPageModelView<Grupos, GruposModel>
    {



        public GruposListPageModelView()
        {
            Title = "Grupos de Atividades";

        }

        public override Task<List<GruposModel>> GetItemsView()
        {
            throw new NotImplementedException();
        }

        public override void OnAddItem(object obj)
        {
            throw new NotImplementedException();
        }

        public override void OnAppearing()
        {
            base.OnAppearingBaseListPage();
        }

        public async override void OnItemSelected(GruposModel item)
        {
            if (item == null)
                return;

            await Shell.Current.GoToAsync($"GruposItem?{nameof(GruposItemPageModelView.ItemId)}={item.id_grupo_atividade}");

            return;
        }
    }
}
