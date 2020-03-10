using System;

namespace FavThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = new Code("AWS", "Jquery");
            code.LoadSite();
            code.ClearDom();
        }
    }
}
