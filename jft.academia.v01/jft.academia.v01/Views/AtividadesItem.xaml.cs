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
    public partial class AtividadesItem : ContentPage
    {
        public AtividadesItem()
        {
            InitializeComponent();


            BindingContext = new AtividadesItemPageModelView();


        }


        public AtividadesItemPageModelView _viewModel;



        async void OnSaveClicked(object sender, EventArgs e)
        {

            var _page = (AtividadesItemPageModelView)BindingContext;
            var todoItem = _page.SelectedItem;

            var _t = new Atividades();

            _t.id_atividade = todoItem.id_atividade;
            _t.nm_atividade= todoItem.nm_atividade;
            _t.te_descricao = todoItem.te_descricao;


            await _page.dbAcademia.Atividades.SaveItemAsync(_t);
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