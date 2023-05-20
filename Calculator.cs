using System;
class HelloWorld {
  static void Main() {
    try {
    Console.WriteLine("Введите первое число\n");
    decimal a = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Выберете действие: + - * /\n");
    string op = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите второе число\n");
    decimal b = Convert.ToDecimal(Console.ReadLine());
    switch (op) {
        case "+":Console.WriteLine(a+b);
        break;
        case "-":Console.WriteLine(a-b);
        break;
        case "*":Console.WriteLine(a*b);
        break;
        case "/":Console.WriteLine(a/b);
        break;
        default: Console.WriteLine("Некорректное действие!");
        break;
    }
  } 
  catch {
      Console.WriteLine("Некорректный тип!");
   }
  }
}
