class Program {
  public static void Main() {
    int start = 6;
    int incr = 4;
    int end = 15;

    var res = "";
    for (int x  = start; x < end; x += incr)  {
      res = res + ">" + x;
    }
  }
}