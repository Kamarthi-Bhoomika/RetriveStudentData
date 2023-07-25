using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section4_SelfLearning
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                string dir = "D:\\section4_SelfLearning\\section4_SelfLearning\\";
                string filename = dir + "StudentData.txt";

                if (File.Exists(filename))
                    Console.WriteLine("File exists");
                else
                    Console.WriteLine("File does not exist");

                Console.WriteLine("Student Data: ");
                Console.WriteLine("ID\tName\t Age\tGender\tPlace");
                string[] lines = File.ReadAllLines(filename);
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! "+ex.Message);
            }
            finally
            {
                Console.WriteLine("\nEnd of Student Data");
                Console.ReadKey();
            }
        }
    }
}
