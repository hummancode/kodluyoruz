// See https://aka.ms/new-console-template for more information
using System; 
using System.Collections.Generic;  
using cardProp; 
Console.WriteLine("Hello, World!");
int[] team={331,332,334,335,336}; 
bool isactive=true; 
List<card> cardlist= new List<card>(); 
cardlist.Add(new card("website entegrasyonu", "API'ların kullanılarak 1 ay içeresinde agoranın eklenmesi",team[1],1,"todo" ));
cardlist.Add(new card("pazarlama çalışmaları I", "Uygun reklam yöntemleri ve fiyatlandırma araştırılacak",team[2],2,"done" ));
cardlist.Add(new card("arama yöntemi belirlenmesi", "Uygun arama yöntemleri araştırılacak",team[1],2,"done" ));
cardlist.Add(new card("pazarlama çalışmaları II", "Google reklamlar ve facebook reklamları verilecek",team[2],3,"progress" ));
cardlist.Add(new card("kullanıcı analizi", "kullanıcı verileri ve geri bildirimleri değerlendirilecek",team[3],4,"todo" ));
int Menu() {
Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz... \n***************************");
Console.WriteLine("(1) Listeleme");
Console.WriteLine("(2) Kart ekleme");
Console.WriteLine("(3) Kart silme");
Console.WriteLine("(4) Kart taşıma");
Console.WriteLine("(5) Çıkış ");
int output=Convert.ToInt32(Console.ReadLine()); 

return output;
}
while(isactive) {
int input = Menu(); 
if (input==1) {
        card.printCards(cardlist); 
}
else if (input==5) {
        isactive=false; 
}

else if (input==2) {
        cardlist.Add(card.createCard()); 
}
else if (input==3) {
        card.deleteCard(cardlist); 
}
else if(input==4) {
        card.updateCards(cardlist); 
}
    }
