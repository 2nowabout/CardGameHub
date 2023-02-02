using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGameHub.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CardGameHub.Gamestate
{
    internal class MainSceneState : State
    {
        private List<Button> buttons;
        public MainSceneState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            this._game = game;
            this._graphicsdevice = graphicsDevice;
            this._content = content;
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            throw new NotImplementedException();
        }

        public override void PostUpdate(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}