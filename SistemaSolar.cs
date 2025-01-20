using System;
namespace EcoEnergyProject
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public double HoresDeSol {  get; set; }
        public SistemaSolar(double horesDeSol)
        {
            if(CheckParameter())
            {
                Type = "Sistema Solar";
                HoresDeSol = horesDeSol;
                Energy = CalculateEnergy();
                Date = DateTime.Now;
            }
        }
        public bool CheckParameter() => HoresDeSol > 1;
        public double CalculateEnergy() => HoresDeSol * 1.5;
        public void ShowInfo()
        {
            Console.WriteLine($"Tipus de Energia\tHores de Sol:\tEnergia Generada:\tData:\n{Type}\t{HoresDeSol}\t{Energy}Kb\t{Date}");
        }
    }
}