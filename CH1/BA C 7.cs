class Program {
  public static void Main() {
    int num = 5;
    int line = 0;
    
    string s = "";
    while ( line < num ) {  
      
      line ++;
      int x  = 0;
      
      while ( x < line ){
        x++;
        s += "*";
      }
      s += "\n";
    }
  }
}