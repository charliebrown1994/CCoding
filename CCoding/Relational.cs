using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CCoding
{
    internal class Relational
    {
        public void DoRelational()
        {
            // 관계연산자와 논리 연산자 사용
            // 관계형 연산자
            int x = 3;
            int y = 5;
            Console.WriteLine(x == y); // false
            Console.WriteLine(x != y); // true
            Console.WriteLine(x > y); // false
            Console.WriteLine(x >= y); // false
            Console.WriteLine(x <= y); // true
            Console.WriteLine(x < y); // true
            // == 연산자
            Console.WriteLine("AAA" == "aaa");
            // false
            // 논리 연산자
            // and &&, or ||, not !=
            // and 연산자 사용하기 
            Console.WriteLine(true && true);
            // true
            Console.WriteLine(true && false);
            // false
            Console.WriteLine($"true && true -> {true && true}");
            Console.WriteLine($"true && false -> {true && false}");
            Console.WriteLine($"false && true -> {false && true}");
            Console.WriteLine($"false && false -> {false && false}");
            // 출력 : ture, false, false, false
            // or 연산자 사용하기
            Console.WriteLine(false || true);
            // true
            Console.WriteLine(false || false);
            // false
            Console.WriteLine($"true || true -> {true || true}");
            Console.WriteLine($"true || false -> {true || false}");
            Console.WriteLine($"false || true -> {false || true}");
            Console.WriteLine($"false || false -> {false || false}");
            // 출력 : true, true, true, false
            // not 연산자 사용하기
            Console.WriteLine(1 == 1);
            // true
            Console.WriteLine(1 != 1);
            // false
            Console.WriteLine(!(1 == 1));
            // false
            Console.WriteLine(!(1 != 1));
            // true
            Console.WriteLine($"!true -> {!true}");
            // false
            Console.WriteLine($"!false -> {!false}");
            // true
            // 3가지 연산자 사용하기
            var i = 3;
            var j = 5;
            var r = false;
            r = (i == 3) && (j != 5);
            Console.WriteLine(r);

            r = (i != 3) || (j == 3);
            Console.WriteLine(r);

            r = (i > 5);
            Console.WriteLine("{0}", !r);

            Console.WriteLine(false && true);
            Console.WriteLine((1 ==1) || (1 != 1));
            Console.WriteLine(!(1 == 1));
            // 출력 : true, false, true, false, true, false

        }

    }
}
