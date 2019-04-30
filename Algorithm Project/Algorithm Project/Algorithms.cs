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
        /// <summary>
        /// Set all values to their initial states (Either empty or null)
        /// </summary>
        /// <param name="vertex"></param>
        private static void Intialize(Dictionary<string, path> vertex)
        {
            foreach (string key in vertex.Keys)                         //Θ(V)
            {
                vertex[key].VisitedNode = false;                        //Θ(1)
                vertex[key].distance = int.MaxValue;                    //Θ(1)
                vertex[key].Parent = null;                              //Θ(1)
                vertex[key].Undirect_Freq = 0;                          //Θ(1)
            }
        }

        /// <summary>
        /// Breadth First Search Algorithm Implementation
        /// </summary>
        /// <param name="adjacencyList">The list that stores all data</param>
        /// <param name="vertex"></param>
        /// <param name="source">The first name in query</param>
        /// <param name="destination">The second name in query</param>
        public static void BFS_Algorithm(Dictionary<string, Dictionary<string, Relation_str>> adjacencyList, Dictionary<string, path> vertex, string source, string destination)
        {
            Intialize(vertex);                                     //Θ(V) Touch Or Visit every vertex in Graph. 
            Queue<string> nodes = new Queue<string>();             
            nodes.Enqueue(source);                                 //O(1) put the source in the queue.
            vertex[source].VisitedNode = true;                     //Θ(1) make source visited (true).
            vertex[source].distance = 0;                           //Θ(1) make distance of source equal to zero.
            vertex[source].Undirect_Freq = 0;                      //Θ(1) make freq of source equal to zero.
            while (nodes.Count() != 0)                             
            {
                string front = nodes.Dequeue();                   //Θ(V) Visit every vertex and dequeue it from queue.

                foreach (string key in adjacencyList[front].Keys) //Θ(adjacencyList[front])
                {
                    if(vertex[key].VisitedNode == false)
                    {
                        nodes.Enqueue(key);                       //Θ(1) put node in the queue.                                                                                                                  \\
                        vertex[key].VisitedNode = true;           //after putting node in queue that is mean we visited it and make it true.                                                                       \\        
                        vertex[key].Parent = front;               //make the parent of vertex equal to front. Θ(1)                                                                                                   \\
                        vertex[key].distance = vertex[front].distance + 1; // calculate DOS (Degree Of Separation) between source and destination.                                                                     \\
                        vertex[key].Undirect_Freq = vertex[front].Undirect_Freq + adjacencyList[front][key].Direct_Freq;//calculate RS(Relation Strength) with undirect way between source and destination.              \\
                        if(vertex[key].distance > vertex[destination].distance)// if distance of node grater than distance of destination break from the loop.                                                            //                                                                            // 
                        {                                                                                                                                                                                               //
                            nodes.Clear(); //Θ(V)                                                                                                                                                                     //
                            break;                                                                                                                                                                                  //
                        }                                                                                                                                                                                         //
                    }                                                                                                                                                                                           //
                    else if(vertex[front].distance + 1 == vertex[key].distance) 
                    {
                        if(vertex[key].Undirect_Freq < vertex[front].Undirect_Freq + adjacencyList[front][key].Direct_Freq)
                        {
                            vertex[key].Undirect_Freq = vertex[front].Undirect_Freq + adjacencyList[front][key].Direct_Freq;
                            vertex[key].Parent = front;
                        }
                    }
                }
            }
        }
    }
}
