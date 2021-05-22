using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace MonoGameRPG.Manager
{
    public class PageManager
    {
        public List<Page> pages = new List<Page>();
        public int count { get { return pages.Count; } }
        public int selectedPage;
    }
}
