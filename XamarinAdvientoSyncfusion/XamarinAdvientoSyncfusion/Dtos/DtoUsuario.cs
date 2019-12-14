using System.Collections.ObjectModel;
using System.ComponentModel;

namespace XamarinAdvientoSyncfusion.Dtos
{
    public class DtoUsuario: INotifyPropertyChanged
    {
        #region PropiedadesUsuario
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; OnSetProperty("Estado"); }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; OnSetProperty("Nombre"); }
        }
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; OnSetProperty("Apellidos"); }
        }

        private string nick;

        public string Nick
        {
            get { return nick; }
            set { nick = value; OnSetProperty("Nick"); }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; OnSetProperty("Pass"); }
        }

        private ObservableCollection<DtoHobbie> hobbies=new ObservableCollection<DtoHobbie>();

        public ObservableCollection<DtoHobbie> Hobbies
        {
            get { return hobbies; }
            set
            {hobbies = value; OnSetProperty("Hobbies"); }
        }

        #endregion

        #region ManejoDeErrores

        private string mensajeErrorUsuario;

        public string MensajeErrorUsuario
        {
            get { return mensajeErrorUsuario; }
            set { mensajeErrorUsuario = value; OnSetProperty("MensajeErrorUsuario"); }
        }

        private bool errorUsuario;

        public bool ErrorUsuario
        {
            get { return errorUsuario; }
            set { errorUsuario = value; OnSetProperty("ErrorUsuario"); }
        }
        private string mensajeErrorApellidos;

        public string MensajeErrorApellidos
        {
            get { return mensajeErrorUsuario; }
            set { mensajeErrorUsuario = value; OnSetProperty("MensajeErrorApellidos"); }
        }

        private bool errorApellidos;

        public bool ErrorApellidos
        {
            get { return errorApellidos; }
            set { errorApellidos = value; OnSetProperty("ErrorApellidos"); }
        }
        private string mensajeErrorNick;

        public string MensajeErrorNick
        {
            get { return mensajeErrorNick; }
            set { mensajeErrorNick = value; OnSetProperty("MensajeErrorNick"); }
        }

        private bool errorNick;

        public bool ErrorNick
        {
            get { return errorNick; }
            set { errorNick = value; OnSetProperty("ErrorNick"); }
        }
        private string mensajeErrorPass;

        public string MensajeErrorPass
        {
            get { return mensajeErrorPass; }
            set { mensajeErrorPass = value; OnSetProperty("MensajeErrorPass"); }
        }

        private bool errorPass;

        public bool ErrorPass
        {
            get { return errorPass; }
            set { errorPass = value; OnSetProperty("ErrorPass"); }
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
