using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ServicioPrestado
    {
        public int idServicioPrestado { get; set; }
        public Double valorMomento { get; set; }
        public string nombreServicio { get; set; }
        public string descripcionServicio { get; set; }

        public ServicioPrestado(Servicio servicio)
        {
            valorMomento = servicio.valorServicio;
            nombreServicio = servicio.nombreServicio;
            descripcionServicio = servicio.descripcionServicio;
        }

    }
}
