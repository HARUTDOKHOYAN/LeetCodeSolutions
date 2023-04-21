namespace LeetCodeSolutions
{
    public class N206ReverseLinkedList : ILeetCodeExecute
    {
        public ListNode ReverseListBest(ListNode head)
        {
            ListNode prev = null;
            while (head is not null)
            {
                var temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }

            return prev;
        }

        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;

            List<int> vals = new List<int>();

            while (head != null)
            {
                vals.Add(head.val);
                head = head.next;
            }

            ListNode returnNode = new ListNode();
            ListNode listNode = returnNode;

            for (int i = vals.Count -1 ; i > 0 ; i--)
            {
                listNode.val = vals[i];
                listNode = listNode.next = new ListNode();
            }
            listNode.next = new ListNode(vals[0]);
            return returnNode;
        }

        public void Execute()
        {
            var node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);

            ReverseListBest(node);
        }
    }
}
