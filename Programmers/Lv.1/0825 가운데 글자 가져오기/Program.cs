using System.Text;

namespace _0825_가운데_글자_가져오기
{
    /*
        문제 설명
    단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요.
    단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.

    재한사항
    s는 길이가 1 이상, 100이하인 스트링입니다.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "qwer";
            Console.WriteLine(solution(s));
        }

        public static string solution(string s)
        {
            StringBuilder sb = new StringBuilder();
            int tmp = s.Length / 2;

            if (s.Length % 2 == 0)
            {
                sb.Append(s[tmp - 1]);
                sb.Append(s[tmp]);

                return sb.ToString();
            }
            else return s[tmp].ToString();

        }
    }
}
