using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Management.Automation.Runspaces;

namespace PnP.PowerShell.Tests.Files
{
    [TestClass]
    public class ResetFileVersionTests
    {
        #region Test Setup/CleanUp
        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            // This runs on class level once before all tests run
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [ClassCleanup]
        public static void Cleanup(TestContext testContext)
        {
            // This runs on class level once
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [TestInitialize]
        public void Initialize()
        {
            using (var scope = new PSTestScope())
            {
                // Example
                // scope.ExecuteCommand("cmdlet", new CommandParameter("param1", prop));
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (var scope = new PSTestScope())
            {
                try
                {
                    // Do Test Setup - Note, this runs PER test
                }
                catch (Exception)
                {
                    // Describe Exception
                }
            }
        }
        #endregion

        #region Scaffolded Cmdlet Tests
        //TODO: This is a scaffold of the cmdlet - complete the unit test
        //[TestMethod]
        public void ResetPnPFileVersionTest()
        {
            using (var scope = new PSTestScope(true))
            {
                // Complete writing cmd parameters

				// This is a mandatory parameter
				// From Cmdlet Help: The server relative URL of the file.
				var serverRelativeUrl = "";
				// From Cmdlet Help: The check in type to use. Defaults to Major.
				var checkinType = "";
				// From Cmdlet Help: The comment added to the checkin. Defaults to 'Restored to previous version'.
				var checkInComment = "";

                var results = scope.ExecuteCommand("Reset-PnPFileVersion",
					new CommandParameter("ServerRelativeUrl", serverRelativeUrl),
					new CommandParameter("CheckinType", checkinType),
					new CommandParameter("CheckInComment", checkInComment));
                
                Assert.IsNotNull(results);
            }
        }
        #endregion
    }
}
            