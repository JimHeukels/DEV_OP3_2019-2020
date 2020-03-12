class Program {
  public static void Main() {
    int len = 10;
    int [] array = new int [len];
    int j = 1;
    
    for( int i = 0 ; i < len; i++) {
        
        array[i] = j;
        j+=2;
    }

    string task = "update first and last";
    array[0] = 99;
    int lastIndex = len - 1;
    array[lastIndex] = 88;
  }
}