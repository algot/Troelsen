using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_UnsafeCode
{
  class Program
  {
    static void Main(string[] args)
    {
      unsafe
      {
        int myInt = 10;
        // Нормально, мы в небезопасном контексте
        SquareIntPointer(&myInt);
        Console.WriteLine("myInt: {0}", myInt);
      }

      PrintValueAndAdress();

      int i = 10, j = 20;

      // Небезопасный обмен
      Console.WriteLine("Unsafe swap");
      Console.WriteLine("Values before swap: i = {0}, j= {1}", i, j);
      unsafe { UnsafeSwap(&i, &j); }
      Console.WriteLine("Values after swap: i = {0}, j= {1}", i, j);


      UsePointerToPoint();

      UnsafeStackAlloc();

      UseAndPinPoint();

      UseSizeOfOperator();
    }

    unsafe static void SquareIntPointer(int* myIntPointer)
    {
      *myIntPointer *= *myIntPointer;
    }
    unsafe static void PrintValueAndAdress()
    {
      int myInt;
      // Определить указатель на int и присвоить ему адрес myInt
      int* ptrToMyInt = &myInt;

      // Присвоить значение myInt, используя обращение через указатель.
      *ptrToMyInt = 123;

      // Вывести на консоль некоторые значения
      Console.WriteLine("Value of myInt {0}", myInt);
      Console.WriteLine("Address of myInt {0}", (int)&ptrToMyInt);
    }
    unsafe public static void UnsafeSwap(int* i, int* j)
    {
      int temp = *i;
      *i = *j;
      *j = temp;
    }
    struct Point
    {
      public int x;
      public int y;

      public override string ToString()
      {
        return string.Format("({0}, {1})", x, y);
      }
    }
    unsafe static void UsePointerToPoint()
    {
      // Доступ к членам через указатель
      Point point;
      Point* p = &point;
      p->x = 100;
      p->y = 200;

      Console.WriteLine(p->ToString());

      // Доступ к членам через разыменованный указатель
      Point point2;
      Point* p2 = &point2;
      (*p2).x = 100;
      (*p2).y = 200;
      Console.WriteLine((*p2).ToString());
    }
    unsafe static void UnsafeStackAlloc()
    {
      char* p = stackalloc char[256];
      for (int i = 0; i < 256; i++)
      {
        p[i] = (char) i;
      }
    }
    class PointRef
    {
      public int x;
      public int y;

      public override string ToString()
      {
        return string.Format("({0}, {1})", x, y);
      }
    }
    unsafe public static void UseAndPinPoint()
    {
      PointRef pt = new PointRef {x = 5, y = 6};

      // Закрепить указатель pt на месте, чтобы он не смог быть
      // перемещен или собран сборщиком мусора
      fixed (int* p = &pt.x)
      {
        // Использовать здесь переменную int*!
      }

      // Указатель pt теперь не закреплен и готов к сборке мусора
      Console.WriteLine("Point is: {0}", pt);
    }

    unsafe static void UseSizeOfOperator()
    {
      Console.WriteLine("The size of short is {0}.", sizeof(short));
      Console.WriteLine("The size of int is {0}.", sizeof(int));
      Console.WriteLine("The size of long is {0}.", sizeof(long));
      
    }
  }
}
