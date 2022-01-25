using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appPP.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Catedraticos : ContentPage
    {
        public Catedraticos()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}