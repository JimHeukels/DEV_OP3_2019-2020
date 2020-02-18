class Program {
  public static void Main() {
    int age = 3;
    string result;
    
    if (age < 0) {
      result = "Invalid age";
    } else if (age < 12) {
      result = "Child";
    } else if (age < 19) {
      result = "Teenager";
    } else if (age < 125) {
      result = "Adult";
    } else if (age > 125) {
      result = "Invalid age";
    }
  }
}