using PM2Parcial3.ViewModels;
namespace PM2Parcial3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PageProducts();
            MainPage.BindingContext = new ProductosViewmodel();
        }
    }
}
