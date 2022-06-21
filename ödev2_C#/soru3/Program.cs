// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
Console.WriteLine("Cümle gir: ");
List<string> chars= new List<string>(); 
string sentence=Console.ReadLine();
foreach (char c in sentence) {
    if(c=='i' || c=='a' ||c=='e'|| c=='u'|| c=='o' ||  c=='A' ||c=='E'|| c=='U'|| c=='O' ) {
        chars.Add(c.ToString());
    }
}
foreach(var item in chars) {
    Console.Write(item+ ", ");
}
