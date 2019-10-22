﻿using System;
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

    public class when_input_empty_string
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add(); };
        It should_return_zero = () => { _result.Should().Be(0); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_user_input_has_one_number
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1"); };

        It should_return_the_same_number = () => { _result.Should().Be(1); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_input_has_two_numbers
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("1,2"); };
        It should_return_the_sum_of_all = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    };

    public class when_input_is_unknow_amount_of_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,2,3"); };

        It should_return_the_sum_off_all_numbers = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_input_has_new_line_delimiter
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("1\n2,3"); };
        It should_return_the_sum_of_all = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    };

    public class when_user_input_custom_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//;\n1;2"); };

        It should_return_the_sum_of_all_numbers = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_input_has_negative_number
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = Catch.Exception(()=> _systemUnderTest.Add("1,-2,3")); };
        It should_throw_an_exception = () => { _result.Message.Should().Be("negatives not allowed: -2"); };
        static Calculator _systemUnderTest;
        static Exception _result;
    };

    public class when_input_has_multiples_negative_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result =  Catch.Exception(()=> _systemUnderTest.Add("-1,-2,3")); };

        It should_throw_an_exception = () => { _result.Message.Should().Be("negatives not allowed: -1, -2"); };
        static Calculator _systemUnderTest;
        static Exception _result;
    }

    public class when_input_has_numbers_greater_than_1000
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("1,1001,2"); };
        It should_return_the_sum_without_numbers_greater_than_1000 = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    };

    public class when_input_multiple_character_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//[***]\n1***2***3"); };

        It should_return_the_sum_of_all_numbers = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_input_has_multi_multi_character_custom_delimiters
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("//[*][%]\n1*2%3"); };
        It should_return_the_sum_of_all = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    };
}
//11. Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[*][%]\n1*2%3” should return 6)