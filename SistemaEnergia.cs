using System;
namespace EcoEnergyProject
{
    public abstract class SistemaEnergia
    {
        protected string Type { get; set; }
        protected double Energy { get; set; }
        protected DateTime Date { get; set; }
        protected static int SimulationCount = 0;
        protected static double DefaultParameter = 20.0d;
    }
}