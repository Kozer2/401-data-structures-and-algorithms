using Xunit;


namespace Challenges.Tests.WordRepeatTests
{
    public class RepeatedWordsTests
    {
        [Fact]
        public void reapeated_words_returns_the_expected_value()
        {
            // arrange
            string words = "Once upon a time, there was a brave princess who danced.";
            string expected = "a";

            // act
            var result = RepeatWords.RepeatedWord(words);

            // assert
            Assert.Equal(expected, result);
        }



        [Theory]
        [InlineData("Once upon a time, there was a brave princess who danced.", "a")]
        [InlineData("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, " +
            "it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, " +
            "for good or for evil, in the superlative degree of comparison only...", "it")]
        [InlineData("Nathan is really good at programming many different programs for programming programers.", "programming")]
        [InlineData("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z", "")]
        

        public void repeated_words_works(string words, string expected)
        {
            // arrange
            

            // act
            var result = RepeatWords.RepeatedWord(words);

            // assert
            Assert.Equal(expected, result);
        }


    }
}
