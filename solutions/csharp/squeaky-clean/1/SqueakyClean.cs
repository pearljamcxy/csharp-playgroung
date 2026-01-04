using System.Security.Cryptography.X509Certificates;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool capitalizeNext = false;

        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                sb.Append('_');
                continue;
            }

            if (char.IsControl(c)) //为什么是这么用的char.IsControl(c)？
            {
                sb.Append("CTRL");
                continue;
            }

            if (c == '-')
            {
                capitalizeNext = true;
                continue;
            }

            if (c >= 'α' && c <= 'ω')
            {
               continue; 
            }

            if (!char.IsLetter(c))
            {
                continue;
            }
           
            if (capitalizeNext)
            {
                char C = char.ToUpper(c);
                sb.Append(C);
                capitalizeNext = false;
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}        
