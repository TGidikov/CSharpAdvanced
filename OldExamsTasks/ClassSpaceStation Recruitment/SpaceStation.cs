using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    class SpaceStation
    {
        public List<Astronaut> data;
        public SpaceStation()
        {
            this.data = new List<Astronaut>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => data.Count;
        public SpaceStation(string name,int capacity):this()
        {
            this.Name = name;
            this.Capacity = capacity;

        }
        public void Add(Astronaut astronaut)
        {
            if (data.Count+1<=Capacity)
            {
                data.Add(astronaut);
            }
        }
        public bool Remove(string name)
        { 
             Astronaut astronaut=   data.FirstOrDefault(n => n.Name == name);
            if (astronaut!=null)
            {
                this.data.Remove(astronaut);
                return true;
            }
            return false;           
        }
        public Astronaut GetOldestAstronaut()
        {
            
            return this.data.OrderByDescending(a => a.Age).FirstOrDefault();
        }
        public Astronaut GetAstronaut(string name)
        {
           return this.data.FirstOrDefault(n => n.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astronaut in data)
            {
                sb.AppendLine(astronaut.ToString());
            }
            return sb.ToString().TrimEnd();

          // "Astronauts working at Space Station {spaceStationName}:
          //  { Astronaut1}
          // { Astronaut2}
          // (…)"
          //
        }




    }
}
