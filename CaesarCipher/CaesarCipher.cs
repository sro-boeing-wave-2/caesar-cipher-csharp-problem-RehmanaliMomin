using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string s = "";
            int a;
            int x;
            StringBuilder sb = new StringBuilder();

            string alpha = "abcdefghijklmnopqrstuvwxyz";
            string alphaCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < text.Length; i++)
            {
                if (Regex.IsMatch(text[i].ToString(), @"^[a-z]+$"))
                {
                    a = alpha.IndexOf(text[i]);
                    x = (a + shiftKey) % 26;
                    sb.Append(alpha[x]);
                }
                else if (Regex.IsMatch(text[i].ToString(), @"^[A-Z]+$"))
                {
                    a = alphaCaps.IndexOf(text[i]);
                    x = (a + shiftKey) % 26;
                    sb.Append(alphaCaps[x]);
                }
                else
                {
                    sb.Append(text[i]);
                }


            }



            return sb.ToString();

        }
    }
}
