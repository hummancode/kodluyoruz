// See https://aka.ms/new-console-template for more information
Console.WriteLine("----1. BÖLÜM----"); 

Console.WriteLine("Gireceğin girdi sayısını belirle: "); 
int n=Convert.ToInt32(Console.ReadLine());
string str="";
for(int i=0; i<n; i+=1) {
    
Console.WriteLine("Pozitif sayı gir: "); 
int a=Convert.ToInt32(Console.ReadLine());
if(a%2==0) {
    str+=a+" "; 
}
}
Console.WriteLine(str);
Console.WriteLine("----2. BÖLÜM----"); 
Console.WriteLine("Pozitif iki sayı gir: "); 
int n1=Convert.ToInt32(Console.ReadLine());
int n2=Convert.ToInt32(Console.ReadLine());
string str2="";
for(int i=0; i<n1; i+=1) {
    
Console.WriteLine("Pozitif sayı gir: "); 
int a=Convert.ToInt32(Console.ReadLine());
if(a==n2 || n2%a==0) {
    str2+=a+" "; 
}
}
Console.WriteLine(str2);
Console.WriteLine("----3. BÖLÜM----"); 
Console.WriteLine("Gireceğin kelime sayısını belirle: "); 
int n3=Convert.ToInt32(Console.ReadLine());
List<string> sList = new List<string>();
for(int i=0; i<n3; i+=1) {
    
Console.WriteLine("Kelime gir: "); 
string a=Convert.ToString(Console.ReadLine());
sList.Add(a); 
}
Console.WriteLine("Ters sıralama:");
for(int i=0; i<sList.Count; i++) {
    Console.WriteLine(sList[sList.Count-1-i]);
}
Console.WriteLine("----4. BÖLÜM----"); 
Console.WriteLine("Cümle yaz: ");
string sentence=Convert.ToString(Console.ReadLine());
int countW=sentence.Length-sentence.Replace(" ","").Length;
int countC=sentence.Replace(" ","").Length;
Console.WriteLine("Karakter sayısı: "+countC.ToString() +", kelime sayısı: " +countW.ToString());
Console.WriteLine("-SON-");


