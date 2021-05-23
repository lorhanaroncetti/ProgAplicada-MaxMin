using System;

class MainClass {

  public static void PegaMaxMin(){

    int[] valores;
    int max = 0;
    int min = 0;

    int quantidade = int.Parse( Console.ReadLine() );

    valores = new int[quantidade];

    for( int i = 0; i < valores.Length; i++ ){
      int numero = int.Parse( Console.ReadLine() );
      valores[i] = numero;
    }

    Console.WriteLine();

    for( int i = 0; i < valores.Length; i++ ){
      if( i == 0 ){
        max = valores[i];
        min = valores[i];
      }else{
        if( valores[i] > max ){
          max = valores[i];
        }else if( valores[i] < min ){
          min = valores[i];
        }
      }

      Console.Write("{0}", valores[i]);
      if( i < valores.Length - 1){
        Console.Write(",");
      }
    }
    Console.WriteLine();
    Console.WriteLine("Max={0}, Min={1}", max, min);

  }

  public static void Main (string[] args) {
    PegaMaxMin();
  }
}
