﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArraysPractice
    {
        public static void Main(string[] args)
        {
            //char[] word = { 'H', 'e', 'l', 'l', 'o' };
            //char[] result = ReverseMethod1(word);
            //char[] result = ReverseMethod2(word);
            //int[] number = { 1, 2, 3, 4, 5, 6 };
            //int[] checkNumber = CheckGivenElement(number);
            //CheckGivenElement2(number);
            //int hashPractice = HashtablePractice(number);
            //bool isExist = CheckIsDuplicated3(number);

            int n = 12345;
            int left = n;
            int rev = 0;
            int result = 0;
            while (left > 0)
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10);
            }
            result = rev;
        }

        //For loop O(n/2) version
        public static char[] ReverseMethod1(char[] word)
        {
            if (word != null)
                for (int i = 0; i < word.Length / 2; i++)
                {
                    char temp = word[i];
                    word[i] = word[word.Length - i - 1];
                    word[word.Length - i - 1] = temp;
                }
            return word;
        }

        //public static int ReverseMethod_int(int data)
        //{
        //    if (data != null)
        //        for (int i = 0; i < data / 2; i++)
        //        {
        //            char temp = data[i];
        //            data[i] = data[data - i - 1];
        //            data[data.Length - i - 1] = temp;
        //        }
        //    return data;
        //}

        //For loop O(n) version
        public static char[] ReverseMethod2(char[] word)
        {
            char[] result = new char[5];
            if (word != null)
                for (int i = 0; i < word.Length; i++)
                {
                    result[word.Length - i - 1] = word[i];
                }
            return result;
        }

        //While loop version
        public static char[] ReverseMethod3(char[] word)
        {
            int i = 0;
            int y = word.Length - 1;
            if (word != null)
                while (y > i)
                {
                    char temp = word[i];
                    word[i] = word[y];
                    word[y] = temp;
                    y--;
                    i++;
                }
            return word;
        }

        //Check if contains duplicated element.
        //O(n*n) version
        public static int[] CheckGivenElement(int[] number)
        {
            bool isExist = false;
            int counter = 1;
            if (number != null)
                for (int i = 0; i < number.Length; i++)
                {
                    for (int j = 0; j < counter; j++)
                    {
                        if (number[i] == number[j])
                            isExist = true;
                    }
                    if (!isExist)
                    {
                        number[counter] = number[i];
                        counter++;
                    }
                    isExist = false;
                }
            int[] newArr = new int[counter];
            System.Array.Copy(number, newArr, counter);
            return newArr;
        }

        //Check if contains duplicated element.
        //O(n) version
        public static void CheckGivenElement2(string[] number)
        {
            int counter = 0;
            bool isExist = false;
            Hashtable hashTable = new Hashtable();
            if (number != null)
                for (int i = 0; i < number.Length - 1; i++)
                {
                    try
                    {
                        hashTable.Add(number[i], i);
                    }
                    catch (Exception)
                    {
                        hashTable.Remove(number[i]);
                    }
                }
        }

        public static int HashtablePractice(int[] number)
        {
            int Count = 0;
            int Length = number.Length;
            Hashtable h = new Hashtable();
            try
            {
                for (int i = 0; i < Length; i++)

                {
                    Count++;
                    h.Add(number[i], Count);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ArrayofInt[i]");
            }
            return -1;
        }

        public static bool CheckIsDuplicated3(int[] number)
        {
            if (number == null)
                return false;
            var hashSet = new HashSet<int>();
            for (int i = 0; i < number.Length; i++)
            {
                if (hashSet.Contains(number[i]))
                    return false;
                hashSet.Add(number[i]);
            }
            return true;
        }
    }
}