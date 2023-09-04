using System.Text;

public class Type
{
    public static void uncheckedFunction()
    {
        unchecked
        {
            int a = Int32.MaxValue;
            Console.WriteLine(a + 2);
        }
    }

    public static void checkedFunction()
    {
        checked
        {
            int a = Int32.MaxValue;
            Console.WriteLine(a + 2);
        }
    }

    public static bool getBoolean(string b, bool a)
    {
        if (b == "True" || b == "true")
            return true;
        else if (!a && Convert.ToInt32(b) > 0)
            return true;
        return false;
    }

    public static void Main(string[] args)
    {
        string allowedChars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        Console.Write("Введите false/true или любое число: ");
        string str = Console.ReadLine();
        bool boolean = getBoolean(str, str.All(c => allowedChars.Contains(c)));
        Console.WriteLine("Введенное значение: " + boolean);

        Console.Write("Введите любое число: ");
        byte number = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Введенное число: " + number);

        Console.Write("\nВведите любой символ: ");
        char symbol = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введенный символ: " + symbol);

        Console.Write("\nВведите любое число с типом demical: ");
        decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введенное число: " + decimalNumber);

        Console.Write("\nВведите любое число с типом double: ");
        double doubleNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введенное число: " + doubleNumber);

        Console.Write("\nВведите любое число с типом float: ");
        float floatNumber = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Введенное число: " + floatNumber);

        Console.Write("\nВведите любое число с типом int:  ");
        int intNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введенное число: " + intNumber);

        Console.Write("\nВведите любое число с типом long:  ");
        long longNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Введенное число: " + longNumber);

        Console.Write("\nВведите любое число с типом short: ");
        short shortNumber = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введенное число: " + shortNumber);

        //Неявные преобразования

        int number_1 = 23142;
        long number_1_long = number_1;

        short number_2 = 2433;
        int number_2_integer = number_2;

        byte number_3 = 122;
        short number_3_short = number_3;

        uint number_4 = 152342324;
        double number_4_double = number_4;

        float number_5 = 53.3f;
        double number_5_double = number_5;

        //Явные преобразования

        int number_6 = 231422;
        short number_6_short = (short)number_6;

        float number_7 = 4323.234123f;
        int number_7_integer = (int)number_7;

        double number_8 = 4345.22356234232335;
        float number_8_floating_point = (float)number_8;

        short number_9 = 11341;
        byte number_9_byte = (byte)number_9;

        double number_10 = 23234.245231245;
        short number_10_short = (short)number_10;

        //Упаковка и распаковка значимых типов

        int firstVariable = 0;
        object firstObject = firstVariable;
        int firstVariableForUnboxing = (int)firstObject;

        long secondVariable = 1;
        object secondObject = secondVariable;
        long secondVariableForUnboxing = (long)secondObject;

        float thirdVariable = 1.1f;
        object thirdObject = thirdVariable;
        float thirdVariableForUnboxing = (float)thirdObject;

        //Неявно типизированная переменная

        var implicitlyTyped = 124;
        Console.WriteLine("\nНеявно типизированная переменная: " + implicitlyTyped);

        int? nullableVariable = null;
        Console.WriteLine("\nПеременная Nullable, в которой не содержится значение: " + nullableVariable);
        nullableVariable = 123;
        Console.WriteLine("\nПеременная Nullable, в которой содержится значение: " + nullableVariable);

        //Строки

        string stringName = "Efim";
        string stringSurname = "Lahvich";
        int result = String.Compare(stringName, stringSurname);

        if (result < 0)
        {
            Console.WriteLine("\nСтрока \"" + stringSurname + "\" больше, чем \"" + stringName + "\"");
        }
        else if (result > 0)
        {
            Console.WriteLine("\nСтрока \"" + stringName + "\" больше, чем \"" + stringSurname + "\"");
        }
        else
        {
            Console.WriteLine("\nОбе строки равны");
        }

        string firstString = "First string";
        string secondString = "Second string";
        string thirdString = "Third string";
        string stringForConcat = String.Concat(firstString, secondString, thirdString);
        Console.WriteLine("\nСоединенные строки: " + stringForConcat);

        string stringForCopy = String.Copy(firstString);
        Console.WriteLine("\nСкопирован первая строка: " + stringForCopy);

        string stringForSubString = firstString.Substring(0, firstString.Length - 5);
        Console.WriteLine("\nПодстрока из первой строки: " + stringForSubString);

        string[] words = thirdString.Split(' ');
        Console.WriteLine("\nРазделенные строки на слова: ");
        foreach (var word in words)
        {
            Console.WriteLine($"{word}");
        }

        string stringForPaste = firstString.Insert(2, stringForSubString);
        Console.WriteLine("\nПервая строка со вставленной подстрокой со 3-й позиции: " + stringForPaste);
        Console.WriteLine("\nПервая строка с удаленной подстрокой со 3-й позиции по 7-ю: " + stringForPaste.Remove(2, 5));
        Console.WriteLine($"\nИнтерполированная строка: {firstString}, {secondString}, {thirdString}");

        string emptyString = "";
        string nullString = null;
        Console.WriteLine("\nРезультат метода IsNullOrEmpty для пустой строки: " + String.IsNullOrEmpty(emptyString));
        Console.WriteLine("\nРезультат метода IsNullOrEmpty для строки с значением null: " + String.IsNullOrEmpty(nullString));
        Console.WriteLine("\nМы можем соединить строки: " + emptyString + nullString);
        Console.WriteLine("\nМы можем сравнить их методом Compare: " + String.Compare(emptyString, nullString));

        StringBuilder newString = new StringBuilder("Строка, составленная StringBuilder", 50);
        newString.Remove(0, 6);
        newString.Append("A");
        newString.Insert(0, "B");
        Console.WriteLine("\n" + newString);

        int[,] matrix = new int[3, 4] { { 23, 12, 54, 67 }, { 13, 51, 42, 78 }, { 24, 18, 14, 72 } };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        string[] stringArray = new[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        Console.Write("\nМассив: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.WriteLine("Длина массива " + stringArray.Length);
        Console.WriteLine("\nВведите, какой элемент вы хотите заменить: ");
        int index = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nВведите строку: ");
        stringArray[index] = Console.ReadLine();
        Console.Write("\nИзмененный массив: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("\nВведите ступенчатый вещественный массив: ");
        double[][] stair_array = new double[3][];
        stair_array[0] = new double[2];
        stair_array[1] = new double[3];
        stair_array[2] = new double[4];
        for (int i = 0; i < stair_array.Length; i++)
            for (int p = 0; p < stair_array[i].Length; p++)
            {
                Console.Write($"{i}.{p}: ");
                stair_array[i][p] = Convert.ToDouble(Console.ReadLine());
            }
        Console.WriteLine("\nВведеный массив: ");
        for (int i = 0; i < stair_array.Length; i++)
        {
            for (int p = 0; p < stair_array[i].Length; p++)
            {
                Console.Write($"{stair_array[i][p]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        var fruit = new[] { "Банан", "Яблоко", "Груша", "Апельсин" };
        var implicitString = "Я просто существую";

        //Кортежи

        (int tupleInt, string tupleString, char tupleChar, string tupleString2, ulong tupleUlong) tuple = (2, "Вася", 'П', "Петрович", 1234567893);
        Console.WriteLine("Первый кортеж: " + tuple);
        Console.WriteLine($"1-й элемент: {tuple.Item1}, 3-й элемент: {tuple.Item3}, 4-й элемент: {tuple.Item4}");
        int tmpIntVariable = tuple.tupleInt;
        string tmpStringVariable = tuple.tupleString;
        Console.WriteLine("Мы используем переменную из распакованного кортежа: " + tmpStringVariable);
        (int tupleInt, string tupleString, char tupleChar, string tupleString2, ulong tupleUlong) tuple2 = (10, "Евгений", 'Ж', "Жабинский", 9385730942);
        Console.WriteLine("Второй кортеж: " + tuple2);
        if (tuple == tuple2)
        {
            Console.WriteLine("Кортежи равны");
        }
        else
        {
            Console.WriteLine("Кортежи не равны");
        }

        //Локальная функция

        (int maxValue, int minValue, int sumOfElements, char firstSymbol)
            LocalFunction(int[] arrayForFunction, string stringForFunction)
        {
            int sum = 0;
            int max = Int32.MaxValue;
            int min = Int32.MinValue;
            for (int i = 0; i < arrayForFunction.Length; i++)
                sum += arrayForFunction[i];
            return (max, min, sum, stringForFunction[0]);
        };

        Console.WriteLine(LocalFunction(new[] { 412, 58, -14, 2144 }, "Ефим"));

        //Checked и unchecked

        try
        {
            checkedFunction();
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        uncheckedFunction();
    }
}