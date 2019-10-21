using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            ShareSkill shareskillInstance = new ShareSkill();
            ManageListings manageListingsinstance = new ManageListings();
            [Test]
            public void Fillandvalidate()
            {
                
                shareskillInstance.EnterShareSkill("credit");
                
                Assert.IsTrue(manageListingsinstance.searchskill("Seleniumwebdriver"));

            }
            [Test]
            public void EditandValidate()
            {
                manageListingsinstance.ClickManageListing();
                manageListingsinstance.ClickEditSkill();
                shareskillInstance.Editnfill("credit");
                Assert.IsTrue(manageListingsinstance.searchskill("Malayalam to English Translation"));
            }
            [Test]
            public void DeleteandValidate()
            {
                manageListingsinstance.ClickManageListing();
                manageListingsinstance.clickDeleteicon();
                Assert.IsFalse(manageListingsinstance.searchskill("Malayalam to English Translation"));

            }

        }
    }
}