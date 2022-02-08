using System;
using RegexPattern;

	public static class PatternCheck
	{
		public static string PatternCheck1()
        { 
            Patterns patterns = new Patterns();
        if (patterns.validateEmail("abc+100@gmail.com"))
        {
            return "Happy";
        }
        else
            return "Sad";
            if (patterns.validateFirstName("Pankaj"))
            {
            return "Happy";
        }
            else
            return "Sad";
        if (patterns.validateLastName("Kumar"))
            {
            return "Happy";
        }
            else
            return "Sad";
        if (patterns.validateMobile("91 7883773486"))
            {
            return "Happy";
        }
            else
            return "Sad";
        if (patterns.password1("helloworld123"))
            {
            return "Happy";
        }
            else
            return "Sad";
        if (patterns.password2("Helloworld123"))
            {
            return "Happy";
        }
            else
            return "Sad";
        if (patterns.password3("123@tEst"))
            {
            return "Happy";
        }
            else
            return "Sad";
        if (patterns.password4("123@tEst"))
            {
            return "Happy";
        }
            else
            return "Sad";


    }
    }


