//Створити три перевантаження метода Add що повертатиме суму 
//Add(double a, double b)
//Add(string a, string b)
//Add(char a, char b)

class Program
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Add(string a, string b, out string error)
    {
        bool isParsed_a = double.TryParse(a, out double aParsed);
        bool isParsed_b = double.TryParse(b, out double bParsed);
        if (isParsed_a && isParsed_b)
        {
            error = string.Empty;
            return Add(aParsed, bParsed);
        }

        error = "Invalid input values";
        return 0;
    }

    static double Add(char a, char b, out string error)
    {
        bool isParsed_a = double.TryParse(a.ToString(), out double aParsed);
        bool isParsed_b = double.TryParse(b.ToString(), out double bParsed);
        if (isParsed_a && isParsed_b)
        {
            error = string.Empty;
            return Add(aParsed, bParsed);
        }

        error = "Invalid input values");
        return 0;
    }

    static void Main()
    {
        var result = Add('1', '2', out string forError);

        if (string.IsNullOrEmpty(forError))
        {
            Console.WriteLine($"Result {result}");
        }
        else
        {
            Console.WriteLine("Error has been occured with message " + forError);
        }
    }
}