﻿using Fusee.Xirkit;
using System;
using System.Linq;
using Xunit;
using static Fusee.Tests.Xirkit.HelperClasses;


namespace Fusee.Tests.Xirkit
{
    public class NodeTest
    {
        [Fact]
        public void TestInAndOutPins_AndRemove()
        {
            SimpleClass obj1 = new(0, 0);
            SimpleClass obj2 = new(1, 1);

            Node node1 = new(obj1);
            Node node2 = new(obj2);

            node1.Attach("x", node2, "y");

            Assert.Collection<IInPin>(node2.InPins, pin => Assert.True(pin.Member == "y", "Member is " + pin.Member + " but should be y"));
            Assert.Collection<IOutPin>(node1.OutPins, pin => Assert.True(pin.Member == "x", "Member is " + pin.Member + " but should be x"));

            node1.RemoveAllPins();
            node2.RemoveAllPins();

            Assert.True(!node1.OutPins.Any(), "OutPins count should be 0 but is " + node1.OutPins.Count());
            Assert.True(!node2.InPins.Any(), "InPins count should be 0 but is " + node2.OutPins.Count());
        }

        [Fact]
        public void TestPropagate()
        {
            SimpleClass obj1 = new(0, 0);
            SimpleClass obj2 = new(1, 1);

            Node node1 = new(obj1);
            Node node2 = new(obj2);

            node1.Attach("x", node2, "y");

            node1.Propagate();

            Assert.True(obj2.y == obj1.x, "Node2.y is " + obj2.y + " but should be " + obj1.x + ".");
        }

        [Fact]
        public void TestReferenceError()
        {
            int x = 1;

            void action() { Node node = new(x); }

            Assert.Throws<ArgumentException>(action);
        }
    }
}