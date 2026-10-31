using System.Security.Principal;

var str1 = "ABABABAB";
var str2 = "ABAB";

var r = new Solution();


System.Console.WriteLine(r.GcdOfStrings(str1,str2));


public class Solution {
    public string GcdOfStrings(string str1, string str2) 
    {
        int i = 0;
        int j = 0;
        char previous1 = ' ';
        char previous2 = ' ';
        System.Text.StringBuilder prefix2 = new System.Text.StringBuilder("");
        System.Text.StringBuilder prefix1 = new System.Text.StringBuilder("");

        while (i < str1.Length && j < str2.Length)
        {
            char current1 = str1[i];
            char current2 = str2[j];

            
            if (str1[0] == current1 && str2[0] == current2 && i > 0 && j > 0)
            {
                break;
            }

            prefix1.Append(current1);
            prefix2.Append(current2);

                 

             previous1 = current1;
             previous2 = current2;
             i++;
             j++;

        }
        while (str1.Length > str2.Length && i < str1.Length)
        {
            
            char current1 = str1[i];
            

            if (str1[0] == current1 && i > 0)
            {
                break;
            }

                 prefix1.Append(current1);

             previous1 = current1;
             
             i++;
             
        }

        while (str2.Length > str1.Length && j < str2.Length)
        {
            
            char current2 = str2[j];

            if (str2[0] == current2 && j > 0)
            {
                break;
            }
                 
                 prefix2.Append(current2);
             
             previous2 = current2;
             
             j++;
        }
        

        for (int k = prefix1.Length; k < str1.Length; k++)
        {
            

            prefix1.Append(str1[k]);

            if (prefix1[1] == str1[k])
            {
                break;
            }
        }

        for (int p = prefix2.Length; p < str2.Length; p++)
        {
            

            prefix2.Append(str2[p]);
            
            if (prefix2[1] == str2[p])
            {
                break;
            }
        }



        if(prefix1.ToString() == prefix2.ToString() && prefix1.Length > 1 && prefix2.Length > 1)
        {
            return prefix1.ToString();
        }
        else if (prefix1.Length == 1 && prefix2.Length == 1 && str1.Length <= 1 && str2.Length <= 1)
        {
            return prefix1.ToString();
        }
        else
        {
            return "";
        }
    
    }
}