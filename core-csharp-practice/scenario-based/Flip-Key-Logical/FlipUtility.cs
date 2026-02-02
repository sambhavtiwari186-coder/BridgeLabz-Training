using System.Text;
using System.Linq;
public class FlipUtiity
{
    public string CleanseAndInvert(string input)
    {
        if(input.Length==0 || input.Length < 6)
        {
            return " ";
        }
        if((input.Any(char.IsDigit)) ||  input.Any(ch => !char.IsLetterOrDigit(ch)))
        {
            return " ";
        } 
        input = input.ToLower();
        StringBuilder sb = new StringBuilder();
        int index=0;
        for(int i=0; i < input.Length; i++)
        {
            int a = Convert.ToInt32(input[i]);
            if (a%2==0)
            {
              continue;
            }
          sb.Append(input[i]);
          index++;
        }
        for(int i = 0; i < index; i++)
        {
            if (i % 2 == 0)
            {
               sb[i] = char.ToUpper(sb[i]);
            }
        }
        string output = sb.ToString();
         output = new string(output.Reverse().ToArray());
         return output;
    }
}