using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectForGit.StepDefinitions
{
    [Binding]
    public class ExpandStringAlgorithmStepDefinitions
    {
        string result = "";
        string input = "";
        [Given(@"the given string is '([^']*)'")]
        public void GivenTheGivenStringIs(string p0)
        {
             input = p0;
        }

        [When(@"check the string having characters and the numbers as a repeats")]
        public void WhenCheckTheStringHavingCharactersAndTheNumbersAsARepeats()
        {
           
            int length = input.Length;
            char ch=input[0];
            for (int i = 0; i < length; i++)
            {
                char currentChar = input[i];

                if (Char.IsLetter(currentChar))
                {
                    ch = currentChar;
                    //result += currentChar;
                }
                else if (Char.IsDigit(currentChar))
                {
                    int repetition = int.Parse(currentChar.ToString());

                    if (i + 1 < length && Char.IsDigit(input[i + 1]))
                    {
                        repetition = repetition * 10 + int.Parse(input[i + 1].ToString());
                        i++;
                    }

                    char previousChar = ch;
                    for (int j = 0; j < repetition; j++)
                    {
                        result += previousChar;
                    }
                }
            }
        }

        [Then(@"create string based on the string character repeats")]
        public void ThenCreateStringBasedOnTheStringCharacterRepeats()
        {
            Console.WriteLine(result);
        }
    }
}
