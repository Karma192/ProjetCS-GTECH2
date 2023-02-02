using Fighter;
using MenuPokemon;
using pokehunter;

namespace pokehunter
{
    public class CapacityTest
    {
       [Test]
        [TestCase(40, 6, 34)]
        [TestCase(34, 6, 28)]
        [TestCase(28, 6, 22)]
        [TestCase(22, 6, 16)]
        [TestCase(16, 6, 10)]
        public void NoScopeTestDamage(int a, int b, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory= new Inventory();
            Fighters fighters = new Fighters("test", 100, 10);
            Ennemi ennemi = new Ennemi("ennemi", 10,10,100,10);

            int healthMaxEnnemi = ennemi._health;
            cap.NoScope(cap, inventory, fighters, ennemi);
            int damage = healthMaxEnnemi - fighters.Getdamage();
            Assert.That(damage, Is.EqualTo(expected));
                        

        }
    }
}