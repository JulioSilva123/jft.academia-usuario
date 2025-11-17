using jft.academia.v01.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jft.academia.v01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));



            Routing.RegisterRoute(nameof(AtividadesLista), typeof(AtividadesLista));
            Routing.RegisterRoute(nameof(AtividadesItem), typeof(AtividadesItem));

            Routing.RegisterRoute(nameof(Atividades_GruposItem), typeof(Atividades_GruposItem));
            Routing.RegisterRoute(nameof(Atividades_GruposLista), typeof(Atividades_GruposLista));


            Routing.RegisterRoute(nameof(Itens_AtividadeItem), typeof(Itens_AtividadeItem));
            Routing.RegisterRoute(nameof(Itens_AtividadeLista), typeof(Itens_AtividadeLista));


            Routing.RegisterRoute(nameof(GruposItem), typeof(GruposItem));
            Routing.RegisterRoute(nameof(GruposLista), typeof(GruposLista));





            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));


            //MainPage = new MainPage();

        }
    }
}