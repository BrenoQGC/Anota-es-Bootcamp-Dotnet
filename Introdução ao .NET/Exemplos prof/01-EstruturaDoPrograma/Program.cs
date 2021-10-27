using System;

class TESTE {
    static void Main () {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
       //Termine o código 
       // if (1 <= m <= 40 && 1 <= n <= 40)
       // {
          if (m>=n)
          {
             m=m-n;
            
          }else{
           m=n-m;
          }
          
          Console.WriteLine("{0}",m);
     //   }else
     //   {
       //   Console.WriteLine("Numero inserido invalido");
    //    }
        
    }
}