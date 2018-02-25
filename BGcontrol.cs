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
    public class BGcontrol : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            //Delet original bg
            var backgroundog = GetLayer("Background").CreateSprite("alejandro-olmedo-soleado-nuevo-definitivosmall.jpg");
            backgroundog.Fade(0,0);
            //Init bgs
            var bkg = GetLayer("Background").CreateSprite("sb/bgs/bg.jpg", OsbOrigin.Centre);
            var vig = GetLayer("Background_Top").CreateSprite("sb/stage/vignette.png");
            var man = GetLayer("Background").CreateSprite("sb/bgs/dude_with_stick.jpg", OsbOrigin.Centre);
            var dragon = GetLayer("Background").CreateSprite("sb/bgs/sky_lizard.jpg", OsbOrigin.Centre);

            vig.Scale(0,480.0/1080);
            vig.Fade(0,24147,1,1);
            vig.Fade(24147,26397,1,0);

            man.Scale(0, 480.0/480);
            man.Fade(0,897,0,1);
            man.Fade(897,24147,1,1);
            man.Fade(24147,26397,1,0);
            man.MoveX(0,26397,450,180);

            Flash(27897);

            vig.Fade(27897,51897,1,1);

            dragon.Fade(0,0);
            dragon.MoveY(0,140);
            dragon.Scale(0, 480.0/550);
            dragon.Fade(27897,51147,1,1);
            dragon.Fade(51147,51897,1,0);
            dragon.MoveX(27897,51897,420,210);

            Flash(51897);

            bkg.Scale(0, 480.0/830);
            bkg.Fade(0,0);
            bkg.Fade(51897,75897,1,1);
            bkg.Fade(75897,81897,1,0);
            bkg.Move(51897,81897,370,250,290,230);   
        }
        void Flash (int Start){
            var Flash = GetLayer("Background").CreateSprite("sb/stage/flash.png");
            Flash.Fade(OsbEasing.OutCubic, Start, Start + 1200, 1, 0);
        }
    }
}
