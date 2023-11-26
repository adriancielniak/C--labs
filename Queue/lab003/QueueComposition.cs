
using System.Collections;

class QueueComposition
{
    private ArrayList list = new ArrayList();

    public void Enqueue(Object value) {
        list.Add(value);
    }

    public Object Dequeue() {
        if(list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        object item = list[0];
        list.RemoveAt(0);
        return item;
    }
}