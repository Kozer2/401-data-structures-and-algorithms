using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Challenges.AnimalShelter;

namespace Challenges.Tests.AnimalShelterTests
{
   public class AnimalShelterTests
    {
        [Fact]
        public void Enqueue_and_IsEmpty_work()
        {
            // arrange
            AnimalShelter<string> dog = new AnimalShelter<string>();
            // act
            dog.Enqueue("Dog");


            // assert
            Assert.False(dog.IsEmpty);

        }

        [Fact]
        public void Dequeue_works()
        {
            // arrange
            AnimalShelter<string> animal = new AnimalShelter<string>();
            animal.Enqueue("Dog");

            // act
            animal.Enqueue("Cat");
            string result = animal.Dequeue();

            // assert
            Assert.Equal("Dog", result);

        }





    }


    
}


