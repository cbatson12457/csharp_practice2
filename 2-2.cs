using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    var myList = new List<string>{"blades", "bounce", "life", "sucks", "empty", "dirty", "green", "unfair", "tested", "heir", "two", "help"};

    foreach(var a in myList){
      var b=a;
      if(b.Length < 6 && b.Length > 4){
    Console.WriteLine(a);
      }
    }
  }
}