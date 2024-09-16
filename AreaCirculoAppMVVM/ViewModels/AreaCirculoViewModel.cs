using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace AreaCirculoAppMVVM.ViewModels
{
    public partial class AreaCirculoViewModel : ObservableObject
    {

        [ObservableProperty]

        private double rad;

        [ObservableProperty]

        private double resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {
            try
            {

                if(Rad < 1)
                {
                    Alerta("Alerta", "El radio del circulo tiene que ser mayor a cero");
                } else
                {
                    Resultado = Math.PI * Math.Pow(Rad, 2);
                }
            }
            catch (Exception ex)
            {
                Alerta("Error", ex.Message);
            }

        }

        [RelayCommand]

        private void Limpiar()
        {
            Rad = 0;
            Resultado = 0;
        }

    }

}
