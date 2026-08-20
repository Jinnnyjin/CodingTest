namespace _0819_내적
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { -3, -1, 0, 2 };

            int answer = solution(a, b);
            Console.WriteLine(answer);
        }

        public static int solution(int[] a, int[] b)
        {
            int answer = 0;

            for(int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }

            return answer;
        }
    }
}
