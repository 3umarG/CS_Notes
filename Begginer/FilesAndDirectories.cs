using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begginer
{
    public class FilesAndDirectories
    {
        public static void FilesIntroduce()
        {

            /*
             * You can treat with Files by using two classes :
             * 1- File ======> all methods are static
             * 2- FileInfor =======> all methods are instance methods
             * 
             * When use which ??
             * when use File with static methods the OS must check secure checking ,
             * so if the number of operations is small , you can use File Class
             * 
             * if you decide to do alot of stuff , its preferable to use FileInfo with instance
             * 
             */


            var path = @"c:\users\pla.txt";
            File.Copy(path, @"d:\program_files");
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            var content = File.ReadAllText(path);



            // FileInfo
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"d:destination_folder");
            fileInfo.Delete();
            fileInfo.Create();
        }

        public static void DirectoryIntroduce()
        {
            var path = @"D:\flutter_proj";
            var allSubDir = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (var directory in allSubDir)
            {
                Console.WriteLine(directory);
            }

            var imagesPath = @"C:\Users\Ghost\Pictures\Screenshots";
            var allImagesFiles = Directory.GetFiles(imagesPath, "*.png", SearchOption.AllDirectories);
            foreach (var item in allImagesFiles)
            {
                Console.WriteLine(item);
            }
        }

        public static void PathIntroduce()
        {
            var path = @"D:\flutter_proj\chat_app\pubspec.yaml";
            Console.WriteLine("Extension : " + Path.GetExtension(path));
            Console.WriteLine("File Name : " + Path.GetFileName(path));
            Console.WriteLine("Directory Name : " + Path.GetDirectoryName(path));
            Console.WriteLine("File Name without Extension : " + Path.GetFileNameWithoutExtension(path));
        }
    }
}
