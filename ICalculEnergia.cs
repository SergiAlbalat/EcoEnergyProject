using System;
namespace EcoEnergyProject
{
    public interface ICalculEnergia
    {
        bool ComprovarParametre(double argument);
        double CalcularEnergia();
        void MostrarInformacio();
    }
}