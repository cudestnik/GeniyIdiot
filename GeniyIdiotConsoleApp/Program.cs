using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[5];

            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей,сколько надо сделать распилов?";
            questions[2] = "На двух руках 10 пальцев.Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса,сколько нужно минут для трёх уколов?";
            questions[4] = "Пять свечей горело,две потухли.Сколько осталось?";

            int[] answers = new int[5];

            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;

          

            for(int i = 0; i < questions.Length; i++) 
            {
                Console.WriteLine(questions[i]);
            }



        }
    }
}
