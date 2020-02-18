class Program {
  public static void Main() {
    int temperature = 5;

    string desc;
    if (temperature < 0){
      desc = "Freezing";
    } else if (temperature < 15) {
      desc = "Chilly";
    } else if (temperature < 25) {
      desc = "Warm";
    } else {
      desc = "Hot";
    }
  }
}