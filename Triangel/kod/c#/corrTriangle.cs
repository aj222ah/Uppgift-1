using System;
using System.Linq;
using System.Collections.Generic;

public struct Point { 
  public int x, y;
  
  public Point(int a, int b) {
    x = a;
    y = b;
  }
}

public class Triangle {
  double[] sides;

  public Triangle(double a, double b, double c) {
      // Testar för värden under eller lika med 0 == ogiltig triangel
      if (a <= 0 || b <= 0 || c <= 0)
      {
          throw new ArgumentOutOfRangeException("Triangelns sidor måste vara längre än 0.");
      }

      // Testar triangelolikheten för validering av giltiga/ogiltiga trianglar
      if ((a < (b + c)) && (a > Math.Abs(b - c)))
      {
          sides = new double[] { a, b, c };
      }
      else
      {
          throw new ArgumentOutOfRangeException("Detta är en ogiltig triangel.");
      }
  } 

  public Triangle(double[] s) {
    sides = new double[s.Length];
    for(int i=0;i<s.Length;i++)
      sides[i]=s[i];
  }

  // Matten ser fel ut i mina ögon, har ändrat men är osäker på om jag har rätt
  public Triangle(Point a, Point b, Point c) {
    sides = new double[3];
    sides[0] = Math.Sqrt(Math.Pow((double)(b.x - a.x), 2.0) + Math.Pow((double)(b.y - a.y), 2.0));
    sides[1] = Math.Sqrt(Math.Pow((double)(b.x - c.x), 2.0) + Math.Pow((double)(b.y - c.y), 2.0)); //Var b.x - a.x
    sides[2] = Math.Sqrt(Math.Pow((double)(c.x - a.x), 2.0) + Math.Pow((double)(c.y - a.y), 2.0)); //Var c.x - a.x
  }

  // Matten ser fel ut i mina ögon, har ändrat men är osäker på om jag har rätt
  public Triangle(Point[] s) {
    sides = new double[s.Length];
    sides[0] = Math.Sqrt(Math.Pow((double)(s[1].x - s[0].x), 2.0) + Math.Pow((double)(s[1].y - s[0].y), 2.0));
    sides[1] = Math.Sqrt(Math.Pow((double)(s[1].x - s[2].x), 2.0) + Math.Pow((double)(s[1].y - s[2].y), 2.0)); //Var s[1].x - s[2].x
    sides[2] = Math.Sqrt(Math.Pow((double)(s[2].x - s[0].x), 2.0) + Math.Pow((double)(s[2].y - s[0].y), 2.0)); //Var s[2].x - s[0].x
  }

  private int uniqueSides() {
    return sides.Distinct<double>().Count();
  }

  // Ändrat uniqueSides() == 1 till == 3 för att få rätt antal olika sidor
  public bool isScalene() {
    if(uniqueSides()==3)
      return true;
    return false;
  }

  // Liksidig triangel Ändrat uniqueSides() == 3 till == 1 för att få rätt antal olika sidor
  public bool isEquilateral() {
    if(uniqueSides()==1)
      return true;
    return false;
  }

  // Likbent triangel
  public bool isIsosceles() {
    if(uniqueSides()==2)
      return true;
    return false;
  }
}

/* Exempel på användning: */
/* class Program { */
/*   static void Main(string[] args) { */
/*     double[] input = new double[3]; */
/*     for(int i=0;i<3;i++) */
/*       input[i]=double.Parse(args[i]); */
    
/*     Triangle t = new Triangle(input); */

/*     if(t.isScalene()) Console.WriteLine("Triangeln har inga lika sidor"); */
/*     if(t.isEquilateral()) Console.WriteLine("Triangeln är liksidig"); */
/*     if(t.isIsosceles()) Console.WriteLine("Triangeln är likbent"); */
/*  } */
/* } */
