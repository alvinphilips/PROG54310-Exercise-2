using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PROG54310_Exercise_2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private ControlYUV _controlYUV;
        private Effect _shader;
        private Model _teapot;
        private Matrix _perspective;
        private Matrix _view;
        private Texture2D _teapotTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Create and display the Tool window
            _controlYUV = new ControlYUV();
            _controlYUV.Show();

            // Set Matrices
            _perspective = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), GraphicsDevice.Viewport.AspectRatio, 0.1f, 100f);
            _view = Matrix.CreateLookAt(new Vector3(0, 0.25f, 1), new Vector3(0, 0.25f, 0), Vector3.Up);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _shader = Content.Load<Effect>("ShaderYUV");
            _teapot = Content.Load<Model>("teapot");
            _teapotTexture = Content.Load<Texture2D>("Smiley2");

            // Set MVP matrix
            // This is only set once here, since we have a single object and
            // neither our camera nor object is expected to move.
            _shader.Parameters["WorldViewProjection"].SetValue(_view * _perspective);

            // Set texture
            _shader.Parameters["Texture"].SetValue(_teapotTexture);

            foreach (var mesh in _teapot.Meshes)
            {
                foreach (var meshPart in mesh.MeshParts)
                {
                   meshPart.Effect = _shader;
                }
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Update YUV values and the Invert Colors state based on our form
            UpdateInvertAndYUV();

            base.Update(gameTime);
        }

        private void UpdateInvertAndYUV()
        {
            // Get Y, U, V values and scale it to a 0-1 range
            float y = _controlYUV.Y * 0.01f;
            float u = _controlYUV.U * 0.01f;
            float v = _controlYUV.V * 0.01f;

            // By default, we do not want to invert
            float invert = 0.0f;

            // Invert colors if checked
            if (_controlYUV.InvertColors)
            {
                invert = 1.0f;
            }

            // Vector3 wutg YUV values
            var yuv_factor = new Vector3(y, u, v);

            // Set uniforms
            _shader.Parameters["YUV_ratio"].SetValue(yuv_factor);
            _shader.Parameters["invert"].SetValue(invert);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            // Draw the teapot
            foreach (var mesh in _teapot.Meshes)
            {
                mesh.Draw();
            }

            base.Draw(gameTime);
        }
    }
}