using Fighter;
using MenuPokemon;
using pokehunter;

namespace pokehunter
{
    public class CapacityTest
    {
        [Test]
        [TestCase(10, 15)]
        [TestCase(20, 30)]
        [TestCase(14, 21)]
        public void NoScopeTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory= new Inventory();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10,10,100,10);

            int damage = cap.NoScope(cap, inventory, fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 13)]
        [TestCase(20, 26)]
        [TestCase(14, 18)]
        public void CoupDeCrosseTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.CoupDeCrosse(fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 12)]
        [TestCase(20, 22)]
        [TestCase(14, 16)]
        public void AmericaFckYeahTestBuff(int a, int expected)
        {
            Capacity cap = new Capacity();
            Fighters fighters = new Fighters("test", 100, a);

            int damage = cap.AmericaFckYeah(fighters);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(20, 40)]
        [TestCase(14, 28)]
        public void HeadShotTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory = new Inventory();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.HeadShot(inventory, fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(20, 40)]
        [TestCase(14, 28)]
        public void StielhandgranateTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory = new Inventory();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.Stielhandgranate(inventory, fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 13)]
        [TestCase(20, 23)]
        [TestCase(14, 17)]
        public void ArtificeTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory = new Inventory();
            Fighters fighters = new Fighters("test", 100, a);

            int buff = cap.Artifice(inventory, fighters);
            Assert.That(buff, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 10)]
        [TestCase(20, 20)]
        [TestCase(14, 14)]
        public void MolotoveTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory = new Inventory();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.Molotove(inventory, fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 5)]
        [TestCase(20, 10)]
        [TestCase(14, 7)]
        public void IceGrenadeTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory = new Inventory();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.IceGrenade(inventory, fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 10)]
        [TestCase(20, 20)]
        [TestCase(14, 14)]
        public void UppercutTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.Uppercut(fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(20, 40)]
        [TestCase(14, 28)]
        public void CoupDeQueueTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.CoupDeQueue(fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 12)]
        [TestCase(20, 25)]
        [TestCase(14, 17)]
        public void MawashiGeriTestDamage(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory = new Inventory();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int damage = cap.MawashiGeri(fighters, ennemi);
            Assert.That(damage, Is.EqualTo(expected));


        }

        [Test]
        [TestCase(10, 15)]
        [TestCase(20, 25)]
        [TestCase(14, 19)]
        public void RouladeTestBuff(int a, int expected)
        {
            Capacity cap = new Capacity();
            Inventory inventory = new Inventory();
            Fighters fighters = new Fighters("test", 100, a);
            Ennemi ennemi = new Ennemi("ennemi", 10, 10, 100, 10);

            int buff = cap.Roulade(fighters);
            Assert.That(buff, Is.EqualTo(expected));
        }
    }
}