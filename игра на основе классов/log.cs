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
            Console.WriteLine("HP паладина" + AllCharacter[0].Hp);
            Console.WriteLine("MP паладина  400");
            Console.WriteLine("MP паладина" + AllCharacter[0].Mp);
            Console.WriteLine("damage паладина  80");
            Console.WriteLine("damage паладина" + AllCharacter[0].Damage);

            Console.WriteLine("команда 1");
            Console.WriteLine("HP жреца  800");
            Console.WriteLine("HP жреца" + AllCharacter[1].Hp);
            Console.WriteLine("MP жреца" + AllCharacter[1].Mp);
            Console.WriteLine("damage жреца" + AllCharacter[1].Damage);

            Console.WriteLine("команда 1");
            Console.WriteLine("HP шамана" + AllCharacter[2].Hp);
            Console.WriteLine("MP шамана" + AllCharacter[2].Mp);
            Console.WriteLine("damage шамана" + AllCharacter[2].Damage);

            Console.WriteLine("команда 1");
            Console.WriteLine("HP разбойника" + AllCharacter[3].Hp);
            Console.WriteLine("MP разбойника" + AllCharacter[3].Mp);
            Console.WriteLine("damage разбойника" + AllCharacter[3].Damage);


            Console.WriteLine("_______");
            Console.WriteLine("команда 2");
            Console.WriteLine("HP паладина  800");
            Console.WriteLine("HP паладина" + AllCharacter[0].Hp);
            Console.WriteLine("MP паладина  400");
            Console.WriteLine("MP паладина" + AllCharacter[0].Mp);
            Console.WriteLine("damage паладина  80");
            Console.WriteLine("damage паладина" + AllCharacter[0].Damage);

            Console.WriteLine("команда 2");
            Console.WriteLine("HP жреца  800");
            Console.WriteLine("HP жреца" + AllCharacter[1].Hp);
            Console.WriteLine("MP жреца" + AllCharacter[1].Mp);
            Console.WriteLine("damage жреца" + AllCharacter[1].Damage);

            Console.WriteLine("команда 2");
            Console.WriteLine("HP шамана" + AllCharacter[2].Hp);
            Console.WriteLine("MP шамана" + AllCharacter[2].Mp);
            Console.WriteLine("damage шамана" + AllCharacter[2].Damage);

            Console.WriteLine("команда 2");
            Console.WriteLine("HP разбойника" + AllCharacter[3].Hp);
            Console.WriteLine("MP разбойника" + AllCharacter[3].Mp);
            Console.WriteLine("damage разбойника" + AllCharacter[3].Damage);



           
        }
    }
}
