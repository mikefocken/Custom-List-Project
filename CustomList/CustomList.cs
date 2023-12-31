﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;
        private object tempArray;

        public int Capacity { get { return capacity; } }
        public int Count { get { return count; } }

        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];

        }
        //Custom Indexer
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index]=value;

            }
        }
        public void Add(T item)
        //Member Methods (CAN DO)
        {       //'item' parameter should be added to internal 'items' array
                //if items array is at capacity, double capacity and create new array
                //transfer all items to new array
            items[count]=item;
            count++;

            if (count>=capacity)
            {
                capacity=capacity*2;
                T[] tempArray = new T[capacity];
            }
            
            

            for (int i = 1; i< items.Length; i++)
            {
                tempArray=items;

            }

            

        }


        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 

            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
