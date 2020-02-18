class Program {
  public static void Main() {
    int num = 1234;
    string s = "";
    while (num > 0) {  
    int singlenum = num % 10;
    num = num / 10;
    s = s + singlenum + ".";
    }
  }
}