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
    public partial class Itens_AtividadeLista : ContentPage
    {
        public Itens_AtividadeLista()
        {
            InitializeComponent();
            BindingContext = _viewModel = new Itens_AtividadeListPageModelView();
        }


        Itens_AtividadeListPageModelView _viewModel;




        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
            ItemsListView.ItemsSource = await _viewModel.dbAcademiaViews.Itens_Atividade.GetViewItemsAsync(); // _database.GetItemsViewAsync();



        }


        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Itens_AtividadeItem
            {
                BindingContext = new Itens_AtividadeItemPageModelView()
                {
                    SelectedItem = new Itens_AtividadeModel()
                }
            });
            // await Navigation.PushAsync(new GruposItem());
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {

                var _t = e.SelectedItem as Itens_Atividade;
                var _model = new Itens_AtividadeItemPageModelView();

                _model.SelectedItem = _viewModel.dbAcademiaViews.Itens_Atividade.GetEntityToModelAsync(_t).Result;

                await Navigation.PushAsync(new Itens_AtividadeItem
                {
                    BindingContext = _model
                });


            }
        }
    }
}