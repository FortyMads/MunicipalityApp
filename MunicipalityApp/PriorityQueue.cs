using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    // Generic PriorityQueue class
    public class PriorityQueue<T>
    {
        // List to store the heap elements as tuples of priority and item
        private List<(int Priority, T Item)> heap = new List<(int Priority, T Item)>();

        // Method to insert a new item with a given priority into the priority queue
        public void Insert(int priority, T item)
        {
            heap.Add((priority, item)); // Add the new item to the end of the list
            HeapifyUp(heap.Count - 1); // Restore the heap property by moving the new item up
        }

        // Property to get the number of items in the priority queue
        public int Count
        {
            get { return heap.Count; } // Return the count of items in the heap
        }

        // Method to extract the item with the minimum priority from the priority queue
        public T ExtractMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty."); // Throw an exception if the heap is empty
            var min = heap[0].Item; // Get the item with the minimum priority (root of the heap)
            heap[0] = heap[heap.Count - 1]; // Replace the root with the last item in the heap
            heap.RemoveAt(heap.Count - 1); // Remove the last item from the heap
            HeapifyDown(0); // Restore the heap property by moving the new root down
            return min; // Return the item with the minimum priority
        }

        // Method to restore the heap property by moving an item up
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2; // Calculate the index of the parent
                if (heap[index].Priority >= heap[parent].Priority) break; // If the current item has a higher or equal priority, stop
                (heap[index], heap[parent]) = (heap[parent], heap[index]); // Swap the current item with its parent
                index = parent; // Move to the parent's index
            }
        }

        // Method to restore the heap property by moving an item down
        private void HeapifyDown(int index)
        {
            while (index < heap.Count)
            {
                int left = 2 * index + 1, right = 2 * index + 2, smallest = index; // Calculate the indices of the left and right children
                if (left < heap.Count && heap[left].Priority < heap[smallest].Priority) smallest = left; // If the left child has a smaller priority, update smallest
                if (right < heap.Count && heap[right].Priority < heap[smallest].Priority) smallest = right; // If the right child has a smaller priority, update smallest
                if (smallest == index) break; // If the current item is the smallest, stop
                (heap[index], heap[smallest]) = (heap[smallest], heap[index]); // Swap the current item with the smallest child
                index = smallest; // Move to the smallest child's index
            }
        }
    }
}
