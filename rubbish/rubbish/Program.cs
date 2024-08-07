/*using System;
using System.Collections.Generic;
using System.Linq;

namespace KMeansClustering
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] points = new double[][]
            {
                new double[] { 1.0, 2.0, 3.0 },
                new double[] { 4.0, 5.0, 6.0 },
            };

            int k = 2;

            List<double[]> centroids = InitializeCentroids(points, k);

            for (int iter = 0; iter < 100; iter++) // Adjust the number of iterations
            {
                Dictionary<int, List<double[]>> clusters = AssignPointsToClusters(points, centroids);
                centroids = UpdateCentroids(clusters);
            }

            Console.WriteLine("Final centroids (cluster coordinates):");
            foreach (var centroid in centroids)
            {
                Console.WriteLine($"Cluster: {string.Join(", ", centroid)}");
            }

        }

        static List<double[]> InitializeCentroids(double[][] points, int k)
        {
            Random rand = new Random();
            return points.OrderBy(p => rand.Next()).Take(k).ToList();
        }
        static Dictionary<int, List<double[]>> AssignPointsToClusters(double[][] points, List<double[]> centroids)
        {
            int k = centroids.Count;
            var clusters = new Dictionary<int, List<double[]>>();
            for (int i = 0; i < k; i++)
            {
                clusters[i] = new List<double[]>();
            }

            foreach (var point in points)
            {
                double minDistance = double.MaxValue;
                int closestCluster = -1;

                for (int i = 0; i < k; i++)
                {
                    double distance = CalculateEuclideanDistance(point, centroids[i]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestCluster = i;
                    }
                }

                clusters[closestCluster].Add(point);
            }

            return clusters;
        }

        static List<double[]> UpdateCentroids(Dictionary<int, List<double[]>> clusters)
        {
            return clusters.Values.Select(cluster => CalculateMean(cluster)).ToList();
        }

        static double CalculateEuclideanDistance(double[] p1, double[] p2)
        {
            double sum = 0.0;
            for (int i = 0; i < p1.Length; i++)
            {
                double diff = p1[i] - p2[i];
                sum += diff * diff;
            }
            return Math.Sqrt(sum);
        }

        static double[] CalculateMean(List<double[]> cluster)
        {
            int dim = cluster[0].Length;
            double[] mean = new double[dim];

            for (int i = 0; i < dim; i++)
            {
                mean[i] = cluster.Average(p => p[i]);
            }

            return mean;
        }
    }
}
*/
// C# program for array implementation of queue
using System;

namespace GeeksForGeeks
{
    // A class to represent a linearqueue
    class Queue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        // Function to add an item to the queue.
        // It changes rear and size
        public void enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                ele[++rear] = item;
            }
        }

        // Function to remove an item from queue.
        // It changes front and size
        public int dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine(ele[front] + " dequeued from queue");
                int p = ele[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", ele[front]);
                Console.WriteLine("Rear item is {0} ", ele[rear]);
                return p;
            }
        }

        // Function to print queue.
        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(ele[i] + " enqueued to queue");
                }
            }
        }
    }

    // Driver code
    class Program
    {
        static void Main()
        {
            Queue Q = new Queue(5);

            Q.enqueue(10);
            Q.enqueue(20);
            Q.enqueue(30);
            Q.enqueue(40);
            Q.printQueue();
            Q.dequeue();
        }
    }
}
