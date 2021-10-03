using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestArrayListCollection();
            //TestSortedListCollection();
            //TestDictionaryCollection();
            TestReferenceTypeInList();
            Console.Read();
        }
        public static void TestArrayListCollection()
        {

            //object initializer
            var obj = new ArrayList() { 23, "abc" };

            //int number = 10;
            // adding elements using ArrayList.Add() method
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            //arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            // arlist1.Add(null);
            arlist1.Add("Test");
            arlist1.AddRange(obj);
            Console.WriteLine("number of elements present :" + arlist1.Count);


            Console.WriteLine("Iterating over arraylist elements");

            foreach (var element in arlist1)
            {
                Console.WriteLine(element);
            }
            //arlist1.Sort();
            //Console.WriteLine("\nAfter sorting");
            arlist1.RemoveAt(2);
            Console.WriteLine("\nAfter remove");
            arlist1.RemoveRange(4, 2);
            foreach (var element in arlist1)
            {
                Console.WriteLine(element);
            }
            arlist1.Clear();
            Console.WriteLine("number of elements present :" + arlist1.Count);
        }

        public static void TestSortedListCollection()
        {
            try
            {
                //SortedList of int keys, string values 
                SortedList<int, string> numberNames = new SortedList<int, string>();
                numberNames.Add(3, "Three");
                numberNames.Add(1, "One");
                numberNames.Add(2, "Two");
                numberNames.Add(4, null);
                numberNames.Add(10, "Ten");
                numberNames.Add(5, "Five");

                //The following will throw exceptions
                //numberNames.Add("Three", 3); //Compile-time error: key must be int type
                //numberNames.Add(1, "One"); //Run-time exception: duplicate key
                //numberNames.Add(null, "Five");//Run-time exception: key cannot be null

                //Inserting "TWO" in the key value '1' in the array list
                numberNames[1] = "TWO";
                Console.WriteLine("Iterating over SortedList collection numberNames");
                foreach (KeyValuePair<int, string> kvp in numberNames)
                    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
                //Creating a SortedList of string keys, string values 
                //using collection-initializer syntax
                SortedList<string, string> cities = new SortedList<string, string>()
                {
                    { "London", "UK" }, { "New York", "USA" }, { "Mumbai", "India" }, { "Johannesburg", "South Africa" }
                };
                Console.WriteLine("Iterating over cities");
                foreach (KeyValuePair<string, string> kvp in cities)
                    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        public static void TestDictionaryCollection()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            numberNames.Add(1, "four"); //System.ArgumentException: 'An item with the same key has already been added.'


        }
        public static void TestReferenceTypeInList()
        {
            //primitive type collection
            List<int> list = new List<int>()
            {
                1,34,67
            };

            //non-primitive or reference type collection
            List<Student> student = new List<Student>()
            {
                new Student() { FName = "Ashiq", LName = "Shaik", Address = "Vijayawada", PhoneNumber = "8074334664" },
                new Student() { FName = "Ameer", LName = "Shaik", Address = "Vijayawada", PhoneNumber = "7013665324" },
                new Student() { FName = "Dilshad", LName = "Shaik", Address = "Vijayawada", PhoneNumber = "9959189632" },
            };
            Console.WriteLine("Displaying elements from primitive list collection");
            foreach (int number in list)
            {
                Console.Write("\t" + number);
            }
            Console.WriteLine("\nDisplaying elements from student list");
            foreach (Student st in student)
            {
                Console.WriteLine("Student Details: ---> FirstName:" + st.FName+"Last Name "+ st.LName+"Address"+st.Address+"Phone Number"+st.PhoneNumber+" ");
            }
        }
    }
}
