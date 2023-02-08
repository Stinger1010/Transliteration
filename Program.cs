using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Transliteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToLower();

            //Bulgarian alphabet
            string bgLowerAlphabet = "а б в г д е ж з и й к л м н о п р с т у ф х ц ч ш щ ь ъ ю я";
            //English alphabet
            string enLowerAlphabet = "a b v g d e zh z i y k l m n o p r s t u f h ts ch sh sht y a yu ya";

            string[] bulgarianLower = bgLowerAlphabet.Split(' ');
            string[] englishLower = enLowerAlphabet.Split(' ');

            string enName = "";

            for (int i = 0; i < name.Length; i++)
            {
                string bgLetter = name[i].ToString();
                if (bgLetter == " ")
                {
                    enName += " ";
                    continue;
                }
                int index = 0;

                for (int j = 0; j < bulgarianLower.Length; j++)
                {
                    if (bgLetter == bulgarianLower[j])
                    {
                        index = j;
                        break;
                    }

                    else
                    {
                        continue;
                    }
                }


                if (i == 0)
                {
                    if (englishLower[index] == "zh" ||
                        englishLower[index] == "ch" ||
                        englishLower[index] == "sh" ||
                        englishLower[index] == "sht" ||
                        englishLower[index] == "ts" ||
                        englishLower[index] == "yu" ||
                        englishLower[index] == "ya")
                    {
                        string firstLetter = englishLower[index].Substring(0, 1);
                        string secondLetter = englishLower[index].Substring(1);
                        enName += firstLetter.ToUpper();
                        enName += secondLetter;
                    }

                    else
                    {
                        enName += englishLower[index].ToUpper();
                    }
                }

                else if (enName != "")
                {
                    char temp = enName[enName.Length - 1];

                    if (temp == ' ')
                    {
                        if (englishLower[index] == "zh" ||
                            englishLower[index] == "ch" ||
                            englishLower[index] == "sh" ||
                            englishLower[index] == "sht" ||
                            englishLower[index] == "ts" ||
                            englishLower[index] == "yu" ||
                            englishLower[index] == "ya")
                        {
                            string firstLetter = englishLower[index].Substring(0, 1);
                            string secondLetter = englishLower[index].Substring(1);
                            enName += firstLetter.ToUpper();
                            enName += secondLetter;
                        }

                        else
                        {
                            enName += englishLower[index].ToUpper();
                        }
                    }

                    else
                    {
                        enName += englishLower[index];
                    }
                }
            }

            Console.WriteLine(enName);

        }
                
    }

}
