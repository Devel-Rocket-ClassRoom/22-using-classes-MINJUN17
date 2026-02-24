using System;
using System.Threading;

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
    Stock stock = new Stock();
    stock.CurrentPrice = 30;
    Console.WriteLine($"주가: {stock.CurrentPrice}");
}
Console.WriteLine();
{
    //10
    Product product = new Product();
    product.Name = "노트북";
    product.Price = 1500000;
    Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");
}
Console.WriteLine();
{
    //11
    Circle circle = new Circle();
    circle.Radius = 5;
    Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area:F2}");
}
Console.WriteLine();
{
    //12
    Monster monster1 = new Monster();
    monster1.Name = "고블린";
    monster1.Health = 50;

    Monster monster2 = new Monster
    {
        Name = "오크",
        Health = 100
    };

    monster1.Attack();
    monster2.Attack();
}
Console.WriteLine();
{
    //13
    Character hero = new Character
    {
        Name = "용사",
        Level = 10,
        Job = "전사"
    };

    Console.WriteLine($"{hero.Name} - Lv.{hero.Level} {hero.Job}");
}
Console.WriteLine();
{
    //14
    Random random = new Random();
    Console.WriteLine($"임의의 정수: {random.Next()}");
    Console.WriteLine($"0 ~ 4: {random.Next(5)}");
    Console.WriteLine($"1 ~ 9: {random.Next(1, 10)}");
    Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():F4}");
}
Console.WriteLine();
{
    //15
    Random random = new Random();

    Console.WriteLine("주사위를 5번 굴립니다:");
    for (int i = 0; i < 5; i++)
    {
        int dice = random.Next(1, 7);  // 1 ~ 6
        Console.WriteLine($"  {i + 1}번째: {dice}");
    }
}
{
    //16
    Person alice = new Person("Alice", 25);
    Person bob = new Person("Bob", 30);
    alice.SetFriend(bob);
}
class Person
{
    private string _name;
    private int _age;

    public Person(string name, int age)
    {
        // this로 필드와 매개변수 구분
        this._name = name;
        this._age = age;
    }

    public void SetFriend(Person friend)
    {
        // 현재 인스턴스를 다른 개체에 전달
        friend.PrintFriendInfo(this);
    }

    public void PrintFriendInfo(Person person)
    {
        Console.WriteLine($"{_name}의 친구는 {person._name}입니다.");
    }
}

class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string Job { get; set; }
}
class Circle
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;
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
    private decimal _currentPrice;

    // 전체 속성
    public decimal CurrentPrice
    {
        get { return _currentPrice; }
        set { _currentPrice = value; }
    }
}
class Product
{
    // 자동 구현 속성
    public string Name { get; set; }
    public decimal Price { get; set; }

    // 초기값이 있는 자동 구현 속성
    public int Quantity { get; set; } = 1;
}
class Monster
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다!");
    }
}