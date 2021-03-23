using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            var listMembers = new List<Members>() ;
            var m1 = new Members(){
                firstName = "A",
                lastName = "Nguyen",
                gender = "Male",
                dateOfBirth = new DateTime(1997,05,01) ,
                phone = "012345678",
                birthPlace = "VP",
                age = 24,
                graduated = true,
                StartDate = new DateTime(2010,05,01),
                EndDate = new DateTime(2015,10,01)
            };
            var m2 = new Members(){
                firstName = "B",
                lastName = "Nguyen",
                gender = "Male",
                dateOfBirth = new DateTime(1996,05,01) ,
                phone = "012345678",
                birthPlace = "Ha Noi",
                age = 25,
                graduated = true,
                StartDate = new DateTime(2021,03,23),
                EndDate = new DateTime(2021,03,24)
            };
            var m3 = new Members(){
                firstName = "C",
                lastName = "Do",
                gender = "Female",
                dateOfBirth = new DateTime(2000,05,01) ,
                phone = "012345678",
                birthPlace = "HP",
                age = 21,
                graduated = true,
                StartDate = new DateTime(2013,05,01),
                EndDate = new DateTime(2018,10,01)
            };
            var m4 = new Members(){
                firstName = "D",
                lastName = "Tran",
                gender = "male",
                dateOfBirth = new DateTime(1997,05,06) ,
                phone = "012345678",
                birthPlace = "Ha Noi",
                age = 24,
                graduated = true,
                StartDate = new DateTime(2012,05,01),
                EndDate = new DateTime(2015,02,20)
            };
            var m5 = new Members(){
                firstName = "E",
                lastName = "Pham",
                gender = "Female",
                dateOfBirth = new DateTime(1998,04,20) ,
                phone = "012345678",
                birthPlace = "TPHCM",
                age = 23,
                graduated = true,
                StartDate = new DateTime(2018,05,01),
                EndDate = new DateTime(2021,02,20)
            };
            listMembers.Add(m1);
            listMembers.Add(m2);
            listMembers.Add(m3);
            listMembers.Add(m4);
            listMembers.Add(m5);
            //1.Return a list of members who is Male
            Console.WriteLine("1.Return a list of members who is Male");
            var maleList = new List<Members>();
            foreach(var mem in listMembers)
            {
                if (mem.gender.ToLower() == "male")
                {
                    maleList.Add(mem);
                    Console.WriteLine(mem.firstName + " " + mem.lastName);
                }
            }
            //2.Return the oldest one 
            Console.WriteLine("\n2.Return the oldest one ");
            TimeSpan maxTime = DateTime.Today - listMembers[0].dateOfBirth;
            foreach (var mem in listMembers)
            {
                if ((DateTime.Today - mem.dateOfBirth) > maxTime)
                {
                    maxTime = (DateTime.Today - mem.dateOfBirth);
                }
            }
            foreach (var mem in listMembers)
            {
                if ((DateTime.Today - mem.dateOfBirth) == maxTime)
                {
                    Console.WriteLine(mem.firstName + " " + mem.lastName + " is the oldest one");
                    break;
                }
            }
            //3. Return a new list that contains Full Name only 
            Console.WriteLine("\n3.Return a new list that contains Full Name only.");
            var fullNameList = new List<string>();
            foreach(var mem in listMembers)
            {
                fullNameList.Add(mem.firstName + " " + mem.lastName);
                Console.WriteLine(mem.firstName + " " + mem.lastName);
            }
            
            // 4.Return 3 lists:
            Console.WriteLine("\n4. Return 3 lists:");
            var mem_1998List = new List<Members>();
            var mem_greater1998List = new List<Members>();
            var mem_less1998List = new List<Members>();
            foreach(var mem in listMembers)
            {
                switch (mem.dateOfBirth.Year)
                {
                    case 1998:
                        mem_1998List.Add(mem);
                        break;
                    default:
                        if (mem.dateOfBirth.Year < 1998)
                        {
                            mem_less1998List.Add(mem);
                        }else
                        {
                            mem_greater1998List.Add(mem);
                        }
                        break;
                }
            }
            //4.1. List of members who has birth year is 1998
            Console.WriteLine("\n4.1. List of members who has birth year is 1998");
            foreach(var mem in mem_1998List)
            {
               Console.WriteLine(mem.firstName + " " + mem.lastName);
            }
            //4.2. List of members who has birth year greater than 1998
            Console.WriteLine("\n4.2. List of members who has birth year greater than 1998");
            foreach(var mem in mem_greater1998List)
            {
               Console.WriteLine(mem.firstName + " " + mem.lastName);
            }
            //4.3. List of members who has birth year less than 1998
            Console.WriteLine("\n4.3. List of members who has birth year less than 1998");
            foreach(var mem in mem_less1998List)
            {
               Console.WriteLine(mem.firstName + " " + mem.lastName);
            }
            

            //5.Return the first person who was born in Ha Noi.
            Console.WriteLine("\n5. Return the first person who was born in Ha Noi.");
            int i = 0;
            while (true)
            {
                if (listMembers[i].birthPlace.ToLower() == "ha noi")
                {
                    Console.WriteLine(listMembers[i].firstName + " " + listMembers[i].lastName);
                    break;
                }
                i = i+1;
                if (i == listMembers.Count)
                {
                    Console.WriteLine("No one was born in Ha Noi.");
                    break;
                }
            }
            //6. Return List of member who join class before 22/03/2021.
            Console.WriteLine("\n6. Return List of member who join class before 22/03/2021.");
            var mem_before2021List = new List<Members>();
            foreach(var mem in listMembers)
            {
                if (mem.StartDate < new DateTime(2021,03,22))
                {
                    mem_before2021List.Add(mem);
                    Console.WriteLine(mem.firstName + " " + mem.lastName);
                }
            }
            //
            Console.WriteLine("End!");
        }
    }
}
