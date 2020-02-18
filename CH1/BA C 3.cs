class Program {
  public static void Main() {
    int limit = 10;
    string s = "";
    while (limit >= 0) {   
      s = s + limit + " ";
      limit = limit - 2;
    }
  }
}