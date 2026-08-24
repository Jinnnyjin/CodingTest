using System.ComponentModel.Design;

namespace _0824_나누어_떨어지는_숫자_배열
{
    /*
     * 문제 설명
    array의 각 element 중 divisor로 나누어 떨어지는 값을
    오름차순으로 정렬한 배열을 반환하는 함수, solution을 작성해주세요.
    divisor로 나누어 떨어지는 element가
    하나도 없다면 배열에 -1을 담아 반환하세요.

    제한사항
    arr은 자연수를 담은 배열입니다.
    정수 i, j에 대해 i ≠ j 이면 arr[i] ≠ arr[j] 입니다.
    divisor는 자연수입니다.
    array는 길이 1 이상인 배열입니다.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [5, 9, 7, 10];
            int divisor = 5;

            int[] answer = solution(arr, divisor);

            for (int i = 0; i < answer.Length; i ++)
            {
                Console.WriteLine(answer[i]);
            }
            
        }

        public static int[] solution(int[] arr, int divisor)
        {
            List<int> tmp = arr.ToList<int>();

            for(int i=0; i < arr.Length; i ++)
            {
                if(arr[i] % divisor != 0)
                {
                    tmp.Remove(arr[i]);
                }
            }

            if (tmp.Count == 0) tmp.Add(-1);

            tmp.Sort();

            int[] answer = tmp.ToArray();

            return answer;
        }
    }
}
