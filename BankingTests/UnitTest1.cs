using System;
using Xunit;
using BankyStuffLibary;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]//Attribute(post note)
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Kendra", 9101010);

            // Test for a negative balance.

            Assert.Throws<InvalidOperationException>(

                ()=>account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw")

            );

            
        }

        [Fact]
        public void Test3()
        {
            //Test that the initial balances must br positive

            Assert.Throws<ArgumentOutOfRangeException>(

                ()=> new BankAccount("invalid", 55)

            );
        }
    }
}
