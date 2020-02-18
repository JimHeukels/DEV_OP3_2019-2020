class Program {
  public static void Main() {
    int year = 2016;
    string result;
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ){
      result = year.ToString() + " is a leap year";
    }
    else{
      result = year.ToString() + " is not a leap year";
    }
    
  }
}