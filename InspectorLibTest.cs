using System;
using InspectorLib;

namespace InspectorLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса FunctionInsp
            FunctionInsp inspector = new FunctionInsp();

            // Тестируем методы
            Console.WriteLine("Главный инспектор: " + inspector.GetInspector());
            Console.WriteLine("Название автоинспекции: " + inspector.GetCarInspection());

            // Изменим главного инспектора
            if (inspector.SetInspector("Иванов И.И."))
            {
                Console.WriteLine("Главный инспектор успешно изменен на: " + inspector.GetInspector());
            }
            else
            {
                Console.WriteLine("Не удалось изменить главного инспектора.");
            }

            // Генерация госногора
            string generatedNumber = inspector.GenerateNumber("1234", "A", "75");
            Console.WriteLine("Сгенерированный госномер: " + generatedNumber);

            // Получение сотрудников
            Console.WriteLine("Сотрудники автоинспекции:");
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Добавление нового сотрудника
            inspector.AddWorker("Петров П.П.");
            Console.WriteLine("После добавления нового сотрудника:");
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
}