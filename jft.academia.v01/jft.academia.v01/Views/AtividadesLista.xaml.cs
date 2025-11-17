using jft.academia.v01.Aplicativo.ModelsPagesViews;
using jft.academia.v01.Core.Entities;
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
    public partial class AtividadesLista : ContentPage
    {
        public AtividadesLista()
        {
            InitializeComponent();
            BindingContext = _viewModel = new AtividadesListPageModelView();
        }


        public AtividadesListPageModelView _viewModel;




        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
            ItemsListView.ItemsSource = await _viewModel.dbAcademiaViews.Atividades.GetViewItemsAsync(); // _database.GetItemsViewAsync();



        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AtividadesItem
            {
                BindingContext = new AtividadesItemPageModelView()
                {
                    SelectedItem = new AtividadesModel()
                }
            });
            // await Navigation.PushAsync(new GruposItem());
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {

                var _t = e.SelectedItem as Atividades;

                var _model = new AtividadesItemPageModelView();

                _model.SelectedItem = new AtividadesModel
                {
                    id_atividade = _t.id_atividade,
                    nm_atividade = _t.nm_atividade,
                    te_descricao = _t.te_descricao
                };

                await Navigation.PushAsync(new AtividadesItem
                {
                    BindingContext = _model
                });
            }
        }

    }
}