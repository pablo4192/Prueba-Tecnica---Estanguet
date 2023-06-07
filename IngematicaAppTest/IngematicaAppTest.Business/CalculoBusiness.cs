using IngematicaAppTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IngematicaAppTest.Business
{
    public partial class CalculoBusiness
    {
        private LocalidadModel localidad;
        private TipoTransporteModel tipoTransporte;
        private DateTime fechaInicial;
        private string tipoCamino;

        public CalculoBusiness()
        {

        }

        public CalculoBusiness(LocalidadModel localidad, TipoTransporteModel tipoTransporte, DateTime fechaInicial, string tipoCamino)
        {
            this.localidad = localidad;
            this.tipoTransporte = tipoTransporte;
            this.fechaInicial = fechaInicial;
            this.tipoCamino = tipoCamino;
        }

        /// <summary>
        /// Calcula el valor total de la demora
        /// </summary>
        /// <returns> Diccionario con los dias de demora y fecha de llegada en tipo string </returns>
        public Dictionary<string, string> Calcular()
        {
            return this.CalcularDias();
        }

        /// <summary>
        /// Calcula dias de demora
        /// </summary>
        /// <returns> Diccionario con los dias de demora y fecha de llegada en tipo string </returns>
        private Dictionary<string, string> CalcularDias()
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            DateTime fechaAcumulada = this.fechaInicial;
            
            decimal diasTotalesDemora = this.CalcularPorCoeficiente();
            int condicion = (int) diasTotalesDemora;

            decimal parteDecimal = diasTotalesDemora - (int) diasTotalesDemora;

            do
            {
                if (fechaAcumulada.DayOfWeek != DayOfWeek.Saturday && fechaAcumulada.DayOfWeek != DayOfWeek.Sunday)
                {
                    condicion--;
                }

                if (fechaAcumulada.DayOfWeek == DayOfWeek.Friday)
                {
                    fechaAcumulada = fechaAcumulada.AddDays(3);
                }
                else
                {
                    fechaAcumulada = fechaAcumulada.AddDays(1);
                }

            } while (condicion > 0);

            fechaAcumulada = fechaAcumulada.AddDays((double) parteDecimal);

            resultado.Add("dias_demora", diasTotalesDemora.ToString());
            resultado.Add("fecha_llegada", $"{fechaAcumulada}hs");

            return resultado;
            
        }

        /// <summary>
        /// Calcula la demora por el coeficiente de demora del tipo de transporte y suma al resultado porcentaje de demora por tipo de camino
        /// </summary>
        /// <returns> Resultado de la operacion en valor decimal </returns>
        private decimal CalcularPorCoeficiente()
        {
            decimal demoraPorCoeficiente = this.localidad.DiasDemora * this.tipoTransporte.CoeficineteDemora;
            
            return this.CalcularPorCamino(demoraPorCoeficiente);
        }

        /// <summary>
        /// Calcula la demora por el tipo de camino escogido
        /// </summary>
        /// <param name="demoraPorCoeficiente"></param>
        /// <returns> Resultado de la operacion en valor decimal </returns>
        private decimal CalcularPorCamino(decimal demoraPorCoeficiente)
        {
            if(this.tipoCamino == "ruta")
            {
                return demoraPorCoeficiente * (decimal) 1.1;
            }

            return demoraPorCoeficiente;
        }
    }
}
