namespace AsynchronousProgramming
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //ReadFromFile();
            //ReadFromFileAsync();
            await ReadFromFileMoreEasyAsync();

            Console.ReadLine();
        }

        /*
        * This function will do its own job synchronously
        * if there is any heavy job that takes more time : DB , Disks , Network calls ... etc
        * it will block the Main Thread
        * 
        * The solution to this Problem is :
        *   1- Multithreading "Parallel Programming" : by creating more and more threads for apply our jobs
        *   2- Asynchronous Programming : by using Only Single thread , but by using Task(s)
        *    - for example : the Clock Alarm : you don't have to wait until the alarm clocked
        *                    you put the alarm , and when it clocked you resume your work.
        *    - another example : the waiter and cheif in the restraunt , the waiter orders from the Cheif
        *      and go back to continue his work , until the Cheif finish .
        */
        public static void ReadFromFile()
        {

            var lines = File.ReadAllLines("TextFile.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }


        // This Function use Asynchronous Programming Technique 
        // but the code is more and more ...
        public static void ReadFromFileAsync()
        {
            File.ReadAllLinesAsync("TextFile.txt").ContinueWith(task =>
            {

                if (task.IsFaulted)
                {
                    Console.Error.WriteLine(task.Exception);
                }

                var lines = task.Result;
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            });
        }

        // so we use another way of Asynch. Programming by using : Task , async , await keywords
        // to make our code shorter and more readable and clean 
        public static async Task ReadFromFileMoreEasyAsync()
        {
            var lines = await File.ReadAllLinesAsync("TextFile.txt");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}