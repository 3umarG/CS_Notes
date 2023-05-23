using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        // The delegate must be as same as the method(s) signiture
        public delegate void PhotoFiltersHandler(Photo photo);


        // This told the function that you will receive a method with return type ... and parameters ...
        public void Process(string path, PhotoFiltersHandler handler)
        {
            var photo = Photo.Load(path);

            // do the logic of this function ايا كانت ايه هي المهم انها تتوافق مع الشكل اللي انا معرفه
            handler(photo);

            photo.Save();
        }


        // I can initialize delegate with built in : Action --> void , Func --> returnType
        // the param hendler means that you will accept function with parameter Photo and void return
        public void CompressWithAlgorithm(string path, Action<Photo> handler)
        {
            handler(Photo.Load(path));
        }
    }
}
