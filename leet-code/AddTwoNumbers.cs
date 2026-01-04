
  //Definition for singly-linked list.
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val; 
         this.next = next;
      }
  }
 
public partial class Solution {
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode? previous = null;
        ListNode? head = null;
        var buffer = 0;
        
        while(l1 != null || l2 != null || buffer > 0)
        {
            var sum = 0;
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null) 
            {
                sum += l2.val;
                l2 = l2.next;
            }
            
            if (buffer > 0)
            {
                sum += buffer;
                buffer = 0;
            }

            if (sum >= 10)
            {
                buffer = sum / 10;
                sum %= 10;
            }

            var node = new ListNode(sum);
            if (previous != null) previous.next = node;
            else head = node;

            previous = node;
        }

        return head;
    }
}
