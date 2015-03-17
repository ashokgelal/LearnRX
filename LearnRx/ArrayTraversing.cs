using LearnRx.Infrastructure;

namespace LearnRx
{
    public class ArrayTraversing
    {
        public static void PrintNames(ILogger logger)
        {
            var names = new[] {"Ben", "Adam", "Mike", "Billy", "Jacob", "Zach", "Kevin", "Vanessa"};
            for (var i = 0; i < names.Length; i++)
            {
                logger.Log(names[i]);
           }
        }
    }
}
