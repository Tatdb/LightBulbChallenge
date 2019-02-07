using LightBulbBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LightBulbBackend.Services
{
    public interface ILightBulbService
    {
        Results Calculate(int numOfPeople, int bulbs);
    }
}
