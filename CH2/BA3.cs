class Program {
  public static void Main() {
    int[] arr = new int[]{list};
    int n = 5;
    int count = 0;
    for (int i = 0; i < arr.Length; i++){

      if (arr[i] > n){
        count += 1;
      };
    }
    string s = "There are " + count + " values that are greater than " + n;
  
  }
}