using System;

namespace Nulltest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dummy[] testers = new Dummy[2]
            {
                //new Dummy{MeIsNull=42},
                new Dummy{},
                null
            };

            //Dummy[] testers = null;

            Console.WriteLine("========== Not implemented as a nullabale value type===========");
            Console.WriteLine(testers?[0].MeIsNotNull);

            Console.WriteLine("========== Implemented as a nullabale value type===========");

            Console.WriteLine(testers?[0]?.MeIsNull.HasValue);
       
            Console.WriteLine(testers?[0]?.MeIsNull.GetValueOrDefault());
            Console.WriteLine(testers?[0]?.MeIsNull.GetValueOrDefault(-1));

            int check1 = testers[0].MeIsNull.HasValue ? testers[0].MeIsNull.Value : -2; //Conditional Operator
            Console.WriteLine(check1);

            int check2 = testers?[0].MeIsNull ?? -3; //Null-Coalescing Operator
            Console.WriteLine(check2);

            int check3 = testers?[1]?.MeIsNull ?? -4; //Null-Conditional combined with Null-Coalescing operator
            Console.WriteLine(check3);

            Console.ReadLine();
        }
    }
}
