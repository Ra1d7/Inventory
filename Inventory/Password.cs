using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Password
    {
        public string? text { get; set; } = null;
        public bool iscorrect { get; set; } = false;
        public bool isLong { get; set; } = false;
        public bool hasDigits { get; set; } = false;
        public bool hasSymbols { get; set; } = false;
        private string symbols = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        public Password(string text)
        {
            if(text is string) { this.text = text; }
            if(text.Length >= 6) { isLong= true; }
            if(text.Any(x => char.IsDigit(x)) ) { hasDigits= true; }
            if (text.Any(x => symbols.Contains(x))) { hasSymbols = true; }
            if(isLong && hasDigits &hasSymbols) { iscorrect = true; }
        }
    }
}
