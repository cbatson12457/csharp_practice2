using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] simpleArray = new int[6]{1, 1, 2, 3, 5, 8};

    for(int i=0; i<simpleArray.Length; i++){
      Console.WriteLine(simpleArray[i]);
    }
  }
}