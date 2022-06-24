using System.Collections;
using System;
using System.Collections.Generic;
using Phone; 
bool isactive=true;
int Menu() {
Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz... \n***************************");
Console.WriteLine("(1) Yeni numara kaydetmek");
Console.WriteLine("(2) Varolan numarayı silmek");
Console.WriteLine("(3) Varolan numarayı güncelleme");
Console.WriteLine("(4) Rehberi listelemek ");
Console.WriteLine("(5) Rehberde arama yapmak");
Console.WriteLine("(6) Çıkış ");
int output=Convert.ToInt32(Console.ReadLine()); 
return output;
}

PhoneNum Ali = new PhoneNum(5431341309, "Ali", "Alagan");

List<PhoneNum> phoneDic=new List<PhoneNum>(); 
phoneDic.Add(Ali); 
phoneDic.Add(new PhoneNum(5415080309, "Ayşe", "Alagan")); 
phoneDic.Add(new PhoneNum(5551240209, "Barkay", "Alagan")); 
phoneDic.Add(new PhoneNum(5425577309, "Murat", "Alagan")); 
phoneDic.Add(new PhoneNum(5435044409, "Yehan", "Alagan")); 

phoneDic[1].printNum(); 

while (isactive) {
    int input = Menu(); 
    if (input==6) {
        isactive=false; 
    }
    else if (input==1) {
           phoneDic.Add(PhoneNum.returnNum()); 
          
    }
    else if (input==2) {
           PhoneNum.deleteBook(phoneDic);  
          
    }
        else if (input ==3 ) {
        PhoneNum.deleteBook(phoneDic);
        phoneDic.Add(PhoneNum.returnNum()); 
    }

    else if (input ==4 ) {
        PhoneNum.printBook(phoneDic); 
    }
    else if (input ==5) {
        PhoneNum.printSearch(phoneDic); 
    }

}
