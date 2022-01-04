using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Homework
{
    class Program
    {
        /*
          * Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
          * метод void setStart(int x) - устанавливает начальное значение
          * метод int getNext() - возвращает следующее число ряда
          * метод void reset() - выполняет сброс к начальному значению
          * 
          * Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
          * В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
          */
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();

                Console.WriteLine("Введите начальное значение прогрессии: ");
                int startNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите шаг арифметической прогрессии: ");
                int stepNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите знаменатель геометрической прогрессии: ");
                int denNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите количество членов прогрессий: ");
                int number = Convert.ToInt32(Console.ReadLine());

                ArithProgression ap = new ArithProgression(startNumber, stepNumber);
                GeomProgression gp = new GeomProgression(startNumber, denNumber);

                Console.WriteLine("Арифметическая прогрессия:");
                Console.Write($"\t{startNumber} ");
                for (int i = 0; i < number - 1; i++)
                {
                    Console.Write($"\t{ap.getNext()} ");
                }
                Console.WriteLine();

                Console.WriteLine("\nГеометрическая прогрессия:\n");
                Console.Write($"\t{startNumber} ");
                for (int i = 0; i < number - 1; i++)
                {
                    Console.Write($"\t{gp.getNext()} ");
                }

                Console.WriteLine("\nНажмите \"Enter\", чтобы заново сгенерировать прогрессии.\nДля выхода, нажмите любую другую клавишу.");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        interface ISeries
        {
            void setStart(int startNumber);
            int getNext();
            void reset();
        }
        class ArithProgression : ISeries
        {
            public int StartNumber;
            public int CurrentNumber;
            public int StepNumber;
            public ArithProgression(int startNumber, int stepNumber)
            {
                StartNumber = startNumber;
                CurrentNumber = startNumber;
                StepNumber = stepNumber;
            }
            public int getNext()
            {
                return CurrentNumber += StepNumber;
            }
            public void reset()
            {
                CurrentNumber = StartNumber;
            }
            public void setStart(int startNumber)
            {
                StartNumber = startNumber;
            }
        }
        class GeomProgression : ISeries
        {
            public int StartNumber;
            public int CurrentNumber;
            public int DenNumber;
            public GeomProgression(int startNumber, int denNumber)
            {
                StartNumber = startNumber;
                CurrentNumber = startNumber;
                DenNumber = denNumber;
            }
            public int getNext()
            {
                return CurrentNumber *= DenNumber;
            }
            public void reset()
            {
                CurrentNumber = StartNumber;
            }
            public void setStart(int startNumber)
            {
                StartNumber = startNumber;
            }
        }
    }
}
