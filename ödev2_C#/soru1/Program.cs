// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
ArrayList prime=new ArrayList(); 
ArrayList nonprime = new ArrayList();
static void printList(int[] array) {
    
}
bool isPrime(int i) {
    bool output=true;
    if(i>1) {
    for(int j=2; j<i; j++) {
        if(i!=j && i%j==0) {
            output=false; 
        }
        
        }
    }
    else {output=false;}
    return output;  
}
int i=0; 
int try_count=20;
while(i<try_count) {
    Console.WriteLine("Sayı gir:");
string a=Console.ReadLine(); 
int num;
if(int.TryParse(a, out num)) {
    num=Int16.Parse(a); 
    if(num>0) {
            Console.WriteLine("Sayı alındı: "+num.ToString()); 
            if(isPrime(num)) {
                prime.Add(num);
            }
            else {
                nonprime.Add(num); 
            }
            i++;
    }
    else {
        Console.WriteLine(a+" pozitif değil! ");
    }
}
else {
    Console.WriteLine(a + " numerik değil!");
}

}
prime.Sort();
prime.Reverse();
nonprime.Sort();
nonprime.Reverse();
Console.WriteLine("Asal sayılar: "); 
foreach (var item in prime)
    Console.Write(item + ", ");  
Console.WriteLine("\nAsal olmayan sayılar: "); 
foreach (var item in nonprime)
    Console.Write(item + ", ");  
int primeL= prime.Count; 
int nonprimeL=nonprime.Count; 
Console.WriteLine("\nAsal dizinin uzunluğu: "+primeL.ToString()+". Asal olmayan dizinin uzunluğu: "+nonprimeL.ToString()); 
int sum=0; 
foreach (int item in prime)
    sum+=item;
int sum2=0; 
foreach (int item in nonprime)
    sum2+=item;
float pavg=((float)sum/(float)primeL);
float navg=((float)sum2/(float)nonprimeL);
Console.WriteLine("Asal dizinin ortalaması: "+pavg.ToString()+". Asal olmayan dizinin ortalaması: "+navg.ToString() ); 