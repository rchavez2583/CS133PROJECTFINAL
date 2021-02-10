using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS133FINALPROJECT3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PorterCleansDishes_CleanDishes_ReturnsTrue()
        {

            //Arrange
            Restaurant clean = new Restaurant();

            User newClient = new User();
            newClient.IsClient = true;
            newClient.UserName = "First Client";


            Clan newClan = new Clan();
            newClan.ClanName = "Next Client";

            newClient.ClanInfo = newClan;

            clean.CurrentUser = newClient;
            //Act
            User newLeft = new User();
            newLeft.IsClient = true;
            newLeft.UserName = "Six Client";

            Clan newClanLeft = new Clan();
            newClanLeft.ClanName = "Nine Client";
            newLeft.ClanInfo = newClanLeft;
            bool PeopleIntoTheQueue = clean.ClientsLeave(newClient);

            //Assert
            Assert.IsTrue(PeopleIntoTheQueue);
        }
    }
}
