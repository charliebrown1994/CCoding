using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCoding
{
    internal class Assignment
    {
        public void Assign()
        {
            // 변수에 값을 대입하는 할당 연산자(=, +=, -=, *=, /=, %=)
            // 증감 연산자 (++, --)
            // 할당 연산자
            // = 는 값을 할당한다는 뜻입니다
            var name = "C#"; // name 변수에 문자열 대입
            var version = 8.0; // version 변수에 숫자 대입
            Console.WriteLine($"{name} {version}");
            // 출력 : C# 8
            // 변수 값 서로 바꾸기
            var i = 100;
            var j = 200;
            Console.WriteLine($"처음 : {i} {j}");
            var temp = i; // temp는 100
            i = j; // i는 200
            j = temp; // j 는 100
            Console.WriteLine($"변경 : {i} {j}");
            // 변수값 증가 시키기
            int num = 10;
            num = num + 1;
            Console.WriteLine(num);
            // 출력 : 11
            num = num - 1;
            Console.WriteLine(num);
            // 출력 : 9
            // 할당 연산자 축약형 사용
            int x = 3;
            int y = 3;
            x = x + 2; // 일반 형식
            y += 2; // 축양 형식
            Console.WriteLine($"{x} {y}");
            int a = 3;
            int b = 5;
            b += a;
            Console.WriteLine(b);
            b -= a;
            Console.WriteLine(b);
            // 증감 연산자
            int number = 100;
            ++number; // 1증가
            Console.WriteLine(number);
            number = -100;
            --number;
            Console.WriteLine(number);
            // 증감 연산자가 변수 앞에 붙으면 전위 증감 연산자 : 변수 값을 미리 증감한 후 나머지 연산을 진행
            // 증감 연산자가 변수 뒤에 붙으면 후위 증감 연산자 : 연산식을 먼저 실행한 후 나중에 변수 값을 증감
            int it = 3;
            int jt = ++it;
            Console.WriteLine(jt);
            // 출력 : 4
            int xt = 3;
            int yt = xt++;
            Console.WriteLine(yt); // 출력 : 3
            Console.WriteLine(xt); // 출력 : 4
        }
    }
}
