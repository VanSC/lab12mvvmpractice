using lab12mvvmpractice.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using lab12mvvmpractice.Models;
using Xamarin.Forms;

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

        //public List<string> MuchosDatos { protected set; get; }
        //los datos calculado no se agregan en el modelo pero si en el viewmodel
        //propiedad de listas

        ObservableCollection<TaskModel> task;
        public ObservableCollection<TaskModel> Tasks
        {
            get { return task; }
            set
            {
                if (task != value)
                {
                    task = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<TaskModel> TaskModels;
        public FormularioViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>();
            TaskModels = new List<TaskModel>();

            Guardar = new Command(() =>
            {
                TaskModel task = new TaskModel();
                task.titulo = this.Titulo;
                task.descripcion = this.Descripcion;
                task.status = this.Status;
                TaskModels.Add(task);
            });

            Listar = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(TaskModels);
            });
        }
    }
}
