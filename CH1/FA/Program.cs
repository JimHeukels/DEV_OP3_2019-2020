using System;

namespace FA
{
    class Program{
  public static void Main() {
    int n = 4;
    string s = "";
    for (int i = 0; i < n; i++) {
      for (int j = 0; j < n; j++)
      {
        if (i % 2 == 0 && j % 2 == 0) {
          s += "*";
        } else if (i % 2 == 1 && j % 2 == 1) {
          s += "*";
        } else {
          s += "X";
        }
      }
      s += "\n";
      Console.WriteLine(s);  
    }

  }
}
}


