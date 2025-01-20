using System;
namespace EcoEnergyProject
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public SistemaSolar(double horesDeSol)
        {
            if(CheckParameter(horesDeSol))
            {
                Type = "Sistema Solar";
                Energy = CalculateEnergy(horesDeSol);
                Date = DateTime.Now;
            }
        }
        public bool CheckParameter(double horesDeSol) => horesDeSol > 1;
        public double CalculateEnergy(double horesDeSol) => horesDeSol * 1.5;
        public void ShowInfo()
        {
            Console.WriteLine($"Tipus de Energia\tEnergia Generada:\tData:\n{Type}\t{Energy}\t{Date}");
        }
    }
}