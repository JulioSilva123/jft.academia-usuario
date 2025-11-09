using jft.academia.v01.Aplicativo.ModelsPagesViews;
using jft.academia.v01.Core.Entities;
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
    public partial class GruposItem : ContentPage
    {
        public GruposItem()
        {
            InitializeComponent();
            //BindingContext = new GruposAtividadesItemPageViewModel();
        }


        public GruposItemPageModelView _viewModel;



        async void OnSaveClicked(object sender, EventArgs e)
        {

            var _page = (GruposItemPageModelView)BindingContext;
            var todoItem = _page.SelectedItem;

            var _t = new Grupos();

            _t.id_grupo_atividade = todoItem.id_grupo_atividade;
            _t.nm_grupo_atividade = todoItem.nm_grupo_atividade;
             

            await _page.dbAcademia.Grupos.SaveItemAsync(_t);
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