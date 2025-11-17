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
	public partial class Atividades_GruposItem : ContentPage
	{
		public Atividades_GruposItem ()
		{
			InitializeComponent ();
            BindingContext = _viewModel= new Atividades_GruposItemPageModelView();


        }


        public Atividades_GruposItemPageModelView _viewModel;



        async void OnSaveClicked(object sender, EventArgs e)
        {

            var _page = (Atividades_GruposItemPageModelView)BindingContext;
            var todoItem = _page.SelectedItem;

            var _t = _page.dbAcademiaViews.Atividades_Grupos.GetModelToEntityAsync(todoItem).Result;

            await _page.dbAcademia.Atividades_Grupos.SaveItemAsync(_t);
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