﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputControllerMG
{
    class AlienInputController: Alien
    {
        //this class depends on PlayerController
        protected AlienController controller;

        public AlienInputController(Game game)
            : base(game)
        {

            controller = new AlienController(game);
            game.Components.Add(controller);

        }



        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {


            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {

            //Elapsed time since last update
            float time = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            base.Update(gameTime);
        }

        protected override void UpdatePacMan(float lastUpdateTime, GameTime gameTime)
        {
            controller.Update(gameTime);
            this.Rotate = (float)MathHelper.ToDegrees(this.controller.Rotate - (float)(Math.PI / 2));


            this.UpdateMovePacMan();

            //Keep PacMan On Screen
            if (Location.X > this.Game.GraphicsDevice.Viewport.Width - (spriteTexture.Width / 2))
                Location.X = this.Game.GraphicsDevice.Viewport.Width - (spriteTexture.Width / 2);

            if (Location.X < (spriteTexture.Width / 2))
                Location.X = (spriteTexture.Width / 2);



            base.UpdatePacMan(lastUpdateTime, gameTime);
        }

        private void UpdateMovePacMan()
        {
            //Time corrected move. MOves PacMan By PacManDiv every Second
            Location += ((this.controller.Direction * (lastUpdateTime / 1000)) * Speed);      //Simple Move PacMan by PacManDir

            //Pac man is moving form input
            if (this.controller.Direction.Length() > 0)
            {
                
            }
            else
            {
                
            }

        }
    }
}
