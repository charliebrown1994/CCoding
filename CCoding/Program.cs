namespace CCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 곱하기 연산자
            long i = 100;
            long j = 200;
            long k = i * j;
            Console.WriteLine(k);
            // 출력 : 20000;
            // 나누기 연산자
            double n = 1.5;
            double b = 0.5;
            double q = n / b;
            Console.WriteLine(q);
            // 출력 : 3
            // 나머지 연산
            int t = 5;
            int y = 3;
            int u = t % y;
            Console.WriteLine(u);
            // 출력 : 2
            // 나머지 연산 사용 %
            int h = 5;
            int f = 3;
            int p = h % f;
            Console.WriteLine(p);
            // 출력 : 2
            // 나머지 연산자 없이 나머지를 구하는 방법 : 
            // r = x - ( x / y ) * y
            // 여러 연산자 사용
            int a = 5;
            int v = 3;
            Console.WriteLine(a + v);
            Console.WriteLine(a - v);
            Console.WriteLine(a * v);
            Console.WriteLine(a / v);
            Console.WriteLine("{0} % {1} = {2}", a, v, (a % v));
            // 출력 : 8 
            //2
            //15
            //1
            //5 % 3 = 2
            // 문자열 연결 연산자
            // 더하기 연산자의 두 가지 기능을 다향하게 활용
            Console.WriteLine("Hello" + "World"); // 문자열 더하기
            Console.WriteLine("Hi" + " " + "everyone");

            Console.WriteLine("123" + "456"); // 숫자형 문자열은 문자열로 취급
            Console.WriteLine("123" + 456); // 문자열과 숫자형은 문자열로 취급
            Console.WriteLine(123 + "456"); 
            Console.WriteLine(123 + 456); // 숫자끼리는 산술 연산
            Console.WriteLine("123" + true); //bool 형식과 더하기는 문자열 취급
            //Console.WriteLine("123" - 456); //에러 발생 문자열에서는 정수를 뺄 수 없음
            int day = 28;
            Console.WriteLine("2월은" + day + "입니다."); // 암시적 변환 : 숫자형식 -> 문자열
            Console.WriteLine("2월은" + day.ToString() + "입니다."); // 명시적 변환 : 숫자형식 -> 문자열
            Console.WriteLine("2월은" + Convert.ToString(day) + "입니다."); // 명시적 변환 : 숫자형식 -> 문자열
        }
    }
}
