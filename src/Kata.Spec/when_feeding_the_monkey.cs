using System;
using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_feeding_the_monkey
    {
        static Monkey _systemUnderTest;
        
        Establish context = () => 
            _systemUnderTest = new Monkey();

        Because of = () => 
            _systemUnderTest.Eat("banana");

        It should_have_the_food_in_its_belly = () =>
            _systemUnderTest.Belly.Should().Contain("banana");
    }

    public class when_spec_test
    {
        Establish _context = () =>
        {
            _systemUnderTest = new arcl();
        };

        Because of = () => { _result = _systemUnderTest.Something(); };

        It should_something = () => { _result.Should().Be("11"); };
        static arcl _systemUnderTest;
        static string _result;
    }
}
