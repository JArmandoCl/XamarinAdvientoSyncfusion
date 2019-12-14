using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAdvientoSyncfusion.Dtos;

namespace XamarinAdvientoSyncfusion.ViewModels
{
    public class PerfilUsuarioViewModel:INotifyPropertyChanged
    {
        #region VariablesObjetos

        private DtoHobbie hobbie;
        private DtoUsuario usuario=new DtoUsuario();

        public DtoUsuario Usuario
        {
            get { return usuario; }
            set { OnSetProperty("Usuario"); }
        }
        private string nuevoHobbie;

        public string NuevoHobbie
        {
            get { return nuevoHobbie; }
            set
            {
                nuevoHobbie = value;
                OnSetProperty("NuevoHobbie");
            }
        }

        private bool isSuccess;

        public bool IsSuccess
        {
            get { return isSuccess; }
            set
            {
                isSuccess = value; OnSetProperty("IsSuccess"); }
        }
        private string mensajeErrorHobbie;

        public string MensajeErrorHobbie
        {
            get { return mensajeErrorHobbie; }
            set { OnSetProperty("MensajeErrorHobbie"); }
        }
        private bool errorHobbie;

        public bool ErrorHobbie
        {
            get { return errorHobbie; }
            set { OnSetProperty("ErrorHobbie"); }
        }
        public ICommand AgregarHobbieCommand { get; set; }
        public ICommand GuardarPerfilCommand { get; set; }
        public ObservableCollection<string> ListaEstados { get; set; }
        #endregion
        #region Metodos
        public PerfilUsuarioViewModel()
        {
            LlenarEstadosCiudades();
            AgregarHobbieCommand=new Command(AgregarHobbie);
            GuardarPerfilCommand = new Command(GuardarPerfil);
        }

        private void GuardarPerfil()
        {
            if (ValidarDatos())
            {
                IsSuccess = true;
            }
        }

        private bool ValidarDatos()
        {
            bool datosValidos=true;
            if (string.IsNullOrWhiteSpace(Usuario.Nombre))
            {
                Usuario.ErrorUsuario = true;
                Usuario.MensajeErrorUsuario = "Nombre, es obligatorio";
                datosValidos = false;
            }
            else
            {
                Usuario.ErrorUsuario = false;
                Usuario.MensajeErrorUsuario = "";
            }
            if (string.IsNullOrWhiteSpace(Usuario.Apellidos))
            {
                Usuario.ErrorApellidos = true;
                Usuario.MensajeErrorApellidos = "Apellidos, es obligatorio";
                datosValidos = false;
            }
            else
            {
                Usuario.ErrorApellidos = false;
                Usuario.MensajeErrorApellidos = "";
            }
            if (string.IsNullOrWhiteSpace(Usuario.Nick))
            {
                Usuario.ErrorNick = true;
                Usuario.MensajeErrorNick = "Apellidos, es obligatorio";
                datosValidos = false;
            }
            else
            {
                Usuario.ErrorNick = false;
                Usuario.MensajeErrorNick = "";
            }
            if (string.IsNullOrWhiteSpace(Usuario.Pass))
            {
                Usuario.ErrorPass = true;
                Usuario.MensajeErrorPass = "Apellidos, es obligatorio";
                datosValidos = false;
            }
            else
            {
                Usuario.ErrorPass = false;
                Usuario.MensajeErrorPass = "";
            }

            return datosValidos;
        }

        private void AgregarHobbie()
        {
            if (!string.IsNullOrEmpty(nuevoHobbie))
            {
                MensajeErrorHobbie = "";
                ErrorHobbie = false;                
                usuario.Hobbies.Add(new DtoHobbie { Nombre = nuevoHobbie });
                NuevoHobbie = "";
            }
            else
            {
                MensajeErrorHobbie = "No agregaste un hobbie";
                ErrorHobbie = true;
            }
        }

        private void LlenarEstadosCiudades()
        {
            ListaEstados=new ObservableCollection<string>
            {
                "Guanajuato","Guerrero","Hidalgo","Jalisco","México","Michoacán","Morelos","Nayarit","Nuevo León","Oaxaca","Puebla"
            };
        }

        #endregion
        #region Eventos INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnSetProperty(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }
}
