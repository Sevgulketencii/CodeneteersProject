using Xunit;
using DataAccesLayer.Helpers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var connection = new DbConnectionHelper().GetConnection();
            var state = (connection.State.ToString() == "Closed") ? true : false; 
            Assert.True(state);
        }

        [Fact]
        public void Test2()
        {
            var connection = new DbConnectionHelper().GetConnection();
            connection.Open();
            var state = (connection.State.ToString() == "Open") ? true : false;
            Assert.True(state);
        }

        [Fact]
        public void Test3()
        {
            var connection = new DbConnectionHelper().GetConnection();
            connection.Open();
            connection.Close();
            var state = (connection.State.ToString() == "Closed") ? true : false;
            Assert.True(state);
        }

        [Fact]
        public void Test4()
        {

        }
    }
}