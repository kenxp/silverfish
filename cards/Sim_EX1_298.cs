using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_298 : SimTemplate //ragnarosthefirelord
	{

//    kann nicht angreifen. fügt am ende eures zuges einem zufälligen feind 8 schaden zu.

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int count = (turnEndOfOwner) ? p.enemyMinions.Count : p.ownMinions.Count;
                if (count >= 1)
                {
                    List<Minion> temp2 = (turnEndOfOwner) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
                    temp2.Sort((a, b) => -a.Hp.CompareTo(b.Hp));//damage the stronges
                    foreach (Minion mins in temp2)
                    {
                        p.minionGetDamageOrHeal(mins, 8);
                        break;
                    }
                }
                else
                {
                    if (turnEndOfOwner)
                    {
                        p.minionGetDamageOrHeal(p.enemyHero, 8);
                    }
                    else
                    {
                        p.minionGetDamageOrHeal(p.ownHero, 8);
                    }
                }
                triggerEffectMinion.stealth = false;
            }
        }

	}
}