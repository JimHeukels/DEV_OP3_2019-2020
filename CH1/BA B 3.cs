class Program {
  public static void Main() {
    int x = 6;
    int y = 5;
    string result;
    if (x > y) {
      result = "x is biggest";
    } else if (y > x) {
      result = "y is biggest";
    } else if (x == y) {
      result = "x and y are equal";
    }
  }
}