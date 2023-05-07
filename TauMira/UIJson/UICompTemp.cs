using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauMira.UIJson
{
    public class UICompTemp
    {

        public class StringLang
        {
            public string En { get; set; }
            public string Ar { get; set; }

            public string Get(App.Lang lang)
            {
                switch (lang)
                {
                    case App.Lang.AR:
                        return Ar.Length > 0 ? Ar : En;
                        break;
                    case App.Lang.EN:
                        return En;
                        break;
                    default:
                        return "";
                        break;
                }
            }
            public string Get()
            {
                return Get(App.lang);
            }
        }
        public List<Domain> Domains { get; set; }
        public class Domain
        {
            public string Type { get; set; }
            public StringLang Name { get; set; }
            public StringLang Tip { get; set; }
            public List<Value> Values { get; set; }
        }

        public class Value
        {
            public string Code { get; set; }
            public string Category { get; set; }
            public string Weight { get; set; }
            public StringLang Note { get; set; }
            public StringLang Descriptions { get; set; }

        }


    }
}
