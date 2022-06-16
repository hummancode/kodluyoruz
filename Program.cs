// See https://aka.ms/new-console-template for more information

using System; 
namespace hata_yonetimi {
    class Program {
        static void Main (string [] args) {
            try {
            Console.WriteLine("Sayı gir:"); 
            int sayi  = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Sayı: "+sayi); 
            }
            catch(Exception ex) {
                Console.WriteLine("Hata: "+ex.Message.ToString()); 

            }
            finally {
                Console.WriteLine("İşlem tamam."); 

            }
       
        }
    }
}
