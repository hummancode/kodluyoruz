// See https://aka.ms/new-console-template for more information
using System.Collections;
using System;
using System.Linq;

int i=0;
int try_count=20; 
int[] theArray=new int[try_count+1];; 
while(i<try_count) {
    Console.WriteLine("Sayı gir:");
string a=Console.ReadLine(); 
int num;
if(int.TryParse(a, out num)) {
    num=Int16.Parse(a); 
    i++;
    theArray[i]=num;
}
}
int[] tArray = theArray.Skip(1).ToArray();
Array.Sort(tArray);
foreach(var item in tArray) {
    
    Console.Write(item+", ");
}
double f3= ((double)tArray[0]+(double)tArray[1]+(double)tArray[2])/3;
double l3= ((double)tArray[tArray.Length-1]+(double)tArray[tArray.Length-2]+(double)tArray[tArray.Length-3])/3;

Console.WriteLine("En küçük 3 sayı ortalaması: "+f3.ToString()+". En büyük üç sayısı ortalaması: "+ l3.ToString()); 