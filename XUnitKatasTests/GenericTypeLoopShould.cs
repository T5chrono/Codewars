using System;
using System.Collections.Generic;
using System.Text;
using Codewars.Katas;
using Xunit;

namespace XUnitKatasTests
{
    public class GenericTypeLoopShould
    {
        private GenericTypeLoop<string> myLoop;

        public GenericTypeLoopShould()
        {
            myLoop = new GenericTypeLoop<string>(){ "a", "b", "c", "d", "e", "f" };
        }

        [Fact]
        public void MoveLeft()
        {
            myLoop.Left();
            Assert.Equal("b", myLoop.ShowFirst());
        }

        [Fact]
        public void MoveRight()
        {
            myLoop.Right();
            Assert.Equal("f", myLoop.ShowFirst());
        }

        [Fact]
        public void PopTheItemOut()
        {
            Assert.Equal("a", myLoop.PopOut());
            Assert.Equal("b", myLoop.PopOut());
            Assert.Equal("c", myLoop.PopOut());
        }

        [Fact]
        public void PerformTheWholeSequence()
        {
            Assert.Equal("a", myLoop.ShowFirst());
            myLoop.Right();
            Assert.Equal("f", myLoop.ShowFirst());
            myLoop.Right();
            Assert.Equal("e", myLoop.ShowFirst());
            myLoop.Left();
            Assert.Equal("f", myLoop.ShowFirst());
            myLoop.Left();
            Assert.Equal("a", myLoop.PopOut());
            Assert.Equal("b", myLoop.PopOut());
            Assert.Equal("c", myLoop.PopOut());
        }
    }
}
