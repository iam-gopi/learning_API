using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //var a1 = true;
            //var a23 = Test(15);

            //int[] a = { 1, 2, 3, 4, 5 };
            //List<int> result = (from i in a where i % 2 == 0 orderby i ascending select i).ToList<int>();

            //List<int> result2 = a.Where(i => i % 2 == 0).OrderBy(x => x).Select(i => i).ToList<int>();

            //List<Student> students = new List<Student>() {
            //new Student(){ Dept = "CSE", Name = "Arun" },
            //new Student(){Dept = "CSE", Name = "Vignesh"  },
            //new Student(){Dept = "IT", Name = "Ram"  },
            //new Student(){Dept = "IT", Name = "Rajesh"  },
            //new Student(){Dept = "ECE", Name = "Pradeep"  },
            //new Student(){Dept = "Mech", Name = "Suresh"  }
            //};


            //var result = (from student in students where student.Dept == "CSE" select new { student.Name }).ToList();

            //var result2 = students.Where(i => i.Dept == "IT").Select(i => new { i.Name }).ToList();

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Task task = Task.Factory.StartNew(() => { 
            //    Console.WriteLine("welcome to Task"); 
            //});

            ////task.Start();

            //Task t = task.ContinueWith(x => {
            //    Console.WriteLine("another task method");
            //});

            //t.Start();

            //if (task.IsFaulted)
            //{
            //    Console.WriteLine("faulted");
            //}

            Test2().Wait();
            Console.WriteLine("from main method");
            Console.ReadKey();
        }


        public static async Task Test()
        {
            await Task.Run( () => {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine(i);
                }
                //Task.Delay(1000).Wait();
            });
        }

        public static async Task Test2()
        {
            Test().GetAwaiter().GetResult();
            Test3();
        }


        public static void Test3()
        {
            Console.WriteLine(" oridinary");
        }
        public class Student
        {
            public string Name { get; set; }
            public string Dept { get; set; }
        }

        //public static dynamic Test(int a)
        //{
        //    //int a = 15;
        //    if (a > 10)
        //        return 0;
        //    else
        //        return "test";
        //}
    }
}
