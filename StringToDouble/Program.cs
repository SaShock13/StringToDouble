// See https://aka.ms/new-console-template for more information

while (true)
{

    Console.Write("Введите число с плавающей запятой : ");
    string stringNum = Console.ReadLine();

    if (stringNum != string.Empty)
    {
        Console.WriteLine($"\nВаше число в формате double: {ConvertStringToDouble(stringNum)}");
        break;
    }
    
}
Console.ReadLine();
double ConvertStringToDouble(string num)
{
    double result;
    string[] parts = new string[2];
    string fractialString;
    parts = num.Split([',', '.']);
    string integerString = parts[0];
    if (parts.Length==1)
    {
        fractialString = "0";
    }else  fractialString = parts[1];

    int integerNum=0;
    double fractialNum=0;
    bool isValid = true;
    Console.WriteLine($"Целая часть строка {integerString}, Дробная часть строка {fractialString}");

    for (int i = 0,k= integerString.Length-1; i < integerString.Length; i++,k--)
    {
        int digit = Recognizing(integerString[k]);
        if (digit < 10)
        {
            int multyplyer = 1;
            for (int x = 0; x < i; x++)
            {
                multyplyer *= 10 ;
            }
            integerNum += (digit * multyplyer);

        }
        else { isValid = false; break; }
        Console.WriteLine($"{integerNum}");
    }
    Console.WriteLine($"Целая часть : {integerNum}");

    Console.WriteLine("\n---------------");
    if (isValid)
    {
        for (int j = 0; j < fractialString.Length; j++)
        {
            int digit = Recognizing(fractialString[j]);
            if (digit !=-1)
            {
                double multyplyer = 0.1;
                for (int x = 0; x < j; x++)
                {
                    multyplyer /= 10;
                }
                fractialNum += (digit * multyplyer);
            }
            Console.WriteLine($"{fractialNum}");

        }
    }
    Console.WriteLine($"Дробная часть : {fractialNum}");

    
    if (!isValid)
    {
        Console.WriteLine("Число некорректно!!!");
        return 0;
    }
    else return result = (double)integerNum + fractialNum;
    ///return Convert.ToDouble(num);


    ///Принимает символ цифры и возращает цифровое представление символа, или -1, если символ не является цифрой
    int Recognizing(char symbol)
    {
        int result;
        switch (symbol)
        {
            case '0': result = 0; break;
            case '1': result = 1; break;
            case '2': result = 2; break;
            case '3': result = 3; break;
            case '4': result = 4; break;
            case '5': result = 5; break;
            case '6': result = 6; break;
            case '7': result = 7; break;
            case '8': result = 8; break;
            case '9': result = 9; break;

            default: result = -1; break;
        }

        return result;

    }
}
