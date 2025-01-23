using System;
namespace EcoEnergyProject
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public double CabalAigua {  get; set; }
        public SistemaHidroelectric(double cabalAigua)
        {
            if (!ComprovarParametre(cabalAigua))
            {
                throw new ArgumentOutOfRangeException(ErrorForaRang);
            }
            Tipus = "Hidro";
            CabalAigua = cabalAigua;
            Energia = CalcularEnergia();
            Data = DateTime.Now;
            ContadorSimulacions++;
        }
        public SistemaHidroelectric() : this(ParametrePerDefecte) { }
        public bool ComprovarParametre(double cabalAigua) => cabalAigua > 20;
        public double CalcularEnergia() => Math.Round(CabalAigua * 9.8 * 0.8,4);
        public void MostrarInformacio()
        {
            Console.WriteLine($"Tipus de Energia\tCabal d'Aigua:\tEnergia Generada:\tData:\n{Tipus}\t{CabalAigua}m3\t{Energia}Kb\t{Data}");
        }
    }
}