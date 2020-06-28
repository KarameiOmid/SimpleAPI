using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController controller=new ValuesController();
        
        [Fact]
        public void ReturnsMyName()
        {
            var returnValue=controller.Get(1);
            Assert.Equal("Samira Talebi",returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
