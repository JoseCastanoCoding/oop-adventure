using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure.Source.Text
{
    public static class Text // static keyword means I can access the class without creating an instance of it. There should only be one reference to this throughout the entire system
    {
        private static Language _language; // private field named '_language', which is a property of the class / There's only on reference to an instantiated language

        public static Language Language // this constructor forces only a single instance of language to be created. This is a reference to the Language class
        {
            get
            {
                if (_language == null)
                    throw new Exception("No language loaded.");

                return _language;
                
            }
        }
        public static void loadLanguage(Language language)
        {
            _language = language;
        }
    }
}
