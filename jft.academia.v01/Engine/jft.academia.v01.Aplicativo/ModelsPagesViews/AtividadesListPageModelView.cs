using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Core.EntitiesViews;
using jft.academia.v01.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.ModelsPagesViews
{
    public class AtividadesListPageModelView : BaseListPageModelView<Atividades, AtividadesModel>
    {



        public AtividadesListPageModelView()
        {
            Title = "Atividades";

        }

        public override Task<List<AtividadesModel>> GetItemsView()
        {
            return this.dbAcademiaViews.Atividades.GetViewItemsAsync(); //  null; // await this.dbAcademia.Atividades.GetItemsAsync();
        }

        public override void OnAddItem(object obj)
        {
            throw new NotImplementedException();
        }

        public override void OnAppearing()
        {
            base.OnAppearingBaseListPage();
        }

        public async override void OnItemSelected(AtividadesModel item)
        {
            if (item == null)
                return;

            await Shell.Current.GoToAsync($"AtividadesItem?{nameof(AtividadesItemPageModelView.ItemId)}={item.id_atividade}");

            return;
        }
    }
}
