using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vehicle
    {
        public string Neme;
        public string RegNo;
        List<double> speeds = new List<double>();

        public Vehicle(string vehocleName, string regNo)
        {
            this.Neme=vehocleName;
            this.RegNo = regNo;
        }
        public double SetSpeed(double speed)
        {
            speeds.Add(speed);
            return speed;
        }
        public double MinSpeed()
        {
            double minSpeed = speeds.Min();
            return minSpeed;
        }
        public double MaxSpeed()
        {
            double maxSpeed = speeds.Max();
            return maxSpeed;
        }
        public double Avorage()
        {
            double avarage = speeds.Max();
            return avarage;
        }
       
    }
}
