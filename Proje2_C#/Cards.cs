using System; 

namespace cardProp{
    enum sizes {
        zero,
        XS,
        S, 
        M,
        L, 
        XL
    }
    class card{
        static string dots = "*********************"; 
        private string headline; 
        private string content; 
        private long personid; 
        private sizes size; 
        private string line; 
        public card (string hline, string cont, long pid, int siz, string lin) {
                headline=hline; 
                content=cont; 
                personid=pid; 
                size=(sizes) siz;
                line=lin; 
        }
        public string Line {
            get{return line; }
            set {line = value; }
        }
        public static card createCard() {
            Console.WriteLine("Başlık giriniz       :"); 
            string head=Console.ReadLine(); 
            Console.WriteLine("İçerik giriniz       :"); 
            string cont=Console.ReadLine(); 
            Console.WriteLine("Büyüklük seçiniz     :"); 
            int size=Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine("Atanan kişi seçiniz  :"); 
            int id=Convert.ToInt16(Console.ReadLine()); 
            return (new card(head,cont,id,size,"todo"));
        }
        public static void deleteCard(List<card> cards) {
            bool isactive=true; 
            bool deleted=false; 
            while(isactive) {
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            string head=Console.ReadLine(); 
            foreach(var item in cards.ToList()) {
                if(item.headline==head) {
                    cards.Remove(item); 
                    Console.WriteLine("Silme gerçekleştirildi."); 
                    deleted=true; 
                }
            }
            if(deleted) {
                isactive=false; 
            }
            else {Console.WriteLine("Uygun kart bulunamadı.\n* Silmeyi sonlandırmak için : (1)\n * Yeniden denemek için : (2)"); 
            int opt= Convert.ToInt16(Console.ReadLine()); 
            if(opt==1) {
                isactive=false;
            }

            }

             }

        }
        public static void updateCards(List<card> cards) {
            bool isactive=true;
            while(isactive) {
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            string head=Console.ReadLine(); 
            foreach(var item in cards) {
                if(item.headline==head) {
                    Console.WriteLine("Bulunan kart bilgileri: \n"+dots); 
                    item.printCard(); 
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: \n(1) YAPILACAKLAR \n(2) YAPILMAKTA OLANLAR \n(3) YAPILANLAR");
                    int lin = Convert.ToInt16(Console.ReadLine()); 
                    string push=""; 
                    if(lin==1) push="todo"; if(lin==2) push="progress"; if(lin==3) push="done"; 
                    item.Line=push; 
                    Console.WriteLine("Taşıma gerçekleştirildi."); 
                    isactive=false; 
                    break; 
                }
            }
            if(isactive) {
            Console.WriteLine("Uygun kart bulunamadı.\n* Güncellemeye sonlandırmak için : (1)\n * Yeniden denemek için : (2)");
            int op = Convert.ToInt16(Console.ReadLine()); 
            if (op==1) {
                isactive=false; 
            }
            }
            }
        }
        internal card updateCard(card acard,string newline) {
            acard.Line=newline; 
            return acard; 
        }
        public void printCard() {
            Console.WriteLine("Başlık      :"+headline+"\nİçerik      :"+content+"\nAtanan Kişi :"+personid.ToString()+"\nBüyüklük    :"+(sizes) size+"\n");
        }
        public static void printCards(List<card> cards) {
            Console.WriteLine("YAPILACAKLAR\n"+card.dots); 
            foreach(var item in cards) {
                if(item.line=="todo") {
                    item.printCard(); 
                }
            }
            Console.WriteLine("-"); 
            Console.WriteLine("YAPILMAKTA OLANLAR\n"+dots); 
            foreach(var item in cards) {
                if(item.line=="progress") {
                    item.printCard(); 
                }
            }
            Console.WriteLine("-"); 
            Console.WriteLine("YAPILANLAR\n"+dots);
            foreach(var item in cards) {
                if(item.line=="done") {
                    item.printCard();
                }
            } 
            Console.WriteLine("-"); 
        }
     

    }
}