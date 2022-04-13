class program
{
    static void Main(string[] args)
    {
        int[] userNumberStorage = new int[0];
        int[] temporaryUserNumberStorage = new int[userNumberStorage.Length + 1];
        int indexUserNumberStorage = 0;
        string sumOfNumberStorage = "sum";
        string exit = "exit";
        bool isExit = false;
        string userInput;
        int sumOfNumberUserNumberStorage = 0;

        Console.WriteLine($"Добро пожаловать в хранилище чисел!" +
            $"\nДля записи просто введите любое число." +
            $"\nЧтобы расчитать сумму всех записаных чисел введите команду {sumOfNumberStorage}." +
            $"\nДля выхода из программы введите команду {exit}");

        while (isExit == false)
        {
            Console.WriteLine("Введите число или команду: ");
            userInput = Console.ReadLine();

            if (userInput == sumOfNumberStorage)
            {

                for (indexUserNumberStorage = 0; indexUserNumberStorage < userNumberStorage.Length; indexUserNumberStorage++)
                {
                    sumOfNumberUserNumberStorage += userNumberStorage[indexUserNumberStorage];
                }
                Console.WriteLine(sumOfNumberUserNumberStorage);
            }
            else if (userInput == exit)
            {
                isExit = true;
            }
            else
            {
                for (indexUserNumberStorage = 0; indexUserNumberStorage < userNumberStorage.Length; indexUserNumberStorage++)
                {
                    temporaryUserNumberStorage[indexUserNumberStorage] = userNumberStorage[indexUserNumberStorage];
                }
                temporaryUserNumberStorage[temporaryUserNumberStorage.Length - 1] = Convert.ToInt32(userInput);
                userNumberStorage = temporaryUserNumberStorage;
            }
        }

    }
}