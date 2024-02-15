namespace Ref_In_Out_keywords_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var param = 10;
            param += 1;
            PassByRef(ref param);
            Console.WriteLine($"ref outside method {param}");

            PassByIn(param);
            param += 10;
            Console.WriteLine($"in outside method {param}");

            int outParam;
            //outParam += 100;
            PassByOut(out outParam);
            outParam += 100;
            Console.WriteLine($"out outside method {outParam}");
        }

        static void PassByRef(ref int refParam)
        {
            refParam += 1;
            Console.WriteLine($"ref inside method {refParam}");
        }

        static void PassByIn(in int inParam)
        {
            //inParam = 100; this is read-only here
            Console.WriteLine($"in inside method {inParam}");

        }

        static void PassByOut(out int outParam)
        {
            outParam = 100;
            Console.WriteLine($"out inside method {outParam}");
        }
    }
}
