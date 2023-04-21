namespace LeetCodeSolutions
{
    internal class N142LinkedListCycleII : ILeetCodeExecute
    {

        public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> nodes = new HashSet<ListNode>();

            while (head.next != null) 
            {
                if(nodes.Contains(head)) return head;

                nodes.Add(head);
                head = head.next;
            }
            
            return null;

        }


        public void Execute()
        {
            var node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = node.next.next;

            var a  =  DetectCycle(node);
        }
    }
}
