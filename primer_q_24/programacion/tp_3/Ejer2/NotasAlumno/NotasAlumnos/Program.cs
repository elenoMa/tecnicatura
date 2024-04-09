namespace NotasAlumno;
// Realizar un programa que pida tres notas de un alumno, (primer parcial, segundo parcial y proyecto integrador), calcule el promedio e imprima lo siguiente:

// Si el promedio es >=6 y <=10 mostrar "Cursa y promociona".
// Si el promedio es <6 y >= 4 mostrar "Cursa y rinde examen final".
//Si el promedio es <4 mostrar “No cursa”

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(_evaluateAverage(_calculateAverage(
            _getPunctuation("Ingrese la nota del primer parcial: "),
            _getPunctuation("Ingrese la nota del segundo parcial: "),
            _getPunctuation("Ingrese la nota del proyecto integrador: ")
        )));
    }

    private static Func<string, int> _getPunctuation = (speech) =>
    {
        int puntuation;

        Console.Write(speech);

        if (!int.TryParse(Console.ReadLine(), out puntuation) || puntuation <= 0 || puntuation > 10)
        {
            Console.WriteLine("Nota inválida, intente nuevamente: ");
            return _getPunctuation(speech);
        }

        return puntuation;
    };

    private static Func<int, string> _evaluateAverage = (average) =>
    {
        string speech;

        if (average >= 6 && average <= 10)
        {
            speech = "Cursa y promociona";
        }
        else if (average >= 4 && average < 6)
        {
            speech = "Cursa y rinde examen final";
        }
        else
        {
            speech = "No cursa";
        }

        return speech;
    };

    private static Func<int, int, int, int> _calculateAverage = (nota1, nota2, nota3) =>
    {
        return (int)Math.Round((nota1 + nota2 + nota3) / 3.0);
    };
}