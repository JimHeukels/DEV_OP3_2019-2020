//SAMUEL
class Program {
  public static void Main() {
    double side1 = 6.0;
    double side2 = 6.0;
    double side3 = 6.0;
    
    string result = "Neither equilateral or isosceles";
    if (side1 == side2 && side1 == side3){
      result = "Equilateral and isosceles";
    } else if (side1 == side2 || side2 == side3 || side1 == side3){
      result = "Isosceles";
     
    }
    
  }
}

//JIM
class Program {
  public static void Main() {
    double side1 = 6.0;
    double side2 = 6.0;
    double side3 = 6.0;
    
    string result;
    if (side1 == side2 && side1 == side3){
      result = "Equilateral and isosceles";
    } else if (side1 == side2 || side2 == side3 || side1 == side3){
      result = "Isosceles";
     
    } else {
        result = "Neither equilateral or isosceles";
    }
    
  }
}

//het verschil zit in de standaard waarde van result. In de versie van Sam is de standaard waarde al "Neither equilateral or isosceles"
//wanneer binnen de code dan niet aan de if statements wordt voldaan, wordt deze standaard waarde nooit aangepast.
//Hierdoor is het dus mogelijk om de opdracht te maken, zonder de laatste else statement