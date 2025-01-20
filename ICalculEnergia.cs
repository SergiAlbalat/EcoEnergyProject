using System;
namespace EcoEnergyProject
{
    public interface ICalculEnergia
    {
        bool CheckParameter();
        double CalculateEnergy();
        void ShowInfo();
    }
}