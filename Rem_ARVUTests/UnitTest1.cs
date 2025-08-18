using Xunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Rem_ARVU;
using Rem_ARVU.Rem_ARVUDataset;

namespace Rem_ARVU.Tests {
    public class BoundaryTests {
        [Theory]
        [InlineData(int.MinValue, false)]
        [InlineData(-1, false)]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(int.MaxValue, true)]
        public void ValidateInteger_Boundary(int value, bool expected) {
            Assert.Equal(expected, value >= 0);
        }

        [Theory]
        [InlineData("", false)]
        [InlineData("A", true)]
        [InlineData("ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ", false)] 
        public void ValidateString_ДлинаСтроки(string value, bool expected) {
            Assert.Equal(expected, !string.IsNullOrEmpty(value) && value.Length <= 50);
        }
    }
}