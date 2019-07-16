using Contactos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contactos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Contacto> contactos;
        public MainPage()
        {

            InitializeComponent();
            contactos = new List<Contacto>();

            contactosListView.ItemSelected += ContactosListView_ItemSelected;
        }

        private void ContactosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactoSeleccionado= e.SelectedItem as Contacto;
            Navigation.PushAsync(new DetalleContactoPage(contactoSeleccionado));
        }

        protected override void OnAppearing()
        {
                          
            base.OnAppearing();
            using (var conn =new SQLite.SQLiteConnection(App.RUTA_DB))
            {
                conn.CreateTable<Contacto>();
                contactos = conn.Table<Contacto>().ToList();
                contactosListView.ItemsSource = contactos;
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }
    }
}
