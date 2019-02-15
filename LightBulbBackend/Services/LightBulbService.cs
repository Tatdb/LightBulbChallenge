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
                List<int> list = new List<int>();
                double bulbNumber = 0;

                if (numOfPeople >= bulbs)
                {
                    for (int i = 1; i < numOfBulbs.Length; i++)
                    {
                        bulbNumber = Math.Pow(i, 2);
                        if (bulbNumber <= numOfBulbs.Length - 1)
                            list.Add(int.Parse(bulbNumber.ToString()));
                        else
                            break;
                    }
                }
                else
                {

                    for (int i = 1; i <= numOfPeople; i++)
                    {
                        for (int j = i; j < numOfBulbs.Length; j = j + i)
                        {
                            numOfBulbs[j] = !numOfBulbs[j];
                            if (numOfBulbs[j])
                                list.Add(j);
                            else
                                list.Remove(j);
                        }

                    }
                }

                return new Results
                {
                    NumberOfBulbsOn = list.Count(),
                    BulbNumbers = list
                };
        }
    }
}