using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public class Sounds
    {
        public void potatos()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("../../SParty.wav");
            player.Play();
        }
    }
}
