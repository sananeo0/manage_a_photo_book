using System.Threading.Channels;
using System;
namespace manage_a_photo_book
{

    
    public class PhotoBook
    {
        public PhotoBook() 
        {
            numPages = 16;
        }
       
        private int numPages;

        public PhotoBook(int numpages)
        {
            numPages = numpages;
        }




        public int GetNumberPages ()
        {
            return numPages;
        }

    }

    public class BigPhotoBook
    {
        private int numPages;
        public BigPhotoBook()
        {
            numPages = 64;    
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            var defaultPhotoBook = new PhotoBook();
            Console.WriteLine(" Default Photo Book - Number of Pages:" + defaultPhotoBook.GetNumberPages());

            var customPhotoBook = new PhotoBook(24);
            Console.WriteLine(" Custom Photo Book - Number of Pages:" + customPhotoBook.GetNumberPages());

            var bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(" Big Photo Book - Number of Pages:" + bigPhotoBook.GetNumberPages());
        }

    }
}