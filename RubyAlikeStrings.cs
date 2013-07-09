using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyALikeStrings
{
    class RubyALikeStrings
    {
        public String myString { get; set; }
        public RubyALikeStrings(String mystr)
        {
            try {
                this.myString = mystr;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You must insert a string.\nError type: ArgumentNullException\nMessage: " + ex.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You must insert a string.\nError type: ArgumentNullException\nMessage: " + ex.ToString());
            }
        }

        /// <summary>
        /// Returns a reversed string from a given one.
        /// </summary>
        /// <returns>Reversed String</returns>
        public String reverse()
        {
            String result = String.Empty;
            for (int i = this.myString.Length - 1; i >= 0; i--)
            {
                result += this.myString[i];
            }
            return result;
        }

        /// <summary>
        /// Converts the string with underscore to a normal sentence
        /// </summary>
        /// <returns>Humanized String</returns>
        public String humanize()
        {
            String[] myStrings = this.myString.Split('_');
            myStrings[0] = myStrings[0].Substring(0, 1).ToUpper() + myStrings[0].Substring(1, myStrings[0].Length - 1);
            String result = String.Empty;
            foreach (String str in myStrings)
            {
                result += str + " ";
            }
            result = result.Substring(0, result.Length - 1);
            return result;
        }

        /// <summary>
        /// Replace all underscores from a given string to dashes.
        /// </summary>
        /// <returns>Dasherize String</returns>
        public String dasherize()
        {
            return this.myString.Replace("_", "-");
        }

        /// <summary>
        /// Convert all uppercase chars to lowercase.
        /// </summary>
        /// <returns>Underscored String</returns>
        public String underscore()
        {
            String result = String.Empty;
            for (int i = 0; i < this.myString.Length; i++)
            {
                if (i < this.myString.Length - 1)
                {
                    if (char.IsUpper(myString[i]))
                        result += char.ToLower(myString[i]);
                    else if (char.IsLower(myString[i]) && char.IsUpper(myString[i + 1]))
                        result += myString[i] + " ";
                    else
                        result += myString[i];
                }
                else
                    result += myString[i];
            }
            return result;
        }

        /// <summary>
        /// Converts the first char to uppercase of every word that are separated with a underscore from a given string.
        /// </summary>
        /// <returns>Camelized String</returns>
        public String camelize()
        {
            String[] myStrings = this.myString.Split('_');
            String result = String.Empty;
            foreach (String str in myStrings)
            {
                result += char.ToUpper(str[0]) + str.Substring(1, str.Length-1) + " ";
            }
            result = result.Substring(0, result.Length - 1);
            return result;
        }
    }
}
