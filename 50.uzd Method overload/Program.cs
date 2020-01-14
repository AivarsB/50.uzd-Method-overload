using System;

namespace _50.uzd_Method_overload
{
    class Program
    {
        static void Main()
        {
            // Console.WriteLine(PrintNameSurname());
            Console.WriteLine(PrintNameSurname("", ""));

        }

        //static string PrintNameSurname()
        //{
        //    Console.Write("Enter name: ");
        //    var name = Console.ReadLine();
        //    return name;
        //}

        static string PrintNameSurname(string name, string surname)
        {
            Console.Write("Enter name: ");
            var Name = Console.ReadLine();

            if (String.IsNullOrEmpty(Name))
            {
                Name = "[Nezinams]";
            }

            Console.Write("Enter surname: ");
            var Surname = Console.ReadLine();

            if (String.IsNullOrEmpty(Surname))
            {
                Surname = "[Nezinams]";
            }

            return $"{Name} {Surname}";
        }
    }
}
// Izmantojot metožu overload iespējas definēt metodi PrintNameSurname, kura vienā gadījumā strādā 
// ar vienu ieejas parametru name, bet otrajā gadījumā ar diviem parametriem name un surname. 
// Pēc veiksmīga rezultāta sasniegšanas modificēt metodi PrintNameSurname, tā, lai tai būtu tikai
// divi parametri un ja lietotājs nav ievadījis uzvārdu, tad uzvārda vietā rakstītos teksts “Nezināms”.
