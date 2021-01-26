using System;
using Xunit;
using AnimalShelter;

namespace FIFOAnimalTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueueAnimal()
        {
            AnimalShelterClass shelter = new AnimalShelterClass();
            shelter.Enqueue(new Dog("Dot"));

            Assert.NotNull(shelter.Front);
        }
        [Fact]
        public void TestDequeue()
        {
            AnimalShelterClass shelter = new AnimalShelterClass();
            shelter.Enqueue(new Dog("Dot"));
            Animal expected = shelter.Front;

            Assert.Equal(expected, shelter.Dequeue("dog"));
        }
        [Fact]
        public void DequeueEmptyShelter()
        {
            AnimalShelterClass shelter = new AnimalShelterClass();

            Assert.Throws<NullReferenceException>(() => shelter.Dequeue("dog"));
        }
    }
}
