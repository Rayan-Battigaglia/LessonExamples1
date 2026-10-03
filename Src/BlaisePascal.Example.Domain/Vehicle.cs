using System;
using System.Collections.Generic;
using System.Text;

// import (librerie di default)

namespace BlaisePascal.Example.Domain
{
    // internal: pubblica all'interno del name space
    public class Vehicle // Visible dal main
    {
        private int _id; // _ --> privato
        private string _licensePlate;
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;


        public string GetLicensePlate()
        {
            return _licensePlate;
        }

    }
}
