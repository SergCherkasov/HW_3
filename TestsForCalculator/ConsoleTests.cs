using HW_3.UserInterface;
namespace TestsForCalculator
{
    [TestClass]

    public class ConsoleTests
    {
        [TestMethod]

        public void TestConsoleByAdding()
        {
            var textReader = new StringReader("2+7");
            Console.SetIn(textReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            

            UserInterface ui = new UserInterface();

            ui.Calculate();

            var result=stringWriter.ToString();
            Assert.AreEqual(result, "\tWELCOME TO CALCULATOR APP!\r\n\r\nEnter expression:\r\n\r\nResult of Your expression:\r\n9\r\n");
            
        }
    }
}
