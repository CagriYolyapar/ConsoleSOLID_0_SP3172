// See https://aka.ms/new-console-template for more information
using ConsoleSOLID_0.Models.Entities;

Console.WriteLine("Hello, World!");



/*
 SOLID

Single Responsibility => Tekil sorumluluk yapılarımız icin cok önemlidir...Hem onların yonetilmesi, hem duzenli olarak üzerinde calısılması hem de performanslı davranabilmeleri icin yapılarımız tek bir sorumluluk almalıdır...

Open Closed => 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */

Karakter k = new Karakter();
k.AddStrategy(new MeleeStrategy());
k.AddStrategy(new RangedStrategy());
k.AddStrategy(new HorseStrategy());