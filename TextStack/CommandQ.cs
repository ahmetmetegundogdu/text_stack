namespace TextStack
{
    internal class CommandQ
    {
        int front, rear;
        string[] stringList;
        int maxSize;
        public int nItems;
        public CommandQ(int size)
        {
            maxSize = size;
            stringList = new string[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }
        public void Enqueue(string newElement)// Add new element to the end.
        {
            if (rear == maxSize - 1)
            {
                rear = -1;
            }
            stringList[++rear] = newElement;
            nItems++;
        }
        public string Dequeue()//Remove last element and return its value
        {
            string firstItem= stringList[front++];
            if (front == maxSize) {
                front = 0;
            }
            nItems--;
            return firstItem;
        }
        public string peekFront()//Select first element.
        {
            return stringList[front];
        }
        public bool isEmpty()//Control queue is empty.
        {
            return (nItems == 0);
        }
        public bool isFull()
        {
            return nItems == maxSize;
        }
    }
}
