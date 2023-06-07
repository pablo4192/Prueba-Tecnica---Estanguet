using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngematicaAppTest.Business;
using IngematicaAppTest.Model;

namespace IngematicaAppTest.Service
{
    public partial class CalculoService
    {
        /// <summary>
        /// Instancia objeto CalculoBussines llamando al metodo Calcular del mismo, obteniendo asi dias de demora y fecha de llegada
        /// </summary>
        /// <param name="localidad"></param>
        /// <param name="tipoTransporte"></param>
        /// <param name="fechaInicial"></param>
        /// <param name="tipoCamino"></param>
        /// <returns> Diccionario con los dias de demora y fecha de llegada en tipo string </returns>
        public static Dictionary<string, string> CalcularLlegada(LocalidadModel localidad, TipoTransporteModel tipoTransporte, DateTime fechaInicial, string tipoCamino)
        {
            CalculoBusiness calculoBusiness = new CalculoBusiness(localidad, tipoTransporte, fechaInicial, tipoCamino);
            return calculoBusiness.Calcular();
        }
    }
}
