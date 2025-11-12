using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jft.academia.v01.Aplicativo.Controls.FormsViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderFlayoutView : ContentView
    {
        public HeaderFlayoutView()
        {
            InitializeComponent();

            Random random = new Random();
            int randomNumber = random.Next(1, 11);

        

            // Output: Name: Alice, Age: 30
            this.im_topo_flayout.Source = String.Format("fundo0{0}.jpg", randomNumber.ToString());

        }
    }
}