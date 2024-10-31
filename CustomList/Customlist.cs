using Microsoft.VisualBasic;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    internal class Customlist<T>
    {
        T[] Items= new T[4];

   

        public int length;
        
        public T this[int i]
        { get { return Items[i]; } set { Items[i] = value; }
           
        
        }
     

        public void Add(T a)
        {
            int oldsize = Items.Length; 
            if (Items[Items.Length - 1] != null)
            {
                Array.Resize(ref Items, oldsize+1);
            }
            
            for (int i = 0; i < Items.Length; i++)
            {

                if (Items[i] ==null)     
                {
                   
                    Items[i] = a;
                    if (i == oldsize)
                    {
                      Array.Resize(ref Items,oldsize*2);
                    }
                               
                    length=Items.Length;
                    break;

                }
                
            }
         
        }
            
        public T Find(Predicate<T> predicate)
        {
            T a=default;
            for (int i = 0;i<Items.Length-1;i++)
            {
                if (predicate(Items[i]))
                {
                    a = Items[i];

                    break;
                }
            }   
            return a; 
        }
        public T[] FindAll(Predicate<T> find)
        {
            T[] arr = new T[0] ;
           for (int i = 0;i<Items.Length-1 ;i++)
            {
                if (find(Items[i]))
                {
                    Array.Resize (ref arr, arr.Length+1);
                    arr[arr.Length-1] = Items[i];
                }
            }
           return arr;

        }
        public T FirstOrDefault(Predicate<T> predicate)
        {
            T a = default;
            for (int i = 0; i < Items.Length - 1; i++)
            {
                if (predicate(Items[i]))
                {
                    a = Items[i];

                    break;
                }
            }
            return a;

        }
        public bool Contains (Predicate<T> predicate)
        {
            bool contains= false;
            for (int i = 0;i < Items.Length - 1;i++) 
            {
                if (predicate(Items[i]))
                {
                    return contains= true;
                }

            }
            return contains;
        }
        public int FindIndex(Predicate<T> predicate)
        {
            int index=0;
            for (int i = 0;i<= Items.Length - 1;i++)
            {
                if (predicate(Items[i]))
                {
                    index= i; break;    
                }
            }
            return index;
        }


    }
}
