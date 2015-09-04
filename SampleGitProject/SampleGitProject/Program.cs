using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleGitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewStringsObject = new Strings();

            NewStringsObject.firstString = "Some random text value";
            NewStringsObject.secondString = "Better random text value";

            Console.WriteLine(string.Format("The value of the first string in this program is {0}", NewStringsObject.firstString));
            Console.WriteLine(string.Format("The value of the first second string in this program is {0}", NewStringsObject.secondString));

            Console.ReadLine();

        }
    }
}
