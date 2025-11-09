using jft.academia.v01.Aplicativo.ModelsEntities;
using jft.academia.v01.Aplicativo.ModelsPagesViews;
using jft.academia.v01.Core.Entities;
using jft.Academia.v01.Infra01.Data;
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
    public partial class GruposLista : ContentPage
    {
        public GruposLista()
        {
            InitializeComponent();
            BindingContext = _viewModel = new GruposListPageModelView();
        }


        public GruposListPageModelView _viewModel;




        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
            listView.ItemsSource = await _viewModel.dbAcademia.Grupos.GetItemsAsync(); // _database.GetItemsViewAsync();



        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GruposItem
            {
                BindingContext = new GruposItemPageModelView()
                {
                    SelectedItem = new GruposModel()
                }
            });
           // await Navigation.PushAsync(new GruposItem());
        }
     
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {

                var _t = e.SelectedItem as Grupos;

                var _model = new GruposItemPageModelView();

                _model.SelectedItem = new GruposModel
                {
                    id_grupo_atividade = _t.id_grupo_atividade,
                    nm_grupo_atividade = _t.nm_grupo_atividade
                };

                await Navigation.PushAsync(new GruposItem
                {
                    BindingContext = _model
                });
            }
        }

    }
}