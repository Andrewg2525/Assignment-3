using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Name Required.", ex.Message);
            }
        }

        [TestMethod]
        public void ConstructorSetsName()
        {
            Message newMessage = Message("Pumpkin", commands);
            Assert.AreEqual(newMessage.Name, "Pumpkin");

        }

    }
}
