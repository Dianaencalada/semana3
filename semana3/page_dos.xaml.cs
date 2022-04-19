using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class page_dos : ContentPage
    {
        public page_dos(string User,string Pass)
        {
            InitializeComponent();
            //DisplayAlert("Mensaje", "El usuario es:" + User + "La contraseña es:" + Pass, "cerrar");
            lblUser.Text = User;
            lblPass.Text = Pass;
            
        }
    }
}