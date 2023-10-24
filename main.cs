using System;
using System.Collections.Generic;

class Program {
  
  private static List<int> ArithmeticProgression(int start, int step, int size) {
    
    List<int> result = new List<int>( new int[size] ); // One wouldn't use a list for a fixed size, just testing.
    result[0] = start;
    
    int stepDifference = step - start;
    int priorNum = start;

    for (int i = 1; i < result.Count; i++) {

      result[i] = stepDifference + priorNum;
      priorNum = result[i];
      
    }

    // foreach (int i in result) {
    //   Console.WriteLine(i);
    // }
    
    return result;
    
  }
  
  public static void Main (string[] args) {

    Console.Write("Entre com o primeiro termo: ");
    int start = Int32.Parse(Console.ReadLine());
    Console.Write("Entre com o segundo termo: ");
    int step = Int32.Parse(Console.ReadLine());
    Console.Write("Entre com o tamanho da sequência: ");
    int size = Int32.Parse(Console.ReadLine());
    
    List<int> result = ArithmeticProgression(start, step, size);

    Console.Write("PA: ");

    for (int i = 0; i < result.Count; i++) {
      Console.Write($"{result[i].ToString()} ");
    }

    Console.ReadLine();
    
    }
}