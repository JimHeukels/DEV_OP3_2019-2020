class Program {
  public static void Main() {
    int n = 16;
    string s = "";
    for (int i = 1; i <= n; i++) { 
      if ((i % 3 == 0 )&& (i % 5 == 0)) {
        s = s + "FizzBuzz ";
      } 
      
      else if (i % 3 == 0) {
        s = s + "Fizz ";
      } 
      
      else if (i % 5 == 0) {
        s = s + "Buzz ";
      }
      else s = s + i + " ";
    
    }    
  }
}