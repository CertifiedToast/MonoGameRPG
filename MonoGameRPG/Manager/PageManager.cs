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

        public void Update(GameTime gt, RPG_Game g) 
        {
            for (int i = 0; i < count; i++)
            {
                Page page = pages[i];
                if (page.id == selectedPage) { page.Update(gt, g); }
            }
        }
        public void Draw(RPG_Game g)
        {
            for (int i = 0; i < count; i++)
            {
                Page page = pages[i];
                if (page.id == selectedPage) { page.Draw(g); }
            }
        }
        public void Add(Page page, RPG_Game g) { pages.Add(page); page.Init(g); }
        public void Remove(Page page) { pages.Remove(page); }
        public void Clear() { pages.Clear(); }
    }
}
