using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        private  HashSet<Fish> fishInPool;

        public Aquarium()
        {
            this.fishInPool = new HashSet<Fish>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Size { get; set; }
        public Aquarium(string name,int capacity,int size):this()
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
        }
        public void Add(Fish fish)
        {
            Fish fishNameCheck = fishInPool.FirstOrDefault(f => f.Name == fish.Name);
            if (fishInPool.Count+1<=this.Capacity && fishNameCheck==null)
            {
                fishInPool.Add(fish);
            }
        }
        public bool Remove(string name)
        {

            Fish fishNameCheck = fishInPool.FirstOrDefault(f => f.Name == name);
            if (fishNameCheck!=null)
            {
                fishInPool.Remove(fishNameCheck);
                return true;
            }
            return false;
        }
        public Fish FindFish(string name)
        {
            return fishInPool.FirstOrDefault(f => f.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Aquarium: {this.Name} ^ Size: {this.Size}");
            foreach (var fish in fishInPool)
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
