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
    internal class Capacity
    {

        public void NoScope(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int healthEnemi = 0;
            int damageFighter = 0;
            int damageDeal = 0;

            if (inventory.Objects[0]._quantity != 0)
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
            if (inventory.Objects[1]._quantity != 0)
            {
                damageDeal = ennemi.GetHealth() - fighters.Getdamage()*2 + fighters.GetBuffDmg();
                ennemi.SetHealth(damageDeal);
            }
            else
            {
                Console.WriteLine("No more grenade.");
            }
        }
        public void Artifice(Inventory inventory, Fighters fighters)
        {

            if (inventory.Objects[2]._quantity != 0)
            {
                int buff = 0;
                buff = 3;
                fighters.SetBuffDmg(buff);
            }
            else
            {
                Console.WriteLine("No more grenade.");
            }
        }
        public void Molotove(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int damageDeal = 0;
            if (inventory.Objects[3]._quantity != 0)
            {
                damageDeal = ennemi.GetHealth() - fighters.Getdamage() + fighters.GetBuffDmg();
                ennemi.SetBurn(true);
                ennemi.SetHealth(damageDeal);
            }
            else
            {
                Console.WriteLine("No more Molotov.");
            }
        }
        public void IceGrenade(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int damageDeal = 0;
            if (inventory.Objects[4]._quantity != 0)
            {
                damageDeal = ennemi.GetHealth() - fighters.Getdamage()/2 + fighters.GetBuffDmg();
                ennemi.SetDeBuff(2);
                ennemi.SetHealth(damageDeal);
            }
            else
            {
                Console.WriteLine("No more Ice grenade.");
            }
        }
        public void Uppercut(Fighters fighters, Ennemi ennemi)
        {
                int damageDeal = 0;
                damageDeal = ennemi.GetHealth() - fighters.Getdamage()  + fighters.GetBuffDmg();
                ennemi.SetHealth(damageDeal);
        }
        public void CoupDeQueue(Fighters fighters, Ennemi ennemi)
        {
            int damageDeal = 0;
            damageDeal = ennemi.GetHealth() - fighters.Getdamage()*2 + fighters.GetBuffDmg();
            ennemi.SetHealth(damageDeal);
        }
        public void MawashiGeri(Fighters fighters, Ennemi ennemi)
        {
            int damageDeal = 0;
            damageDeal = ennemi.GetHealth() - fighters.Getdamage() + fighters.Getdamage() /4 + fighters.GetBuffDmg();
            ennemi.SetHealth(damageDeal);
        }
        public void Roulade(Fighters fighters)
        {
            int buff = 0;
            buff = 5;
            fighters.SetBuffDmg(buff);
        }
    }
}