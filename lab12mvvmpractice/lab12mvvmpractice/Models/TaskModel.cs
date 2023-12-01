using System;
using System.Collections.Generic;
using System.Text;

namespace lab12mvvmpractice.Models
{
    public class TaskModel
    {
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string status { get; set;}

        public TaskModel() { }
    }
}
