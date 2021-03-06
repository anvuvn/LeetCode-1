// Source : https://leetcode.com/problems/rotate-list/ 
// Author : codeyu 
// Date : Sunday, December 11, 2016 4:10:11 PM 

/**********************************************************************************
*
* Given a list, rotate the list to the right by k places, where k is non-negative.
* 
* For example:
* Given 1.2.3.4.5.null and k = 2,
* return 4.5.1.2.3.null.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    public class Solution061
    {
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || k == 0)  
                return head;  
            int len = 1;  
            ListNode p = head;  
            while (p.next != null) { // 求长度  
                len++;  
                p = p.next;  
            }  
            k = len - k % len;  
            p.next = head; // 首尾相连  
            for(int step = 0; step < k; step++) {  
                p = p.next; //接着往后跑  
            }  
            head = p.next; // 新的首节点  
            p.next = null; // 断开环  
            return head; 
        }
    }
    
}

