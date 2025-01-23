using System;
namespace EcoEnergyProject
{
    public abstract class SistemaEnergia
    {
        protected string Tipus { get; set; }
        protected double Energia { get; set; }
        protected DateTime Data { get; set; }
        public static int ContadorSimulacions = 0;
        protected static double ParametrePerDefecte = 20.0d;
        protected static string ErrorForaRang = "L'argument es troba fora de rang";

        /// <summary>
        /// Dona el contingut del atribut Tipus
        /// </summary>
        /// <returns>Constingut de Tipus</returns>
        public string GetTipus() => Tipus;

        /// <summary>
        /// Dona el contingut del atribut Energia
        /// </summary>
        /// <returns>Contingut de Energia</returns>
        public double GetEnergia() => Energia;

        /// <summary>
        /// Dona el contingut del atribut Data
        /// </summary>
        /// <returns>Contingut de Data</returns>
        public DateTime GetData() => Data;
    }
}