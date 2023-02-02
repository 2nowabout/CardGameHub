using CardGameHub.Controls;
using CardGameHub.Gamestate;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameHub.Games.Skipbo.GameStates
{
    internal class SkipboLobbyState : State
    {
        private List<Button> buttons;
        private Texture2D texture;
        public SkipboLobbyState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            this._game = game;
            this._graphicsDevice = graphicsDevice;
            this._content = content;
            this.texture = content.Load<Texture2D>("Chips/chipBlue");
            SpriteFont ButtonFont = content.Load<SpriteFont>("Fonts/Font");

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
