using System;
namespace EcoEnergyProject
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public double CabalAigua {  get; set; }
        public SistemaHidroelectric(double cabalAigua)
        {
            if (CheckParameter(cabalAigua))
            {
                throw new ArgumentOutOfRangeException();
            }
            Type = "Sistema Hidroelectric";
            CabalAigua = cabalAigua;
            Energy = CalculateEnergy();
            Date = DateTime.Now;
            SimulationCount++;
        }
        public SistemaHidroelectric() : this(DefaultParameter) { }
        public bool CheckParameter(double cabalAigua) => cabalAigua > 20;
        public double CalculateEnergy() => CabalAigua * 9.8 * 0.8;
        public void ShowInfo()
        {
            Console.WriteLine($"Tipus de Energia\tCabal d'Aigua:\tEnergia Generada:\tData:\n{Type}\t{CabalAigua}m3\t{Energy}Kb\t{Date}");
        }
    }
}