using LearnRx.Infrastructure;

namespace LearnRx
{
    public class ArrayTraversing
    {
        public static string[] Names = {"Ben", "Adam", "Mike", "Billy", "Jacob", "Zach", "Kevin", "Vanessa"};
        public static void PrintNames(ILogger logger)
        {
            for (var i = 0; i < Names.Length; i++)
            {
                logger.Log(Names[i]);
           }
        }

        public static void PrintNamesForEach(ILogger logger)
        {
            // don't care about how the array is traversed but only what we want to happen
            foreach (var name in Names)
            {
                logger.Log(name);
            }
        }
    }
}
