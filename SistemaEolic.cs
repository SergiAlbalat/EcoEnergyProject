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
            if (!ComprovarParametre(velocitatVent))
            {
                throw new ArgumentOutOfRangeException(ErrorForaRang);
            }
            Tipus = "Eolic";
            VelocitatVent = velocitatVent;
            Energia = CalcularEnergia();
            Data = DateTime.Now;
            ContadorSimulacions++;
        }
        public SistemaEolic() : this(ParametrePerDefecte) { }
        public bool ComprovarParametre(double velocitatVent) => velocitatVent > 5;
        public double CalcularEnergia() => Math.Round(Math.Pow(VelocitatVent,3)*0.2,4);
        public void MostrarInformacio()
        {
            Console.WriteLine($"Tipus de Energia\tVelocitat del vent:\tEnergia Generada:\tData:\n{Tipus}\t{VelocitatVent}m/s\t{Energia}Kb\t{Data}");
        }
    }
}