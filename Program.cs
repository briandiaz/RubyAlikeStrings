using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyALikeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            RubyALikeStrings ras = new RubyALikeStrings("YoUsoWindows");
            Console.WriteLine(ras.underscore());
            ras = new RubyALikeStrings("php_must_be_banned");
            Console.WriteLine(ras.dasherize());
            ras = new RubyALikeStrings("ruby_developer");
            Console.WriteLine(ras.camelize());
            ras = new RubyALikeStrings("soy_dominicano");
            Console.WriteLine(ras.humanize());
            ras = new RubyALikeStrings("Jimmy");
            Console.WriteLine(ras.reverse());
            Console.ReadKey();
        }
    }
}
