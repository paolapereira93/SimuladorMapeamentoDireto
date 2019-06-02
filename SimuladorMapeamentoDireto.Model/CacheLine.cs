using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMapeamentoDireto.Model
{
    public class CacheLine
    {
        public bool Validity { get; set; }
        public int Tag { get; set; }
        public string Content { get; set; }

        public CacheLine()
        {
            this.Validity = false;
            this.Tag = -1;
            this.Content = null;
        }
        public override string ToString()
        {
            int v = 0;
            if (Validity) 
                v = 1;

            string tag = "";
            if (this.Tag >= 0)
                tag = "" + this.Tag;

            return v + " " + tag + " " + this.Content;
        }
    }
}
//linkhttps://msdn.microsoft.com/en-us/library/cc221403(v=vs.95).aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-9