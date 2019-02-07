using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson.SortNumbersExample();
            //Lesson.SortVectorsExample();
            //Lesson.SortVectorsGenericExample();
            //Lesson.SortWithDelegatesExample();
            //Lesson.SingleAndMulticastExample();
            //Lesson.SortWithAnonymousFunction();
            //Lesson.SortWithLambdaFunction();
            //Lesson.CarDelegateExample();
            //Lesson.ExamExample();

            Practice practice = new Practice();

            practice.StrinFormatter();

            foreach (var text in practice.text)
            {
                Console.WriteLine(text);
            }
            
            Console.ReadLine();
        }
    }
}
