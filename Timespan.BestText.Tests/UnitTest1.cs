using System;
using Xunit;
using DalesLab.Timespan.BestText;

namespace Timespan.BestText.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Milliseonds()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddMilliseconds(-500));
            Assert.Equal("500 milliseconds", testSpan.BestText());
        }

        [Fact]
        public void SingleSecond()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddSeconds(-1));
            Assert.Equal("1 second", testSpan.BestText());
        }

        [Fact]
        public void Seconds()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddSeconds(-30));
            Assert.Equal("30 seconds", testSpan.BestText());
        }

        [Fact]
        public void SingleMinute()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddMinutes(-1));
            Assert.Equal("1 minute", testSpan.BestText());
        }

        [Fact]
        public void Minutes()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddMinutes(-30));
            Assert.Equal("30 minutes", testSpan.BestText());
        }

        [Fact]
        public void SingleHour()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddHours(-1));
            Assert.Equal("1 hour", testSpan.BestText());
        }

        [Fact]
        public void Hours()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddHours(-12));
            Assert.Equal("12 hours", testSpan.BestText());
        }

        [Fact]
        public void HoursAsADay()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddHours(-24));
            Assert.Equal("1 day", testSpan.BestText());
        }

        [Fact]
        public void SingleDay()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddDays(-1));
            Assert.Equal("1 day", testSpan.BestText());
        }

        [Fact]
        public void Days()
        {
            TimeSpan testSpan = (DateTime.Now - DateTime.Now.AddDays(-20));
            Assert.Equal("20 days", testSpan.BestText());
        }
    }
}
