using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class _19_RemoveNthNodeFromEndofList : ILeetCodeExecute
    {

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            throw new NotImplementedException();

        }

        public void Execute()
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            //node.next.next.next = new ListNode(4);
            //node.next.next.next.next = new ListNode(5);
            //node.next.next.next.next.next = new ListNode(6);

            RemoveNthFromEnd(node, 2);
        }
    }
}
