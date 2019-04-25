using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Project
{
    /// <summary>
    /// Base class for all Algorithms used in project
    /// </summary>
    class Algorithms
    {
        private void intialize(Dictionary<string, bool> vistedNode)
        {
            foreach (string key in vistedNode.Keys)
            {
                vistedNode[key] = false;
            }
        }

        public void BFS_Algorithm(Dictionary<string, Dictionary<string, string>> adjacencyList, Dictionary<string, bool> vistedNode, string source, string destination)
        {
            intialize(vistedNode);
            Queue<string> nodes = new Queue<string>();
            nodes.Enqueue(source);
            while (nodes.Count() != 0)
            {
                string front = nodes.Dequeue();
                foreach (string key in adjacencyList[front].Keys)
                {
                    if(vistedNode[front] == false)
                    {
                        nodes.Enqueue(key);
                    }
                }
                vistedNode[front] = true;
            }
        }
    }
}
