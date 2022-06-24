using System;
namespace Phone{
class PhoneNum {
    private long num; 
    private string name; 
    private string surname; 
    public string Name {
        get {return name;}
    }
    public string Surname{
        get {return surname; }
    }
    public PhoneNum (long cnum, string cname, string csurname) {
        num=cnum;
        name=cname; 
        surname=csurname; 
    }
    public void printNum() {
        Console.WriteLine("Telefon numarası: "+num.ToString()+". İsim Soyisim: "+name + " "+surname);
    }
   public static  PhoneNum returnNum() {
        Console.WriteLine("Lütfen isim girin        :");
        string name = Console.ReadLine(); 
        Console.Write("Lütfen soyisim girin      :"); 
        string surname=Console.ReadLine(); 
        Console.Write("Lütfen numara girin      :"); 
        long num=Convert.ToInt64(Console.ReadLine()); 
        return new PhoneNum(num, name, surname); 
}
public static void printBook(List<PhoneNum> book) {
    Console.WriteLine("Telefon rehberi listeleniyor... \n*****************");
    for(int i=0; i<book.Count; i++) 
    {
        book[i].printNum(); 
        Console.WriteLine("-"); 
    }
}
public static void deleteBook ( List<PhoneNum> book) {
    bool isactive = true; 
    while(isactive) {
    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:"); 
    string nameor=Console.ReadLine();
    if(PhoneNum.searchName(book, nameor)!=null) {
        PhoneNum item = PhoneNum.searchName(book, nameor); 
     Console.WriteLine(item.Name+" "+item.Surname+ "adlı kullanıcıyı silmek istiyor musunuz? (y/n)"); 
     string yn= Console.ReadLine(); 
     if(yn=="y") {
        book.Remove(item); 
     }
     else {
        break;
     }
     isactive= false;
    }
    else {
        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n  * Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
        int opt = Convert.ToInt16(Console.ReadLine()); 
        if(opt==1) {
            isactive=false; 
        }
        else {

        }
    }
    }

}
public static void printSearch (List <PhoneNum> book) {
Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.\n**********************************************");
Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
int opt = Convert.ToInt16(Console.ReadLine()); 
if( opt==1) {
    string nameor=Console.ReadLine(); 
    if( nameor!=null) {
        Console.WriteLine("Arama sonuçlarınız:     \n**********************************************");
    foreach ( var item in book) {
    if(item.name==nameor || item.surname==nameor) {
        item.printNum(); 
    }}
}
}
else if (opt==2) {
    long num=Convert.ToInt64(Console.ReadLine()); 
    Console.WriteLine("Arama sonuçlarınız:     \n**********************************************");
    foreach(var item in book) {
        if(item.num==num) 
        item.printNum();
    }
}
}
internal static PhoneNum searchName (List<PhoneNum> book, string nameor) {
foreach ( var item in book) {
    if(item.name==nameor || item.surname==nameor) {
        return item;
    }
}
return null; 
}

}}