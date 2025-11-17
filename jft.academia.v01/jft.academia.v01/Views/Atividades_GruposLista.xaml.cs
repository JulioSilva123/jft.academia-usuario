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
	public partial class Atividades_GruposLista : ContentPage
	{
		public Atividades_GruposLista ()
		{
			InitializeComponent ();
            BindingContext = _viewModel = new Atividades_GruposListPageModelView();
        }


		Atividades_GruposListPageModelView _viewModel;




        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
            ItemsListView.ItemsSource = await _viewModel.dbAcademiaViews.Atividades_Grupos.GetViewItemsAsync(); // _database.GetItemsViewAsync();



        }


        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Atividades_GruposItem
            {
                BindingContext = new Atividades_GruposItemPageModelView()
                {
                    SelectedItem = new Atividades_GruposModel()
                }
            });
            // await Navigation.PushAsync(new GruposItem());
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {

                var _t = e.SelectedItem as Atividades_Grupos;
                var _model = new Atividades_GruposItemPageModelView();
                
                _model.SelectedItem = _viewModel.dbAcademiaViews.Atividades_Grupos.GetEntityToModelAsync(_t).Result;

                await Navigation.PushAsync(new Atividades_GruposItem
                {
                    BindingContext = _model
                });


            }
        }


    }
}