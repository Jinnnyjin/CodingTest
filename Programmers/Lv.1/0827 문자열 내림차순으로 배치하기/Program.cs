namespace _0827_문자열_내림차순으로_배치하기
{
    /*
     * 문제 설명
    문자열 s에 나타나는 문자를 큰것부터 작은 순으로 정렬해
    새로운 문자열을 리턴하는 함수, solution을 완성해주세요.
        s는 영문 대소문자로만 구성되어 있으며,
    대문자는 소문자보다 작은 것으로 간주합니다.

        제한 사항
        str은 길이 1 이상인 문자열입니다.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("Zbcdefg"));
        }

        private static string solution(string s)
        {
            // 이렇게하면 Linq라 메모리를 좀더 먹음
            return new string(s.OrderByDescending(c => c).ToArray());

            // 이 방법이 가볍고 빠름
            char[] tmp = s.ToCharArray();
            Array.Sort(tmp);
            Array.Reverse(tmp);

            return new string(tmp);
        }
    }
}
