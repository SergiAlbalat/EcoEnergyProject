using System;
namespace EcoEnergyProject
{
    public interface ICalculEnergia
    {
        bool CheckParameter(double argument);
        double CalculateEnergy();
        void ShowInfo();
    }
}