using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoEnergyProject
{
    public class SistemaEolic : SistemaEnergia, ICalculEnergia
    {
        public double VelocitatVent { get; set; }
        public SistemaEolic(double velocitatVent)
        {
            if (!CheckParameter(velocitatVent))
            {
                throw new ArgumentOutOfRangeException();
            }
            Type = "Sistema Eolic";
            VelocitatVent = velocitatVent;
            Energy = CalculateEnergy();
            Date = DateTime.Now;
            SimulationCount++;
        }
        public SistemaEolic() : this(DefaultParameter) { }
        public bool CheckParameter(double velocitatVent) => velocitatVent > 5;
        public double CalculateEnergy() => Math.Pow(VelocitatVent,3)*0.2;
        public void ShowInfo()
        {
            Console.WriteLine($"Tipus de Energia\tVelocitat del vent:\tEnergia Generada:\tData:\n{Type}\t{VelocitatVent}m/s\t{Energy}Kb\t{Date}");
        }
    }
}