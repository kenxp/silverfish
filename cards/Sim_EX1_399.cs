using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_399 : SimTemplate //gurubashiberserker
	{

//    erhält jedes mal +3 angriff, wenn dieser diener schaden erleidet.
        public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, bool ownDmgdmin)
        {
            if (triggerEffectMinion.anzGotDmg>=1)
            {
                triggerEffectMinion.Angr += 3 * triggerEffectMinion.anzGotDmg;
                triggerEffectMinion.anzGotDmg = 0;
            }
        }

	}
}