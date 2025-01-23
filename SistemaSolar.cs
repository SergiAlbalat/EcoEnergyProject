using System;
namespace EcoEnergyProject
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public double HoresDeSol {  get; set; }
        public SistemaSolar(double horesDeSol)
        {
            if(!ComprovarParametre(horesDeSol))
            {
                throw new ArgumentOutOfRangeException(ErrorForaRang);
            }
            Tipus = "Solar";
            HoresDeSol = horesDeSol;
            Energia = CalcularEnergia();
            Data = DateTime.Now;
            ContadorSimulacions++;
        }
        public SistemaSolar() : this(ParametrePerDefecte) { }
        public bool ComprovarParametre(double horesDeSol) => horesDeSol >= 1;
        public double CalcularEnergia() => Math.Round(HoresDeSol * 1.5,4);
        public void MostrarInformacio()
        {
            Console.WriteLine($"Tipus de Energia\tHores de Sol:\tEnergia Generada:\tData:\n{Tipus}\t{HoresDeSol}\t{Energia}Kb\t{Data}");
        }
    }
}