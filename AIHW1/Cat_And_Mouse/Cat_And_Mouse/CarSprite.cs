using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Cat_And_Mouse
{
    class CarSprite : Sprite
    {
        Game currentGame;
        float slowDistance;
        float slowDistance2;
        float max_vel_y;

        public CarSprite(Game game)
            : base(game)
        {
            currentGame = game;
            accel_rate = 0.12f;
            slowDistance = 25;
            slowDistance2 = 100;
            friction = 0.04f;
        }
        public void update(GameTime gameTime, float targetX, float targetY)
        {
            Seek(targetX, targetY);
            Move();
            RotateTowardVelocity(targetX, targetY);
            if (MathHelper.Distance(x, targetX) < 20 && MathHelper.Distance(y, targetY) < 20)
            {
                //Game1.catWins = true;
            }
        }
        public void Seek(float targetX, float targetY)
        {
            if (MathHelper.Distance(x, targetX) < slowDistance)
            {
                max_vel = 0;
            }
            if (MathHelper.Distance(x, targetX) < slowDistance2)
            {
                max_vel = 10;
            }
            if (MathHelper.Distance(x, targetX) >= slowDistance2)
            {
                max_vel = 10;
            }
            if (targetX < x && vel_x > -max_vel)
            {
                //accelerate left
                vel_x -= accel_rate;
            }
            if (targetX > x && vel_x < max_vel)
            {
                //accelerate right
                vel_x += accel_rate;
            }

            //calculate friction
            if (vel_x > friction)
            {
                vel_x -= friction;
            }
            else if (vel_x < -friction)
            {
                vel_x += friction;
            }
            else
            {
                vel_x = 0;
            }

            //START Y DIRECTION CALCULATIONS
            if (MathHelper.Distance(y, targetY) < slowDistance)
            {
                max_vel_y = 0;
            }
            if (MathHelper.Distance(y, targetY) < slowDistance2)
            {
                max_vel_y = 2;
            }
            if (MathHelper.Distance(y, targetY) >= slowDistance2)
            {
                max_vel_y = 10;
            }
            if (targetY < y && vel_y > -max_vel_y)
            {
                //accelerate left
                vel_y -= accel_rate;
            }
            if (targetY > y && vel_y < max_vel_y)
            {
                //accelerate right
                vel_y += accel_rate;
            }

            //calculate friction
            if (vel_y > friction)
            {
                vel_y -= friction;
            }
            else if (vel_y < -friction)
            {
                vel_y += friction;
            }
            else
            {
                vel_y = 0;
            }
        }
        public void RotateTowardVelocity(float targetX, float targetY)
        {
            rot = -(float)Math.Atan2(vel_x, vel_y);
        }
        public void Move()
        {
            x += vel_x;
            y += vel_y;
        }
    }
}
