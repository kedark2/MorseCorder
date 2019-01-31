using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCoder
{
    class MorseCodeCore
    {
        private Char[] Letters = new Char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g',
          'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
          'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8',
          '9', ' '};
        private String[] MorseCode = new String[] {".-", "-...", "-.-.",
          "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", 
          "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", 
          "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---", 
          "...--", "....-", ".....", "-....", "--...", "---..", "----.", " "};

        public String ConvertTextToMorse(String text)
        {
            text = text.ToLower();
            String result = "";
            int index = -1;
            for (int i = 0; i <= text.Length - 1; i++)
            {
                index = Array.IndexOf(Letters, text[i]);
                if (index != -1)
                    result += MorseCode[index] + " ";
            }

            return result;
        }

        public String ConvertMorseToText(String text)
        {
            text = "@" + text.Replace(" ", "@@") + "@";
            int index = -1;
            foreach (Char c in Letters)
            {
                index = Array.IndexOf(Letters, c);
                text = text.Replace("@" + MorseCode[index] + "@", "@" + c.ToString() + "@");
            }

            return text.Replace("@@@@", " ").Replace("@", "");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MorseCodeCore Morse = new MorseCodeCore();

            Console.WriteLine("Converting from text to morse: ");
            String str = Morse.ConvertTextToMorse(" RAj jasdkj string to convert to morse code");
            Console.WriteLine(str);

            Console.WriteLine("\nConverting from morse to text: ");
            str = Morse.ConvertMorseToText("... - .-. .. -. --.   - ---   -.-." +
              " --- -. ...- . .-. -   -... .- -.-. -.-   - ---   - . -..- -");
            Console.WriteLine(str);

            Console.ReadKey();
            Console.Read();
        }
    }
}
