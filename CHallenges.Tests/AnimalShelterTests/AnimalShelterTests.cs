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

       





    }


    
}


