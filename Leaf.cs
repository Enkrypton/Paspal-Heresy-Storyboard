using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Leaf : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            makeParticleGreen(897,24147);
            makeParticleRed(27897,49647); 
            makeLeaf(51897,72897);
		    
            
        }
        void makeLeaf(int Start, int End){
            var Beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
 
            for(double i = Start; i < End; i += Beat/8)
            {
                var Sprite = GetLayer("Particles").CreateSprite("sb/stage/leaf.png");
                
 
                Vector2 Position = new Vector2(-120, Random(-100, 480));
                Vector2 EndPosition = new Vector2(760, Position.Y + 200);
 
                Sprite.Move(i, i + 2000, Position, EndPosition);
                Sprite.Fade(i, i + 2000, 1, 1);
                Sprite.Fade(Start, End, 0.8, 0.8);

                Sprite.StartLoopGroup(i, 4);
                Sprite.ScaleVec(0, 500, 0.5, 0.5, 0.5, -0.5);
                Sprite.Rotate(0, 500, 0, Math.PI*2);
                Sprite.EndGroup();
                if(Random(0, 100)>50)
                    Sprite.Color(i, Color4.Green);
                    else Sprite.Color(i, Color4.LightGreen);
            }
        }

        void makeParticleGreen(int Start, int End){              
            var Beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
 
            for(double i = Start; i < End; i += Beat/8)
            {
                var P1 = GetLayer("Particles").CreateSprite("sb/stage/p.png");
                
 
                Vector2 Position = new Vector2(-120, Random(-100, 240));
                Vector2 EndPosition = new Vector2(760, Position.Y + 200);
 
                P1.Move(i, i + 2000, EndPosition, Position);
                P1.Fade(i, i + 2000, 1, 1);
                P1.Fade(Start, End, 0.8, 0.8);
                if(Random(0, 100)>50)
                    P1.Color(i, Color4.Green);
                    else P1.Color(i, Color4.LightGreen);
            }
        }
        void makeParticleRed(int Start, int End){              
            var Beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
 
            for(double i = Start; i < End; i += Beat/8)
            {
                var P1 = GetLayer("Particles").CreateSprite("sb/stage/p.png");
                
 
                Vector2 Position = new Vector2(-120, Random(-100, 400)); //old
                Vector2 EndPosition = new Vector2(760, Position.Y + 200);
 
                P1.Move(i, i + 2000, EndPosition, Position);
                P1.Fade(i, i + 2000, 1, 1);
                P1.Fade(Start, End, 0.8, 0.8);
                if(Random(0, 100)>50)
                    P1.Color(i, Color4.Red);
                    else P1.Color(i, Color4.OrangeRed);
            }
        }
    }
}
