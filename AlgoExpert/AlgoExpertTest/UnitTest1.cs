using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace AlgoExpertTest
{
    [TestClass]
    public class UnitTest1
    {
		[Test]
		public void TwoNumberSum()
		{


			int[] output = Program.TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);
			Utils.AssertTrue(output.Length == 2);
			Utils.AssertTrue(Array.Exists(output, e => e == -1));
			Utils.AssertTrue(Array.Exists(output, e => e == 11));
		}
	}
}
