using System;

{
    //1
    ClassName.MemberName();
}
Console.WriteLine();
{
    //2
    string square = Square.GetName();
    Console.WriteLine(square);
}
Console.WriteLine();
{
    //3
    MyFirstClass.StaticMethod();
    MyFirstClass my = new MyFirstClass();
    my.InstanceMethod();
}
Console.WriteLine();
{
    //4
    Person person1 = new Person();
    person1.Name = "홍길동";
    person1.Age = 25;
    person1.Introduce();
    Person person2 = new Person();
    person2.Name = "김철수";
    person2.Age = 30;
    person2.Introduce();
}
Console.WriteLine();
{
    //5
    Point point1 = new Point();
    point1.x = 10;
    point1.y = 20;

    Point point2 = point1;
    point2.x = 100;
    Console.WriteLine($"point1.x = {point1.x}");
    Console.WriteLine($"point2.x = {point2.x}");
}
Console.WriteLine();
{
    //6
    PointStruct ps1 = new PointStruct();
    ps1.X = 10;
    PointStruct ps2 = ps1;
    ps2.X = 100;
    Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");

    PointClass pc1 = new PointClass();
    pc1.X = 10;
    PointClass pc2 = pc1;
    pc2.X = 100;
    Console.WriteLine($"클래스: pc1.X = {pc1.X}, pc2.X = {pc2.X}");
}
Console.WriteLine();
{
    //7
    Calculator cal = new Calculator();
    Console.WriteLine($"3 + 5 = {cal.Add(3, 5)}");
    Console.WriteLine($"3 * 5 = {cal.Multiply(3, 5)}");
}
Console.WriteLine();
{
    //8
    Player player1 = new Player();
    player1.ShowInfo();

    Player player2 = new Player("용사", 150);
    player2.ShowInfo();
}
Console.WriteLine();
{
    //9
}
// 클래스 선언
class ClassName
{
    // 멤버 메서드 선언
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}
class Square
{
    public static string GetName()
    {
        return "정사각형";
    }
}

class MyFirstClass
{
    public static void StaticMethod()
    {
        Console.WriteLine("[1] 정적 메서드");
    }
    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메서드");
    }
}
class Person
{
    public string Name;
    public int Age;
    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살입니다.");
    }
}

class Point
{
    public int x;
    public int y;
}

struct PointStruct
{
    public int X;
    public int Y;
}

class PointClass
{
    public int X;
    public int Y;
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Multiply(int a, int b) => a * b;
}
class Player
{
    private string _name;
    private int _health;
    public Player()
    {
        _name = "Unknown";
        _health = 100;
    }
    public Player(string name, int health)
    {
        _name = name;
        _health = health;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"이름: {_name}, 체력: {_health}");
    }
}
class Stock
{

}