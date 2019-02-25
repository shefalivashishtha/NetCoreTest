using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PracticeApp
{
    class Program
    {
        private int _number;
        static void Main(string[] args)
        {

            Program obj = new Program();


            Console.Write("Enter number of test cases");
            int x = Convert.ToInt32(Console.ReadLine());

            #region Element with left side smaller and right side greater

            //int iSize = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[iSize];

            //Console.WriteLine("enter array numbers");
            //for (int i = 0; i < iSize; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int iResult = 0;
            //int checkCount = 0;
            //for (int i = 1; i < iSize; i++)
            //{
            //    for(int k=i-1;k>=0;k--)
            //    {
            //        if (arr[k] < arr[i])
            //        {
            //            iResult = i;
            //            checkCount = 0;

            //        }
            //        else
            //        {
            //            checkCount++;
            //            break;
            //        }
            //    }

            //    if (checkCount == 0)
            //    {
            //        for (int j = i + 1; j < iSize; j++)
            //        {
            //            if (arr[i] < arr[j])
            //            {
            //                iResult = i;
            //                checkCount = 0;

            //            }
            //            else
            //            {
            //                checkCount++;
            //                break;
            //            }
            //        }
            //    }
                   

            //    if (checkCount == 0)
            //    {
            //        iResult = i;
            //        break;
            //    }
            //}

            //Console.WriteLine("required number is: " + arr[iResult]);

            #endregion
            
            #region Stock buy and sell

            //Console.WriteLine("Enter array size");
            //int iSize = Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[iSize];

            //Console.WriteLine("enter array numbers");
            //for(int i=0;i<iSize;i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int iEnd = 0;
            //int iStart = 0;

            //for(int i=0;i<iSize-1;i++)
            //{
            //    if (arr[i] > arr[i + 1])
            //    {
            //        if (iStart != iEnd)
            //        {
            //            Console.WriteLine("(" + (iStart + 1) + "," + (i + 1) + ")");
            //        }

            //        iStart = i + 1;

            //    }
            //    else
            //    {
            //        iEnd = i + 1;
            //        if (i == iSize - 2)
            //        {
            //            Console.WriteLine("(" + (iStart + 1) + "," + (iEnd+1) + ")");
            //        }
            //    }

            //}

            //Console.WriteLine("finished");

            #endregion

            #region for minimum platform

            //Console.Write("Enter Number of Trains");
            //int iTrains = Convert.ToInt32(Console.ReadLine());
            //int[] arrTrains = new int[iTrains];
            //int[] arrTrainsDept = new int[iTrains];



            //for(int i=0;i<iTrains;i++)
            //{
            //    Console.WriteLine("Enter Arrival Time");
            //    arrTrains[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter Departure Time");
            //    arrTrainsDept[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Array.Sort(arrTrains);
            //Array.Sort(arrTrainsDept);

            //int count = 0;
            //int result = 0;
            //for(int i=1,j=0;i<iTrains && j<iTrains;i++,j++)
            //{
            //    if (arrTrains[i] < arrTrainsDept[j])
            //    {
            //        count++;
            //        if (count > result)
            //        {
            //            result = count;
            //        }
            //    }
            //    else
            //    {
            //        count--;
            //    }
            // //   }
            //}

            //Console.WriteLine("Number of minimum platforms : " + result);

            #endregion

            #region operator overloading
            //Program obj2 = new Program();
            //obj._number = 4;
            //obj2._number = 3;
            //var x = obj + obj2;
            #endregion

            #region Politeness of array

            //Console.WriteLine("Input Number");
            //string iNumber = Console.ReadLine();

            //int iPoliteness = obj.CountOddPrimefactors(Convert.ToInt32(iNumber)) - 1;
            //Console.WriteLine("Politeness of " + iNumber + " is " + iPoliteness);

            #endregion

            Console.ReadKey();
        }
        }
        }
