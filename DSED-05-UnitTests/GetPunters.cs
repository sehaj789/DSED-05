using DSED_05.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSED_05_UnitTests
{
    [TestClass]
    public class GetPunters
    {
        [TestMethod]
        public void Should_Return_True_When_Getting_Punters()
        {
            Punter[] myPunters = new Punter[3];
            for (int i = 0; i < 3; i++)
            {
                myPunters[i] = Factory.GetAPunter(i);
            }
            Assert.IsTrue(myPunters[0].Name == "Jack" && myPunters[1].Name == "Vaughn" && myPunters[2].Name == "Jeremy");
        }
    }
}
