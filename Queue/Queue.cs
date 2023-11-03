
using System.Collections;

class Queue: ArrayList
{
    public void Enqueue(Object value) {
        this.Add(value);
    }

    public object Dequeue() {

        if(this.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        object item = this[0];
        this.RemoveAt(0);
        return item;
    }
}