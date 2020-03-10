using System;
using System.Collections.Generic;
using System.Text;

namespace FavThings
{
    class Code
    {
        public string Tech { get; set; }
        public string CSS { get; set; }

        public Code(string tech, string css)
        {
            Tech = tech;
            CSS = css;
        }

        public void LoadSite()
        {
            Console.WriteLine($"We used {Tech}");
        }

        public void ClearDom()
        {
            Console.WriteLine($"We used {CSS} to clear the page");
        }
    }
}
