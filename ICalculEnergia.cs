using System;
namespace EcoEnergyProject
{
    public interface ICalculEnergia
    {
        bool CheckParameter(double horesDeSol);
        double CalculateEnergy(double horesDeSol);
        void ShowInfo();
    }
}