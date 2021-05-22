using System;
using Microsoft.Xna.Framework;

namespace MonoGameRPG.Manager
{
    public abstract class Page
    {
        public int id;

        public Page(int id)
        {
            this.id = id;
        }

        public abstract void Init(RPG_Game g);

        public abstract void Update(GameTime gt, RPG_Game g);

        public abstract void Draw(RPG_Game g);
    }
}
