using NUnit.Framework;

namespace UsingFsCheckWithNUnitTestAdapter
{
    [TestFixture]
    public class Fixture
    {
        [FsCheck.NUnit.Property]
        public bool MultiplyingByZeroIsZero(int x)
        {
            return (x * 0) == 0;
        }
    }
}
