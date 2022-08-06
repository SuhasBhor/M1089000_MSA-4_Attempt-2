using TechTalk.SpecFlow;
using DoveShampoo.Utility;
using DoveShampoo.Drivers;

namespace DoveShampoo.Hooks
{
    [Binding]
    public sealed class Hooks1
    {

        [BeforeTestRun]
        public static void beforeTestRun()
        {
            ExtentReport.generateReport();
            LogFourNet.log.Info("Initialize extent report");
        }

        [AfterTestRun]
        public static void afterTestRun()
        {
            ExtentReport.closeReport();
            LogFourNet.log.Info("Close Extent report");
        }

        [BeforeFeature]
        public static void featureBrowser()
        {
            ExtentReport.featureReport();
        }

        [BeforeScenario]
        public static void beforeScenario()
        {
            DriverClass.InitializeDriver();
            ExtentReport.scenarioReport();
        }

        [AfterStep]
        public static void afterScenarioSteps()
        {
            ExtentReport.scenarioStepReport();
        }

        [AfterScenario]
        public static void CloseDriver()
        {
            DriverClass.CloseDriver();
        }
    }
}