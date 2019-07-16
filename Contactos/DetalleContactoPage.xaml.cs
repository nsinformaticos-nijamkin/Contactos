using Contactos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleContactoPage : ContentPage
    {
        public Contacto Contacto { get; set; }
        public DetalleContactoPage(Contacto contacto)
        {
            InitializeComponent();
            Contacto = contacto;
            nombreLabel.Text = $"{Contacto.Nombre} {Contacto.Apellido}";
            telefonoLabel.Text =Contacto.Telefono;
            correoLabel.Text =Contacto.Email;

        }
    }
}