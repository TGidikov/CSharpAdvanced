﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.count = 0;
            this.items = new int[initialCapacity];
        }
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        public void Push(int element)
        {
            if (this.items.Length==this.count)
            {
                var nextItems = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    nextItems[i] = this.items[i];
                }
                this.items = nextItems;
            }
            this.items[this.count] = element;
            count++;
        }
        public int Pop()
        {
            if (this.items.Length==0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            var index = this.count - 1;
            var last = this.items[index];
            this.count--;
            return last;
        }
        public int Peek()
        {
            if (items.Length<=0)
            {
                throw new InvalidOperationException("No elemeents in CustomStack!");
            }
            else
            {
                return this.items[count-1];
            }
        }
        public void ForEach(Action<object>action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }


    }
}
