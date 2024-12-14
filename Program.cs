/*
1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanları console'a yazdırın.
2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
4.Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PatikaOdev1;

class Program
{
    static void Main(string[] args)
    {
        // Soru 1'in cevabı *******************************************************
        /*
        System.Console.Write("Lütfen pozitif bir sayı giriniz: ");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            System.Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
        }
        List<int> sayilar = new List<int>();
        System.Console.WriteLine($"Lütfen {n} adet pozitif sayı giriniz: ");
        for(int i = 0; i < n; i++)
         {
            int sayi;
            while(!int.TryParse(Console.ReadLine(),out sayi) || sayi <= 0)
            {
                System.Console.WriteLine("Lütfen pozitif tam sayı giriniz: ");
            }
            sayilar.Add(sayi);
         }
         System.Console.WriteLine("Çift sayılar: ");
         foreach(int sayi in sayilar)
         {
            if(sayi % 2 == 0)
            {
                System.Console.WriteLine(sayi);
            }
         }
         */
        // Soru 2'nin cevabı **************************************************************
        /*
        System.Console.Write("Lütfen pozitif bir sayı {n} giriniz: ");
        int n = int.Parse(Console.ReadLine());
        System.Console.Write("Lütfen pozitif bir sayı {m} giriniz: ");
        int m = int.Parse(Console.ReadLine());
        List<int> sayilar = new List<int>();
        System.Console.WriteLine($"Lütfen {n} adet pozitif sayı giriniz: ");
        for(int i = 0; i < n; i++)
        {
            int sayi;
            while(!int.TryParse(Console.ReadLine(),out sayi) || sayi <= 0)
            {
                System.Console.WriteLine("Lütfen pozitif tam sayı giriniz: ");
            }
            sayilar.Add(sayi);
        }
        System.Console.WriteLine($"\n {3} sayısına eşit yada tam bölünenler: ");
        foreach(int sayi in sayilar)
        {
            if(sayi % m == 0 || sayi == m)
            {
                System.Console.WriteLine(sayi);
            }
        }
        */
        // Soru 3'in cevabı *********************************************************
        /*
        System.Console.Write("Lütfen pozitif bir sayı {n} giriniz: ");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            System.Console.WriteLine("Lütfen pozitif sayı giriniz: ");
        }
        string[] kelimeler = new string[n];
        System.Console.WriteLine($"Lütfen {n} adet kelime giriniz: ");
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Kelime: {i+1}");
            kelimeler[i] = Console.ReadLine();
        }
        System.Console.WriteLine($"\nGirdiğiniz kelimeler (sondan başa doğru): ");
        for(int i = n - 1; i >= 0; i--)
        {
            System.Console.WriteLine(kelimeler[i]);
        }
        */
        // Soru 4'ün cevabı *****************************************************************
        
        Console.WriteLine("Lütfen bir cümle yazın: ");
        string cumle = Console.ReadLine();

        string[] kelimeler = cumle.Split(' ',StringSplitOptions.RemoveEmptyEntries);

        int kelimeSayisi = kelimeler.Length;

        int harfSayisi = 0;
        foreach(char c in cumle)
        {
            if(char.IsLetter(c))
            {
                harfSayisi++;
            }
        }
        System.Console.WriteLine($"Toplam kelime sayısı {kelimeSayisi}");
        System.Console.WriteLine($"Toplam harf sayısı {harfSayisi}"); 
    }
}