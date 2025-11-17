using jft.academia.v01.Aplicativo.Common;
using jft.academia.v01.Core.Entities;
using jft.academia.v01.Core.EntitiesViews;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace jft.academia.v01.Aplicativo.ModelsPagesViews
{
    public class Itens_AtividadeListPageModelView : BaseListPageModelView<Itens_Atividade, Itens_AtividadeModel>
    {



        public Itens_AtividadeListPageModelView()
        {
            Title = "Grupos de Atividades";

        }

        public override Task<List<Itens_AtividadeModel>> GetItemsView()
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

        public async override void OnItemSelected(Itens_AtividadeModel item)
        {
            if (item == null)
                return;

            await Shell.Current.GoToAsync($"Itens_AtividadeItem?{nameof(Itens_AtividadeItemPageModelView.ItemId)}={item.id_item_atividade}");

            return;
        }
    }
}
