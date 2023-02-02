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
    internal class SkipboStartState : State
    {
        private List<Button> buttons;
        private Texture2D texture;
        public SkipboStartState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            this._game = game;
            this._graphicsDevice = graphicsDevice;
            this._content = content;
            this.texture = content.Load<Texture2D>("Chips/chipBlue");
            SpriteFont ButtonFont = content.Load<SpriteFont>("Fonts/Font");

            var offlineButton = new Button(texture, ButtonFont, 200, 200)
            {
                Position = new Vector2(400, 500),
                Text = "",
                Pencolour = Color.White
            };
            offlineButton.Click += offlineButton_Click;

            var onlineButton = new Button(texture, ButtonFont, 200, 200)
            {
                Position = new Vector2(500, 500),
                Text = "",
                Pencolour = Color.White
            };
            onlineButton.Click += onlineButton_Click;

            buttons = new List<Button>()
            {
                offlineButton,
                onlineButton
            };
        }

        private void onlineButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new SkipboLobbyState(_game, _graphicsDevice, _content));
        }

        private void offlineButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //draw texture
            //spriteBatch.Draw(texture, new Rectangle(100, 100, 100, 100), Color.White);
            foreach (Button button in buttons)
            {
                button.Draw(gameTime, spriteBatch);
            }
        }

        public override void PostUpdate(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (Button button in buttons)
            {
                button.Update(gameTime);
            }
        }
    }
}
