using System.Collections.ObjectModel;

namespace BallonParty
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Arreglo de Temporada", Description = "Arreglo con globos y flores en tonos pastel.", Image = "arreglo1.jpeg" },
                new Product { Name = "Arreglo de Cumpleaños", Description = "Decoración con luces y globos metálicos.", Image = "arreglo2.jpg" },
                new Product { Name = "Arreglo de BabyShower", Description = "Decoración temática para eventos especiales.", Image = "arreglo3.jpg" },
                new Product { Name = "Arreglo de Boda", Description = "Diseño sofisticado para eventos formales.", Image = "arreglo4.jpg" },
                new Product { Name = "Arreglo de XV", Description = "Decoración colorida ideal para fiestas infantiles.", Image = "arreglo5.jpg" },
                new Product { Name = "Piñatas", Description = "Decoración simple y elegante.", Image = "arreglo6.jpeg" }
            };

            BindingContext = this;
        }

        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }

        private async void OnContactButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage());
        }
    }
}
