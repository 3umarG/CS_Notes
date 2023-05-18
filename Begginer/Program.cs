using System;


namespace Begginer
{
    class Program
    {
        //static void Main()
        //{
        //    string[] colorStrings = { "0", "2", "8", "blue", "Blue", "Yellow", "Red, Green" };
        //    foreach (string colorString in colorStrings)
        //    {

        //        // This if statement returns True if :
        //        // 1- the colorString is any Integer .
        //        // 2- the colorString is accepted String for the enumeration .

        //        //       TryParse(  -input-  ,   -output result-    )
        //        if (Enum.TryParse(colorString, out Colors colorValue))
        //        {

        //            // So I need to check the Integer that is accepted by IsDefined method .
        //            if (Enum.IsDefined(typeof(Colors), colorValue) || colorValue.ToString().Contains(','))
        //            {
        //                Console.WriteLine("Converted '{0}' to {1}.", colorString, colorValue.ToString());

        //            }
        //            else
        //            {
        //                Console.WriteLine("{0} is not an accepted Integer value of the Colors enumeration.", colorString);

        //            }

        //        }
        //        else
        //        {
        //            Console.WriteLine("{0} is not an accepted String of the Colors enumeration.", colorString);

        //        }

        //        /*
        //         * 
        //         * Output
        //         * 
        //         *  Converted '0' to None.
        //            Converted '2' to Green.
        //            8 is not an underlying value of the Colors enumeration.
        //            blue is not a member of the Colors enumeration.
        //            Converted 'Blue' to Blue.
        //            Yellow is not a member of the Colors enumeration.
        //            Red, Green is not an underlying value of the Colors enumeration.
        //         */
        //    }

        //}

        //static void Main()
        //{
        //    var numbers = new List<int>() { 1,2,3,1,5,2,6};
        //    for(var i =0; i<numbers.Count; i++)
        //    {
        //        var item = numbers[i];
        //        if(item == 1 || item == 2)
        //        {
        //            numbers.Remove(item);
        //        }
        //    }

        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        public static void Main()
        {
            FilesAndDirectories.PathIntroduce();
        }
        public enum States
        {
            Loading = 1,
            Success = 2,
            Error = 3,
            Undefined = 4
        }
        enum Colors { None = 0, Red = 1, Green = 2, Blue = 4, }
    }
}