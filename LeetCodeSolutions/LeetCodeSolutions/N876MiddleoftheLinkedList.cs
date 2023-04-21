namespace LeetCodeSolutions
{
    internal class N876MiddleoftheLinkedList : ILeetCodeExecute
    {
        public void Execute()
        {
            ListNode node = new ListNode();

            ListNode point1 = node;
            ListNode point2 = node;
            while (point1.next != null)
            {
                if (point1.next.next == null) point1 = point1.next;
                else point1 = point1.next.next;

                point2 = point2.next;
            }
        }
    }
}
