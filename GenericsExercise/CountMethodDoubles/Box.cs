﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise
{
    public class Box<T> where T: IComparable
    {
        public Box(List<T> value)
        {
            this.Values = value;
        }
        public List<T> Values { get; set; }

       // public override string ToString()
       // {
       //     StringBuilder sb = new StringBuilder();
       //     foreach (var item in this.Values)
       //     {
       //         sb.AppendLine($"{item.GetType()}: {item}");
       //     }
       //     return sb.ToString().TrimEnd();
       // }
        public void Swap(List<T> items, int firstIndex, int secondIndex)
        {
            T tembValue = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tembValue;
        }
        public int CountGreaterElements(List<T>elements,T elementToCompare)
        {
            int counter = 0;
            foreach (var element in elements)
            {
                if (elementToCompare.CompareTo(element)<0)
                {
                    counter++;
                }
            }
            return counter;
        }





    }

}
