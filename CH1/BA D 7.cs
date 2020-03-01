class Program {
  public static void Main() {
    int n = 4;
    var s = "";
    for ( int i = 0; i<n; i++){ 
      for (int j = 0; j < n; j++){  
        s = s + i + ":" + j + " ";
      }
      s = s + "\n";
    }
  }
}