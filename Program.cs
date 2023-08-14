using System.Threading.Channels;

namespace manage_a_photo_book
{

    
    public class PhotoBook
    {
        public PhotoBook(int numpages= 16 ) 
        {
            numPages = numpages;
        }
       
        private int numPages;

        public int GetNumberPages ()
        {
            return numPages;
        }

    }

    public class BigPhotoBook
    {
        private int numPages;
        public BigPhotoBook(int numpages = 64)
        {
            numPages = numpages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }

    }
    public class CustomPhotoBook
    {

        private int numPages;

        int userInput = int.Parse(Console.ReadLine());

        public CustomPhotoBook(int userInput)
        {

            numPages = userInput;
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
           var book = new CustomPhotoBook();
            book.GetNumberPages();
            Console.WriteLine(book.GetNumberPages());


        }
    }
}