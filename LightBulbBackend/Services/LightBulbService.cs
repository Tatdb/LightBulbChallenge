using LightBulbBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBulbBackend.Services
{
    public class LightBulbService : ILightBulbService
    {
        public Results Calculate(int numOfPeople, int bulbs)
        {
            bool[] numOfBulbs = new bool[bulbs + 1]; 


            for (int i = 1; i <= numOfPeople; i++)
            {
                for (int j = i; j < numOfBulbs.Length; j = j + i)
                {
                    if ((j % i) == 0)
                    {
                        numOfBulbs[j] = !numOfBulbs[j];
                    }
                }
            }

            int numOfBulbsOn = 0;
            List<int> list = new List<int>();

            for (int i = 1; i < numOfBulbs.Length; i++)
            {
                if (numOfBulbs[i])
                {
                    numOfBulbsOn++;
                    list.Add(i);
                }
            }


            Results results = new Results
            {
                NumberOfBulbsOn = numOfBulbsOn,
                BulbNumbers = list                
            };

            return results;
        }
    }
}
