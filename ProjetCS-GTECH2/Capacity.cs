using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MenuPokemon;
using pokehunter;
using Fighter;
using Object = Objects.Object;
using System.Net.Http.Headers;

namespace MenuPokemon
{
    public class Capacity
    {

        public int NoScope(Capacity cap, Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int healthEnemi = 0;
            int damageFighter = 0;
            int finalheath = 0;
            int damageDeal = 0;

            if (inventory.Objects[0].Use(1) != false)
            {
                healthEnemi = ennemi.GetHealth();
                damageFighter = fighters.Getdamage();
                damageDeal = (damageFighter + damageFighter / 2) + fighters.GetBuffDmg();
                finalheath = healthEnemi -  damageDeal;
                ennemi.SetHealth(finalheath);

            }
            return damageDeal;
        }

        public int CoupDeCrosse(Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            damageDeal = (fighters.Getdamage() + fighters.Getdamage() / 3) + fighters.GetBuffDmg();
            finalheath = ennemi.GetHealth() - damageDeal;
            ennemi.SetHealth(finalheath);
            return damageDeal;
        }
        public int AmericaFckYeah(Fighters fighters)
        {
            int buff = 0;
            buff = 2;
            fighters.SetBuffDmg(buff);
            return fighters.Getdamage() + fighters.GetBuffDmg();
        }
        public int HeadShot(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            if (inventory.Objects[0].Use(1) != false)
            {
                damageDeal = (fighters.Getdamage() + fighters.GetBuffDmg()) * 2;
                finalheath = ennemi.GetHealth() - damageDeal;
                ennemi.SetHealth(finalheath);
            }
                return damageDeal;
        }
        public int Stielhandgranate(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            if (inventory.Objects[1].Use(1) != false)
            {
                damageDeal = fighters.Getdamage() * 2 + fighters.GetBuffDmg();
                finalheath = ennemi.GetHealth() - damageDeal;
                ennemi.SetHealth(finalheath);
            }
            return damageDeal;

        }
        public int Artifice(Inventory inventory, Fighters fighters)
        {
            if (inventory.Objects[2].Use(1) != false)
            {
                int buff = 0;
                buff = 3;
                fighters.SetBuffDmg(buff);
            }

                return fighters.Getdamage() + fighters.GetBuffDmg();
        }
        public int Molotove(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            if (inventory.Objects[3].Use(1) != false)
            {
                    damageDeal = fighters.Getdamage() + fighters.GetBuffDmg();
                finalheath = ennemi.GetHealth() - damageDeal;
                ennemi.SetBurn(true);
                ennemi.SetHealth(finalheath);
            }
                return damageDeal;
        }
        public int IceGrenade(Inventory inventory, Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            if (inventory.Objects[4].Use(1) != false)

            {
                    damageDeal = fighters.Getdamage() / 2 + fighters.GetBuffDmg();
                    finalheath = ennemi.GetHealth() - damageDeal;
                ennemi.SetDeBuff(2);
                ennemi.SetHealth(finalheath);
            }
                return damageDeal;

        }
        public int Uppercut(Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            damageDeal = fighters.Getdamage() + fighters.GetBuffDmg();
            finalheath = ennemi.GetHealth() -damageDeal ;
                ennemi.SetHealth(finalheath);
            return damageDeal;
        }
        public int CoupDeQueue(Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            damageDeal = fighters.Getdamage() * 2 + fighters.GetBuffDmg();
            finalheath = ennemi.GetHealth() - damageDeal;
            ennemi.SetHealth(finalheath);
            return damageDeal;
        }
        public int MawashiGeri(Fighters fighters, Ennemi ennemi)
        {
            int finalheath = 0;
            int damageDeal = 0;
            damageDeal = fighters.Getdamage() + fighters.Getdamage() / 4 + fighters.GetBuffDmg();
            finalheath = ennemi.GetHealth() - damageDeal;
            ennemi.SetHealth(finalheath);
            return damageDeal;
        }
        public int Roulade(Fighters fighters)
        {
            int buff = 0;
            buff = 5;
            fighters.SetBuffDmg(buff);
            return fighters.Getdamage() + fighters.GetBuffDmg();
        }
    }
}