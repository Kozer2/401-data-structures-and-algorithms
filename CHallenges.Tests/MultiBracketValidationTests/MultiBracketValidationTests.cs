using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Challenges.MultiBracketChallenge;

namespace Challenges.Tests.MultiBracketValidationTests
{
    public class MultiBracketValidationTests
    {
        [Fact]
        public void MultiBracketValidation_returns_false_if_string_is_empty()
        {
            // arrange
            string input = "";

            // act
            bool result = MultiBracketValidationClass.CheckBracketBalance(input);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void MultiBracketValidation_returns_false_if_string_has_single_character()
        {
            // arrange
            string input = "{";

            // act
            bool result = MultiBracketValidationClass.CheckBracketBalance(input);

            // assert
            Assert.False(result);
        }

        [Fact]
        public void MultiBracketValidation_returns_false_if_string_has_no_brackets()
        {
            // arrange
            string input = "tests";

            // act
            bool result = MultiBracketValidationClass.CheckBracketBalance(input);

            // assert
            Assert.False(result);
        }
        

    }
}


