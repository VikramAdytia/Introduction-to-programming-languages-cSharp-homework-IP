Console.WriteLine(" 1 Возводит число А в степеь B : ");
Console.WriteLine(" 2 Выдаёт сумму цифр в числе : ");
Console.WriteLine(" 3 Запрашивает елементы - выводит массив : ");
Console.Write(" select: ");

string selection = Console.ReadLine();

switch (selection){

    case "1":

        int GetIntPow(int inputNumA,int inputNumB){

            int inputNumAPow = inputNumA;

            /*if (inputNumB < 0){
                for ( int j = -1 ; j > inputNumB ; j--){
                inputNumAPow /= inputNumA;
                }
            }
            // if use double it works
            */

            if (inputNumA < 0){
                int inputNumAAbs = Math.Abs(inputNumA);
                    for ( int j = 1 ; j < inputNumB ; j++){
                        inputNumAPow *= inputNumAAbs;
                    }
                //inputNumAPow *= -1;
                // it just works
            }

            else {
                for ( int j = 1 ; j < inputNumB ; j++){
                    inputNumAPow *= inputNumA;
                }
            }

            return inputNumAPow;

        }

        Console.Write("input a number a :");
        int inputA = int.Parse(Console.ReadLine());

        Console.Write("input a number b :");
        int inputB = int.Parse(Console.ReadLine());

        Console.WriteLine(GetIntPow(inputA ,inputB));

        break;

    case "2":

        int GetIntSum(int inputNum){

        int sum = 0;
        while (inputNum != 0) {
            sum += inputNum % 10;
            inputNum /= 10;
        }

        return sum;

        }

        Console.Write("input a number :");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(GetIntSum(input));

        break;

    case "3":

        int[] GetArray(int arrayLenght){

            // tried object, didnt work ,i guess i know why

            int[] answer = new int[arrayLenght];

            for(int i = 0;i< answer.Length ;i++){
                Console.Write("input numerical element: ");
                answer[i]= int.Parse(Console.ReadLine());
            }

            return answer;
        }

        void PrintArray(int[] aray){

            for(int i = 0;i< aray.Length ;i++){
                Console.Write($"{aray[i]} ");
            } 
        }

        Console.Write("input an array length :");
        int inputArrayLength = int.Parse(Console.ReadLine());

        int[] aray = GetArray(inputArrayLength);

        PrintArray(aray);

        break;
}
