﻿using System;
namespace EcoEnergyProject
{
    public abstract class SistemaEnergia
    {
        protected string Type { get; set; }
        protected double Energy { get; set; }
        protected DateTime Date { get; set; }
    }
}