class Program {
  public static void Main() {
    bool   a = true &&   false;
    bool   b = a  ||   true;
    bool   c =   !(a && b) ;

    string firstName = "John";
    
    string lastName = "Doe";
    string fullName = firstName + " " + lastName;

    int x = 5;
    int y = 10;
    int z = x + y;
    string zs = x.ToString()   + " + "   + y.ToString()   + " = "   + z.ToString()  ;
  }
}