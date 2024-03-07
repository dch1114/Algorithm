 public class Solution
 {
        public string solution(string s)
        {
            string answer = "";
            char[] str_arr = s.ToCharArray();
            
            int checker = 0;     
            for (int i = 0; i < str_arr.Length; ++i)
            {
                if (str_arr[i] == ' ')
                {
                    checker = 0;
                    continue;
                }
                if (checker % 2 == 0)
                {
                    str_arr[i] = char.ToUpper(str_arr[i]);
                }
                else
                {
                    str_arr[i] = char.ToLower(str_arr[i]);
                }
                checker++;
            }
            
            answer = new string(str_arr);
            return answer;
        }
}