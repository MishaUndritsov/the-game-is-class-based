using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class log
    {
        public static void update(List < Character > AllCharacter)
        {
            Console.Clear();
            Console.WriteLine("_______");
            Console.WriteLine("команда 1");
            Console.WriteLine("HP паладина  800");
            Console.WriteLine("HP паладина" + AllCharacter[0].HP);
            Console.WriteLine("MP паладина  400");
            Console.WriteLine("MP паладина" + AllCharacter[0].MP);
            Console.WriteLine("damage паладина  80");
            Console.WriteLine("damage паладина" + AllCharacter[0].damage);

            Console.WriteLine("команда 1");
            Console.WriteLine("HP жреца  800");
            Console.WriteLine("HP жреца" + AllCharacter[1].HP);
            Console.WriteLine("MP жреца" + AllCharacter[1].MP);
            Console.WriteLine("damage жреца" + AllCharacter[1].damage);

            Console.WriteLine("команда 1");
            Console.WriteLine("HP шамана" + AllCharacter[2].HP);
            Console.WriteLine("MP шамана" + AllCharacter[2].MP);
            Console.WriteLine("damage шамана" + AllCharacter[2].damage);

            Console.WriteLine("команда 1");
            Console.WriteLine("HP разбойника" + AllCharacter[3].HP);
            Console.WriteLine("MP разбойника" + AllCharacter[3].MP);
            Console.WriteLine("damage разбойника" + AllCharacter[3].damage);


            Console.WriteLine("_______");
            Console.WriteLine("команда 2");
            Console.WriteLine("HP паладина  800");
            Console.WriteLine("HP паладина" + AllCharacter[0].HP);
            Console.WriteLine("MP паладина  400");
            Console.WriteLine("MP паладина" + AllCharacter[0].MP);
            Console.WriteLine("damage паладина  80");
            Console.WriteLine("damage паладина" + AllCharacter[0].damage);

            Console.WriteLine("команда 2");
            Console.WriteLine("HP жреца  800");
            Console.WriteLine("HP жреца" + AllCharacter[1].HP);
            Console.WriteLine("MP жреца" + AllCharacter[1].MP);
            Console.WriteLine("damage жреца" + AllCharacter[1].damage);

            Console.WriteLine("команда 2");
            Console.WriteLine("HP шамана" + AllCharacter[2].HP);
            Console.WriteLine("MP шамана" + AllCharacter[2].MP);
            Console.WriteLine("damage шамана" + AllCharacter[2].damage);

            Console.WriteLine("команда 2");
            Console.WriteLine("HP разбойника" + AllCharacter[3].HP);
            Console.WriteLine("MP разбойника" + AllCharacter[3].MP);
            Console.WriteLine("damage разбойника" + AllCharacter[3].damage);



           
        }
    }
}
