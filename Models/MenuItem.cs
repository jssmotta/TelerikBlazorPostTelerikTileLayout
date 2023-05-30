using System.Collections.Generic;

namespace TelerikBlazorApp1FormsAndTileLayout.Models
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}