namespace SpecFlowProjectForGit.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        int input1 = 0;
        int input2 = 0;
        int output1 = 0;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
             input1=number;
        }
        
        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
             input2=number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            
            output1 = input1 + input2;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            try
            {
                if(output1 == result)
                {
                    Console.WriteLine("the output "+output1+" and results "+result+" is same ");
                }
                else
                {
                    Console.WriteLine("failed adding two numbers");
                    throw new Exception();
                }
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}