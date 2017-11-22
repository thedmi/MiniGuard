using Xunit;

namespace MiniGuard.Test
{
    public class GuardTest
    {
        [Fact]
        public void Satisfied_precondition_does_not_throw()
        {
            Guard.Precondition(true);
        }

        [Fact]
        public void Unsatisfied_precondition_throws_with_message()
        {
            var exception = Assert.Throws<GuardException>(() => Guard.Precondition(false, "Some info"));   
            Assert.Contains("Some info", exception.Message);
        }
        
        [Fact]
        public void Satisfied_postcondition_does_not_throw()
        {
            Guard.Postcondition(true);
        }

        [Fact]
        public void Unsatisfied_postcondition_throws_with_message()
        {
            var exception = Assert.Throws<GuardException>(() => Guard.Postcondition(false, "Some info"));   
            Assert.Contains("Some info", exception.Message);
        }
        
        [Fact]
        public void Satisfied_assertion_does_not_throw()
        {
            Guard.Assertion(true);
        }

        [Fact]
        public void Unsatisfied_assertion_throws_with_message()
        {
            var exception = Assert.Throws<GuardException>(() => Guard.Assertion(false, "Some info"));   
            Assert.Contains("Some info", exception.Message);
        }
    }
}