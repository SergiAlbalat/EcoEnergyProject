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
        public string GetTipus() => Tipus;
        public double GetEnergia() => Energia;
        public DateTime GetData() => Data;
    }
}