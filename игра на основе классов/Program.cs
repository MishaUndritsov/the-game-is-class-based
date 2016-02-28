using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character paladin1 = new paladin(800, 400, 80);
            Character Preast1 = new Preast(400, 900, 300);
            Character Shaman1 = new Shaman(500, 70, 50);
            Character Rogue1 = new Rogue(360, 500, 100);
            Character paladin2 = new paladin(800, 400, 80);
            Character Preast2 = new Preast(400, 900, 300);
            Character Shaman2 = new Shaman(900, 700, 50);
            Character Rogue2 = new Rogue(360, 500, 100);

            List<Character> AllCharacter = new List<Character>();

            AllCharacter.Add(paladin1);
            AllCharacter.Add(Preast1);
            AllCharacter.Add(Shaman1);
            AllCharacter.Add(Rogue1);
            AllCharacter.Add(paladin2);
            AllCharacter.Add(Preast2);
            AllCharacter.Add(Shaman2);
            AllCharacter.Add(Rogue2);
        }
    }
}

