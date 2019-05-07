using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Collections
{
    class Details
    {
        public string name { get; set; }
        public string city { get; set; }
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList(5);
            //Console.WriteLine(al.Capacity);
            //al.Add(400);
            //al.Add(500);
            //al.Add(600);
            //al.Add(100);

            //Console.WriteLine(al.Capacity);
            //al.Add(100);
            //al.Add(200);
            //al.Add(300);
            //Console.WriteLine(al.Capacity);
            //foreach(object o in al)
            //{
            //    Console.WriteLine(o);
            //}

            //Hashtable h = new Hashtable();
            //h.Add("name", "haritha");
            //Console.WriteLine(h.Keys);
            //Console.WriteLine(h["name"]);
            //List<Details> dt = new List<Details>()
            //{
            //    new Details(){name="haritha",city="hyderabad" },
            //    new Details(){name="chaitanya",city="pune" }
            //};

            //foreach(Details ob in dt)
            //{
            //    Console.WriteLine(ob.name);
            //}
            //List<Details> dk = new List<Details>()
            //            {
            //new Details(){name="haritha",city="pune"},
            //new Details(){name="harika",city="hyderabad"}
            //            };

            //foreach (Details k in dk)
            //    Console.WriteLine(k.name + " " + k.city);
            //foreach (StudentDetails k in std)


            List<StudentDetails> std = new List<StudentDetails>()
        {
            new StudentDetails(){id=102,name="haritha",city="pune",marks=100},
            new StudentDetails(){id=103,name="chaitanya",city="hyderabad",marks=99},
             new StudentDetails(){id=103,name="manish",city="pune",marks=89},
            new StudentDetails(){id=103,name="sadhguna",city="pune",marks=69},
            new StudentDetails(){id=103,name="charan",city="hyderabad",marks=98},
             new StudentDetails(){id=103,name="nikhil",city="hyderabad",marks=98},
        };
            foreach (StudentDetails k in std)
}

    }
    }

}
