using jft.academia.v01.Aplicativo.ModelsPagesViews;
using jft.academia.v01.Core.EntitiesViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jft.academia.v01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Itens_AtividadeItem : ContentPage
    {
        public Itens_AtividadeItem()
        {
            InitializeComponent();
            BindingContext = _viewModel = new Itens_AtividadeItemPageModelView();



            


        }

        public Itens_AtividadeItemPageModelView _viewModel;

        


        async void OnSaveClicked(object sender, EventArgs e)
        {

            var _page = (Itens_AtividadeItemPageModelView)BindingContext;
            var todoItem = _page.SelectedItem;

            var _t = _page.dbAcademiaViews.Itens_Atividade.GetModelToEntityAsync(todoItem).Result;

            await _page.dbAcademia.Itens_Atividade.SaveItemAsync(_t);
            await Navigation.PopAsync();


        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            //var todoItem = (GruposAtividadesView)BindingContext;
            //var _database = new GruposAtividadesViewService();

            //await _database.DeleteItemViewAsync(todoItem.id_grupo_atividade.ToString());
            await Navigation.PopAsync();


        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
}