class Program {
  public static void Main() {
    int num = 10;
    string s = "";
    while (num > 0)  {
      if (num % 2 == 0) {
        s = "0" + s;
      }else {
        s = "1" + s;
      }
      num = num / 2;
      
    }
  }
}