
namespace DoveShampoo.Utility
{
    public class LogFourNet
    {
        public static readonly log4net.ILog log =
                    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    }
}
