using DataStructures.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructures.Tests.Graph
{
    public class GraphTests
    {
        [Fact]
 
        public void Starts_empty()
        {
            // Arrange / Act
            var graph = new graph<string, int>();

            // Assert
            Assert.Empty(graph.Nodes);
            Assert.Equal(0, graph.Count);
        }
    }
}
