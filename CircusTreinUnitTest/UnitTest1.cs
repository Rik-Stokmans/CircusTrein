using CircusTreinV2;

namespace CircusTreinUnitTest
{
    
    public class V2Test
    {
        List<Animal> animalsV2 = new();

        [Test]
        public void GenerateAnimalsV2()
        {
            animalsV2 = Animal.GenerateAnimals(100000000);
        }

        [Test]
        public void MainRuntimeV2()
        {
            var train = new Train(animalsV2);

            train.PrintStats();
        }
    }


    public class Cases
    {
        [Test]
        public void Case1()
        {
            var animals = new List<Animal>
            {
                new(true, 1),

                new(false, 5),
                new(false, 5),

                new(false, 3),
                new(false, 3),
                new(false, 3)
            };
            const int solution = 2;


            var train = new Train(animals);
            if (train.CartCount != solution) Assert.Fail("Expected: " + solution + " Actual: " + train.CartCount);
        }

        [Test]
        public void Case2()
        {
            var animals = new List<Animal>
            {
                new(true, 1),

                new(false, 5),

                new(false, 3),
                new(false, 3),

                new(false, 1),
                new(false, 1),
                new(false, 1),
                new(false, 1),
                new(false, 1)
            };
            const int solution = 2;


            var train = new Train(animals);
            if (train.CartCount != solution) Assert.Fail("Expected: " + solution + " Actual: " + train.CartCount);
        }

        [Test]
        public void Case3()
        {
            var animals = new List<Animal>
            {
                new(true, 1),

                new(true, 3),

                new(true, 5),

                new(false, 5),

                new(false, 3),

                new(false, 1)
            };
            const int solution = 4;


            var train = new Train(animals);
            if (train.CartCount != solution) Assert.Fail("Expected: " + solution + " Actual: " + train.CartCount);
        }

        [Test]
        public void Case4()
        {
            var animals = new List<Animal>
            {
                new(true, 5),
                new(true, 5),

                new(true, 3),

                new(true, 1),

                new(false, 5),

                new(false, 3),
                new(false, 3),
                new(false, 3),
                new(false, 3),
                new(false, 3),

                new(false, 1)
            };
            const int solution = 5;


            var train = new Train(animals);
            if (train.CartCount != solution) Assert.Fail("Expected: " + solution + " Actual: " + train.CartCount);
        }

        [Test]
        public void Case5()
        {
            var animals = new List<Animal>
            {
                new(true, 1),

                new(false, 5),
                new(false, 5),

                new(false, 3),

                new(false, 1)
            };
            const int solution = 2;


            var train = new Train(animals);
            if (train.CartCount != solution) Assert.Fail("Expected: " + solution + " Actual: " + train.CartCount);
        }

        [Test]
        public void Case6()
        {
            var animals = new List<Animal>
            {
                new(true, 1),
                new(true, 1),
                new(true, 1),

                new(false, 5),
                new(false, 5),
                new(false, 5),

                new(false, 3),
                new(false, 3),
            };
            const int solution = 3;


            var train = new Train(animals);
            if (train.CartCount != solution) Assert.Fail("Expected: " + solution + " Actual: " + train.CartCount);
        }

        [Test]
        public void Case7()
        {
            var animals = new List<Animal>
            {
                new(true, 5),
                new(true, 5),
                new(true, 5),

                new(true, 3),
                new(true, 3),
                new(true, 3),

                new(true, 1),
                new(true, 1),
                new(true, 1),
                new(true, 1),
                new(true, 1),
                new(true, 1),
                new(true, 1),

                new(false, 5),
                new(false, 5),
                new(false, 5),
                new(false, 5),
                new(false, 5),
                new(false, 5),

                new(false, 3),
                new(false, 3),
                new(false, 3),
                new(false, 3),
                new(false, 3)
            };
            const int solution = 13;


            var train = new Train(animals);
            if (train.CartCount != solution) Assert.Fail("Expected: " + solution + " Actual: " + train.CartCount);
        }
    }
}