using System;
namespace gameProject
{
    internal class Program
    {
        static void DisplayCharacter(String name, int point, String job)
        {
            Console.WriteLine("==== 캐릭터 정보 ====");
            Console.WriteLine("이름: " + name);
            Console.WriteLine("포인트 : " + point);
            Console.WriteLine("직업: " + job);
        }
        static void Main(string[] args)
        {
            DisplayCharacter("슈퍼맨", 100, "기자");
            DisplayCharacter(job: "학생", point: 150, name: "스마트");

        }
    }
}