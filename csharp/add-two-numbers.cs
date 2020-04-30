/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode headNode = null;
        
        ListNode currentNode = null;
        ListNode currentA = l1;
        ListNode currentB = l2;
        int leftOver = 0;
                
        do
        {
            var a = currentA != null ? currentA.val : 0;
            var b = currentB != null ? currentB.val : 0;
            var value = a + b + leftOver;
            
            int remainder = value % 10;
            int carry = value > 9 ? value / 10 : 0;
            leftOver = carry;
            
            ListNode node = new ListNode(remainder, null);
            
            if(headNode == null){
                headNode = node; 
                currentNode = node;
            }else{
                currentNode.next = node;
                currentNode = node;
            }
            
            currentA = currentA?.next;
            currentB = currentB?.next;
            
        } while (currentA != null || currentB !=null || leftOver != 0 );
        
        return headNode;
    }
    
    
}
