using System;
class HelloWorld {
    
  static void Main() {
       string flag = "ru";
      // ru - на русском, en - на английском
      switch (flag) {
          case "en": Console.WriteLine("Ozerova\nYana\nADB-20-02");
          break;
           case "ru": Console.WriteLine("Озерова\nЯна\nАДБ-20-02");
          break;
          default:
            Console.WriteLine("incorrect param");
            break;
      }
    
  }
}
