using System.Collections.Generic;

namespace LeetCodeSolutions
{
    internal class _21_MergeTwoSortedLists : ILeetCodeExecute
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }


        public ListNode GetResult(ListNode list1, ListNode list2)
        {
            var result = new List<int>();
            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    result.Add(list2.val);
                    list2 = list2.next;
                    continue;
                }

                if (list2 == null)
                {
                    result.Add(list1.val);
                    list1 = list1.next;
                    continue;
                }

                if (list1.val > list2.val)
                {
                    result.Add(list2.val);
                    list2 = list2.next;
                }
                else if (list1.val < list2.val)
                {
                    result.Add(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    result.Add(list1.val);
                    list1 = list1.next;
                    result.Add(list2.val);
                    list2 = list2.next;
                }
            }
            ListNode listResult = null;
            foreach (var item in result)
            {
                if (listResult == null)
                    listResult = new ListNode(item);
                else
                    AddItemInList(listResult, item);
            }
            return listResult;
        }

        public void AddItemInList(ListNode listNode , int valur)
        {
            while(true)
            {
                if(listNode.next == null)
                {
                    listNode.next = new ListNode(valur);
                    break;
                }
                listNode = listNode.next;
            }
        }

        public void Execute()
        {
            List<int> a = new List<int> { };
            List<int> b = new List<int> { 0 };

            ListNode list1 = null;
            ListNode list2 = null;

            foreach (var item in a)
            {
                if (list1 == null)
                    list1 = new ListNode(item);
                else 
                    AddItemInList(list1, item);
            }

            foreach (var item in b)
            {
                if (list2 == null)
                    list2 = new ListNode(item);
                else
                    AddItemInList(list2, item);
            }


            var result = GetResult(list1, list2);


        }
    }
}
