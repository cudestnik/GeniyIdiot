using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {  
        static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];

            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей,сколько надо сделать распилов?";
            questions[2] = "На двух руках 10 пальцев.Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса,сколько нужно минут для трёх уколов?";
            questions[4] = "Пять свечей горело,две потухли.Сколько осталось?";
                return questions;
        }

        static int[] GetAnswers(int countAnswers) 
        {
            int[] answers = new int[countAnswers];

            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;
            return answers;

        }
        static string[] GetDiagnoses(int countDiagnoses)
        {
            string[] diagnoses = new string[countDiagnoses];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "Кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Талант";
            diagnoses[5] = "Гений";
            return diagnoses;
        }

        static void Main(string[] args)
        {
            int countDiagnoses = 6;
            int countQuestions = 5;
            string[] questions = GetQuestions(countQuestions);
            string[] diagnoses = GetDiagnoses(countDiagnoses);
            int countAnswers = 5;
            int[] answers = GetAnswers(countAnswers);


            int CountRightAnswers = 0;

            Random rand = new Random();

            for(int i = 0; i < countQuestions ; i++) 
            {
                Console.WriteLine("Вопрос N" + (i+1));

                int randomQuestionIndex = rand.Next(0, countQuestions);
               
               
            
            
                Console.WriteLine(questions[randomQuestionIndex]);

                int userAnswer = Convert.ToInt32(Console.ReadLine());

                int rightAnswer = answers[randomQuestionIndex];
              

                if(userAnswer == rightAnswer)
                {
                    CountRightAnswers++;
                }               
            }

            Console.WriteLine("Количество правильных ответов: " + CountRightAnswers);

            /*string diagnose = "";

            if(CountRightAnswers == 0) 
            { 
                diagnose = "Идиот";
            }
            if (CountRightAnswers == 1)
            {
                diagnose = "Кретин";
            }
            if (CountRightAnswers == 2) // Или эта конструкция или switch но она красивее и короче
            {
                diagnose = "Дурак";
            }
            if (CountRightAnswers == 3)
            {
                diagnose = "Нормальный";
            }
            if (CountRightAnswers == 4)
            {
                diagnose = "Талант";
            }
            if (CountRightAnswers == 5)
            {
                diagnose = "Гений";
            }*/
           /* switch(CountRightAnswers)
            {
                case 0: diagnose = "Идиот";break;
                case 1: diagnose = "Кретин";break;
                case 2: diagnose = "Дурак";break;           // вместо него заменили на массив diagnoses
                case 3: diagnose = "Нормальный";break;
                case 4: diagnose = "Талант";break;
                case 5: diagnose = "Гений";break;

            }
           */

           

            Console.WriteLine("Ваш диагноз: " + diagnoses[CountRightAnswers]);
        }
    }
}
