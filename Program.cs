    Double x1, x2, y1, y2, z1, z2, distance;
    Console.WriteLine("1. Определение паллиндрома.");
    Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
    Console.WriteLine("3. Вывод кубов числа n");
    Console.WriteLine("Выберите нужный пункт ( 1 /  2 / 3 )(без кавычек,скобочек,четрочек,точечек, только одна цифра):");

    char selection = Convert.ToChar(Console.ReadLine());

    switch (selection)
    {
        case '1':
            // Определение паллиндрома
            string GetIfPallyndrome(string myString) 
            {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
            if (myString[i] != myString[length - i - 1])
                            return "нет";
                    }
                    return "да";
            }
            Console.Write("pallyndrome check box: ");
            string myStringInput = Console.ReadLine();
            string myString = myStringInput.TrimStart('-');
            //а отрицательное число может быть палиндромом?

            string answer = GetIfPallyndrome(myString) ;
            Console.WriteLine(answer);
            ///Console.ReadKey();

            break;

        case '2':

            //Расстояние между двумя точками в пространстве.

            Console.Write("Введите координаты x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y1: ");
            z1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты y2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z1: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты z2: ");
            z2 = Convert.ToDouble(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            Console.WriteLine(Math.Round(distance, 2 ));
            ///Console.ReadKey();

            break;

        default:

            Console.WriteLine("Вы ввели неверный символ");
            ///Console.ReadKey();

            break;

        case '3':

            //Вывод кубов числа n

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            ///int nAbs = Math.Abs(n);
            //надо ли выводить что то при нуле?

            for (int i = 1 ; i <= Math.Abs(n) ; i++){
            Console.WriteLine(Math.Pow(i, 3));
            }
            break;

        }
