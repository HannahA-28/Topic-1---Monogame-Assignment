using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Reflection.Emit;

namespace Topic_1___Monogame_Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;
        Texture2D backgroundTexture;

        Texture2D cowTexture;
        Rectangle cowRect;

        Texture2D horseTexture;
        Rectangle horseRect;

        Texture2D pigTexture;
        Rectangle pigRect;

        Texture2D chickenTexture;
        Rectangle chickenRect;

        Texture2D sheepTexture;
        Rectangle sheepRect;

        Texture2D goatTexture;
        Rectangle goatRect;

        SpriteFont titleFont;

        float angle;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Window.Title = "Farm";
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            cowRect = new Rectangle(300, 300, 100, 100);
            horseRect = new Rectangle(0, 300, 175, 175);
            pigRect = new Rectangle(700, 400, 100, 100);
            chickenRect = new Rectangle(200, 480, 70, 70);
            sheepRect = new Rectangle(550, 300, 100, 100);
            goatRect = new Rectangle(500, 450, 120, 120);

            angle = 1.5f;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            backgroundTexture = Content.Load<Texture2D>("farm");
            cowTexture = Content.Load<Texture2D>("cow");
            horseTexture = Content.Load<Texture2D>("horse");
            pigTexture = Content.Load<Texture2D>("pig");
            chickenTexture = Content.Load<Texture2D>("chicken");
            sheepTexture = Content.Load<Texture2D>("sheep");
            goatTexture = Content.Load<Texture2D>("goat");

            titleFont = Content.Load<SpriteFont>("TitleFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture, window, Color.White);
            _spriteBatch.DrawString(titleFont, "Welcome to the farm!", new Vector2(75, 10), Color.Black);
            _spriteBatch.Draw(cowTexture, cowRect, null, Color.White, angle, new Vector2(cowTexture.Width / 3, cowTexture.Height / 3), SpriteEffects.None, 1f);
            _spriteBatch.Draw(horseTexture, horseRect, Color.White);
            _spriteBatch.Draw(pigTexture, pigRect, Color.White);
            _spriteBatch.Draw(chickenTexture, chickenRect, Color.White);
            _spriteBatch.Draw(sheepTexture, sheepRect, Color.White);
            _spriteBatch.Draw(goatTexture, goatRect, null, Color.White, angle, new Vector2(goatTexture.Width / 2, goatTexture.Height / 2), SpriteEffects.None, 1f);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
