using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CardGameHub.Controls;
using CardGameHub.Games.Skipbo.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace CardGameHub.Gamestate
{
    internal class MainSceneState : State
    {
        private List<Button> buttons;
        private Texture2D texture;
        public MainSceneState(Game1 game, GraphicsDevice graphicsDevice, ContentManager content) : base(game, graphicsDevice, content)
        {
            this._game = game;
            this._graphicsDevice = graphicsDevice;
            this._content = content;
            this.texture = content.Load<Texture2D>("Chips/chipBlue");
            SpriteFont ButtonFont = content.Load<SpriteFont>("Fonts/Font");


            var pokerButton = new Button(texture, ButtonFont, 200, 200)
            {
                Position = new Vector2(400, 500),
                Text = "",
                Pencolour = Color.White
            };
            pokerButton.Click += pokerButton_Click;

            var skipboButton = new Button(texture, ButtonFont, 200, 200)
            {
                Position = new Vector2(1200, 500),
                Text = "",
                Pencolour = Color.White
            };
            skipboButton.Click += skipboButton_Click;

            buttons = new List<Button>()
            {
                pokerButton,
                skipboButton
            };
        }
        //game.ChangeState(new SkipboStartState(game, graphicsDevice, content));

        private void skipboButton_Click(object sender, EventArgs e)
        {
            _game.ChangeState(new SkipboStartState(_game, _graphicsDevice, _content));
        }

        private void pokerButton_Click(object sender, EventArgs e)
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