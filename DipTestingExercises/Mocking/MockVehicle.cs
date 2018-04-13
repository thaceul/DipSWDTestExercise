using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises.Mocking
{
    public class MockVehicle : MotorVehicle
    {
        public MockVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM) : base(pDriver, pMax, pCurrent, pLitresPerKM)
        {

        }
    }
}
