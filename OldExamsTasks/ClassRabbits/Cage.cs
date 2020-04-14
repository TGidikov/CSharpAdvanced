using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        public List<Rabbit> data;

        public Cage()
        {
            this.data = new List<Rabbit>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;
        public Cage(string name, int capacity) : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }


        public void Add(Rabbit rabbit)
        {
          if (this.data.Count + 1 <= this.Capacity)
             {
                 this.data.Add(rabbit);
             }
        }   

        public bool RemoveRabbit(string name)
        {
            Rabbit rabit = this.data.FirstOrDefault(n => n.Name == name);
            if (rabit != null)
            {
                this.data.Remove(rabit);
                return true;
            }
            return false;
        }
        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(r => r.Species == species);
            
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit target = this.data.FirstOrDefault(x => x.Name == name);
            if (target!=null)
            {
                target.Available = false;
                
            }
           
            return target;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabits = this.data.Where(r => r.Species == species).ToArray();
            
                foreach (var rabit in rabits)
                {
                    rabit.Available = false;
                }

            
            return rabits;

        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabit in data)
            {
                if (rabit.Available)
                {
                    sb.AppendLine(rabit.ToString());
                }             
            }
            return sb.ToString().TrimEnd();
        }
    }
}
