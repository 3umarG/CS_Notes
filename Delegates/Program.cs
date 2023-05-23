namespace Delegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*************** Hello Delegates *************** ");
            /*
             * What is Delegates ??
             * -- It is a Refrence to methods with specific signature
             * -- Helps us when improving the Framework
             * -- I can use it like I use Interfaces to apply some functionality
             *    without change or modify , to achieve extensability
             *    
             * How to do delegate ?
             * public delegate returType funName(... params) ===> the function signature of all methods that are typical
             *
             */

            // in this example the functionality of the method Process() is the same when any one call it
            // there is no extensionabily , when i try to add new function i must go to the PhotoProcessor
            // and change the body of Process() method
            // also every programmer want to make the function Process() more customizable for him
            // he must go to the implementation and change it , that's violate the Open-Closed principle.

            // I should make the function Process() accept special action from me when I use it .

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // the delegate/pointer to all methods with the same signt. I want to use
            // one method or more than ...
            Console.WriteLine("*************** User 1  ***************");
            PhotoProcessor.PhotoFiltersHandler filtersHandler = filters.IncreaseContrast;
            processor.Process("img.jpg", filtersHandler);


            // another user want to achieve another mechanism
            var processor2 = new PhotoProcessor();
            Console.WriteLine("*************** User 2 ***************");
            PhotoProcessor.PhotoFiltersHandler filtersHandler2 = filters.DecreaseContrast;
            filtersHandler2 += filters.DecreaseBrightness;
            processor.Process("img2.png", filtersHandler2);



            // third user have a unique thing want to add
            Console.WriteLine("*************** User 3 ***************");

            PhotoProcessor.PhotoFiltersHandler filtersHandler3 = IncreaseSaturation;
            processor.Process("img3.svg", filtersHandler3);


            // this for use Built in delegates types without make new type 
            Console.WriteLine("*************** User 4 ***************");

            Action<Photo> filtersHandler4 = IncreaseSaturation;
            filtersHandler4 += filters.DecreaseContrast;
            filtersHandler4 += filters.IncreaseBrightness;
            processor.CompressWithAlgorithm("img4.jpg", filtersHandler4);


            // Delegates with using Lambda Expression
            Console.WriteLine("*************** User 5 ***************");

            processor.CompressWithAlgorithm("img5", photo =>
            {
                Console.WriteLine("Using Delegates with Lambda Expression");
            });

        }


        public static void IncreaseSaturation(Photo photo)
        {
            Console.WriteLine("Increasing Saturation");
        }
    }
}