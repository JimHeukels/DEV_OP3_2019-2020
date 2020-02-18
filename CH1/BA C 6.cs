class Program {
  public static void Main() {
    string fig = "";
    int width = 5;
    int height = 3;

    int i = 0;
    
    while(i < height){
      
      int j = 0;
      while(j  < width){
        fig += "*";
        j++;
      }
      i++;
      fig += "\n";
    }
  }
}