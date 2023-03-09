using System;

namespace GeniyIdiotConsoleApp
{
    class Program
    {  
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Привет! Как Вас зовут? ");
                string username = Console.ReadLine();

                int countDiagnoses = 6;
                int countQuestions = 5;
                string[] questions = GetQuestions(countQuestions);
                string[] diagnoses = GetDiagnoses(countDiagnoses);
                int countAnswers = 5;
                int[] answers = GetAnswers(countAnswers);


                int CountRightAnswers = 0;

                Random random = new Random();

                for (int i = countQuestions - 1; i >= 1; i--)
                {
                    int index = random.Next(0, i);

                    string tempQuestions = questions[index];
                    questions[index] = questions[i];
                    questions[i] = tempQuestions;

                    int tempAnswer = answers[index];
                    answers[index] = answers[i];
                    answers[i] = tempAnswer;

                }
                for (int i = 0; i < countQuestions; i++)
                {
                    Console.WriteLine("Вопрос N" + (i + 1));

                    Console.WriteLine(questions[i]);

                    int userAnswer = Convert.ToInt32(Console.ReadLine());

                    int rightAnswer = answers[i];

                    if (userAnswer == rightAnswer)
                    {
                        CountRightAnswers++;
                    }
                }

                Console.WriteLine("Количество правильных ответов: " + CountRightAnswers);

                Console.WriteLine(username + " , Ваш диагноз: " + diagnoses[CountRightAnswers]);

                bool userChoice = GetUserShoice("Хотите начать сначала?");
                
                if(userChoice == false)
                {
                    break;
                }
            }
        }
        static bool GetUserShoice(string message)
        {

            while (true)
            {


                Console.WriteLine(message + "Введите Да или Нет. ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "нет")
                {
                    return false;

                }
                if (userInput.ToLower() == "да")
                {
                    return true;
                }

            }
        }

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


    }

}
