using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PM2Parcial3.ViewModels
{
    public class ProductosViewmodel: BaseViewModel
    {
        private Controlador.ProductosController _productosController;

        private string _nombre;
        private double _precio;
        private string _foto;

        public string Nombre {  
            get { return _nombre; }     
            set {  _nombre = value; OnPropertyChanged(); } 
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; OnPropertyChanged(); }
        }
        public string Foto
        {
            get { return _foto; }
            set { _foto = value; OnPropertyChanged(); }
        }


        public ProductosViewmodel()
        {
            _productosController = new Controlador.ProductosController();
            GuardarCommand = new Command(async () => await GuardarProducto());
            Clearcommad = new Command(Cleaner);

        }

        public ICommand Clearcommad { private get; set; }

        public ICommand Createcommad { private get; set; }
        public ICommand Readcommad { private get; set; }
        public ICommand updatecommad { private get; set; }
        public ICommand Deletecommad { private get; set; }
        public ICommand GuardarCommand { private set; get; }

        private void Cleaner()
        {
            Nombre = null;
            Precio = 0;
            Foto = null;
        }
        async Task Createdata()
        {
            try
            {
                var Producto = new Models.Productos {
                    Nombre = Nombre,
                    Precio = Precio,
                    Foto = Foto
                };
            }
            catch(Exception ex) { 

            }
        }

        private async Task GuardarProducto()
        {
            try
            {
                var producto = new Models.Procuctossql
                {
                    Nombre = Nombre,
                    Precio = Precio,
                    Foto = Foto
                };

                await _productosController.StoreSitios(producto);

                // Limpiar los campos después de guardar
                Nombre = string.Empty;
                Precio = 0;
                Foto = string.Empty;
            }
            catch (Exception ex)
            {
                // Manejar el error
            }
        }
    }

}


