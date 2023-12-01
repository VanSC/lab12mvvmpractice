using lab12mvvmpractice.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace lab12mvvmpractice.ViewModels
{
    internal class FormularioViewModel : ViewModelBase
    {
        //propiedades
        string titulo;
        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (titulo != value)
                {
                    titulo = value;
                    OnPropertyChanged();
                }
            }
        }

        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (descripcion != value)
                {
                    descripcion = value;
                    OnPropertyChanged();
                }
            }
        }

        string status;
        public string Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        //comandos
        public ICommand Guardar { protected set; get; }

        public ICommand Listar { protected set; get; }
    }
}
