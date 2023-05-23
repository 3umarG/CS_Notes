namespace Delegates
{

    /*
     * This class represent all functionalities that i will apply on my project
     * all these methods have the same signature
     */
    public class PhotoFilters
    {
        public void IncreaseBrightness(Photo photo)
        {
            Console.WriteLine("Increasing Brightness");
        }

        public void DecreaseBrightness(Photo photo)
        {
            Console.WriteLine("Decrease Brightness");
        }

        public void IncreaseContrast(Photo photo)
        {
            Console.WriteLine("Increasing Contrast");
        }

        public void DecreaseContrast(Photo photo)
        {
            Console.WriteLine("Decrease Contrast");
        }
    }
}
