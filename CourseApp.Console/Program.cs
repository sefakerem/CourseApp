Personel personel = new Personel();
personel.Ad = "Sefa";
personel.Soyad = "Koçakoğlu";
personel.SicilNo = 1;

Personel personel1 = new Personel();
personel1.Ad = "Kerem";
personel1.Soyad = "Ergüner";
personel1.SicilNo = 2;

personel.Bilgi();
personel1.Bilgi();


class Insan
{
    public string Ad;
    public string Soyad;
    public bool EvliMi;
}
class Personel:Insan
{
    public int SicilNo;
    public Personel()
    {
        Console.WriteLine("Kurucu metod çalıştı");
    }
    public void Bilgi()
    {
        Console.WriteLine($"Personelin Adı ve Soyadı {Ad} {Soyad}. Sicil No : {SicilNo} ");
    }
}





















#region Fonksiyonlar
/*
 * string cevap = Topla("Merhaba ","Dunya");
Console.WriteLine(cevap);
string Topla(string a,string b)
{
   return a+b;
}

Yaz("Merhaba");
Yaz("Sefa");
void Yaz(string yazi)
{
    Console.WriteLine(yazi);
}
 */
#endregion


#region Donguler
/*




 for(int i = 1; i<10 ;i++)
{
    if(i==5)
    {
        break;
        continue;

    }
    Console.WriteLine(i);
}
 * for(int i = 0;i<sayilar.Length;i++)
{
    Console.WriteLine(sayilar[i]);
}

foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
 int i = 0;
do
{
    Console.WriteLine("Koşul sağlanmıyor fakat buna rağmen çalışıyorum " + i);
    i++;
}while(i<10);
 int i =2;
while(i<=100)
{
    Console.WriteLine(i);
    i+=2;
}
 for(int i = 2;i<=100;i+=2)
{
    Console.WriteLine(i);
}
 */
#endregion










#region Diziler
/*
 int sayi = 1;
string[] sayilar2 = {"Bir","İki","Üç"};
sayilar[0] = 4;

char[] harfler = {'a','b','c','d'};

Console.WriteLine(sayilar.GetLength(0));
 */
#endregion



#region MantıksalOperatörlerVeKararYapıları
/*
  var yas = 20;
   var ehliyetAlabilirMiyim = yas >= 18 ? "Ehliyet alabilir" : "Ehliyet alamaz";
Console.WriteLine(ehliyetAlabilirMiyim);
  switch(6)
{
    case 2:
        Console.WriteLine("İki");
        break;
    case 3:
        Console.WriteLine("Üç");
        break;
        default:
            Console.WriteLine("Burada bu sayıdan yok");
            break;
}
 if(10==11 && 10 != 11 ) //false true
{
    Console.WriteLine("merhaba");
}
//veya(||) operatör olduğunda true olduğu an içeriye girer
//ve(&&) operatör olduğunda false olduğun an içeriye girmez
  var yas = 18;
if(yas >= 18)
{
    Console.WriteLine("Ehliyet alabilir");
}else
{
    Console.WriteLine("Ehliyet alamaz");
}
 *if(17>18) //false
{
    Console.WriteLine("17 18den küçüktür");
}
else if(20> 25) //true
{
    Console.WriteLine("20 25ten küçüktür");
}
else
{
    Console.WriteLine("Hiç bir koşul sağlanmadı");
}

 *
 *  değişkenler karar yapısı
  Mantıksal Operatörler:
 && (koşullu ve) Mantıksal Operatörü
 || (koşullu veya) Mantıksal Operatörü

  İlişkisel Operatör:
 Küçüktür <
 Büyüktür >
 Küçük Eşittir <=
 Büyük Eşittir >=
 Eşittir ==
 Eşit Değildir !=
 */


#endregion
#region Operatörler
/*
 var cevap = 4!=4;
Console.WriteLine(cevap);
 Aritmetik Operatörler:
 Ekleme + 2+2
 Çıkarma - 5-3
 Bölme /
 Mod Alma %
 Çarpma *

 Tekli Operatörler:
 Arttırma ve Azaltma Operatörü (++ / --)
 Değil Operatörü (!)
 Atama Operatörleri:
 = Operatörü
 += Operatörü
 -= Operatörü
 *= Operatörü
 /= Operatörü




*/


#endregion

#region Degiskenler
//bool dogruMu = true;
//Console.WriteLine(dogruMu);
//Integer:tamsayı int sayi = 12;
//String:metin string metin = "NASILSIN";
//Double:ondalikliSayi double sayi = 12.3;
//Char:karekter char harf = 'A';
//Boolean:true veya false
#endregion

