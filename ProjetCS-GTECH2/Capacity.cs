using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuPokemon;
using pokehunter;
using Fighter;
using Object = Objects.Object;

namespace MenuPokemon
{
    public class Capacity
    {

        public void NoScope(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int healthEnemi = 0;
            int damageFighter = 0;
            int damageDeal = 0;

            if (inventory._objects[0]._quantity != 0)
            {
                healthEnemi = ennemi.GetHealth();
                damageFighter = fighters.Getdamage();
                damageDeal = healthEnemi - (damageFighter + damageFighter / 2);
                ennemi.SetHealth(damageDeal);

            }
            else
            {
                Console.WriteLine("No more ammo.");
            }
        }

        public void CoupDeCrosse(Fighters fighters, Ennemi ennemi)
        {
            int damageDeal = 0;
            damageDeal = ennemi.GetHealth() - (fighters.Getdamage() + fighters.Getdamage() / 3) + fighters.GetBuffDmg();
            ennemi.SetHealth(damageDeal);
        }
        public void AmericaFckYeah(Fighters fighters)
        {
            int buff = 0;
            buff = 2;
            fighters.SetBuffDmg(buff);
        }
        public void HeadShot(Fighters fighters, Ennemi ennemi)
        {
            int damageDeal = 0;
            damageDeal = ennemi.GetHealth() - (fighters.Getdamage() + fighters.GetBuffDmg()) * 2;
            ennemi.SetHealth(damageDeal);
        }
        public void Stielhandgranate(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int damageDeal = 0;
            if (inventory._objects[1]._quantity != 0)
            {
                damageDeal = ennemi.GetHealth() - (fighters.Getdamage() + fighters.GetBuffDmg()) * 2;
                ennemi.SetHealth(damageDeal);
            }
            else
            {
                Console.WriteLine("No more grenade.");
            }
        }
    }
}