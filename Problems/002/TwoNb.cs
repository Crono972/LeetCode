using System.Text;

namespace LeetCode.Problems._002;

/**
 * Definition for singly-linked list.
 */
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

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var l1Str = ListNodeToStr(l1);
        var l2Str = ListNodeToStr(l2);
        var retenu = false;
        ListNode ret = null;
        ListNode previous = null;
        for (int i = 0; i < Math.Max(l1Str.Length, l2Str.Length); i++)
        {
            var somme = 0;
            if (i < l1Str.Length)
            {
                somme += int.Parse(l1Str[i].ToString());
            }

            if (i < l2Str.Length)
            {
                somme += int.Parse(l2Str[i].ToString());
            }

            if (retenu)
            {
                somme++;
            }
            
            retenu = somme >= 10;
            if (ret == null)
            {
                ret = new ListNode(somme % 10);
                previous = ret;
            }
            else
            {
                var next = new ListNode(somme % 10);
                previous.next = next;
                previous = next;
            }
        }

        if (retenu)
        {
            var next = new ListNode(1);
            previous.next = next;
        }

        return ret;
    }

    private string ListNodeToStr(ListNode l)
    {
        StringBuilder res = new StringBuilder();
        res.Append(l.val.ToString());
        ListNode next = l.next;
        while (next != null)
        {
            res.Append(next.val.ToString());
            next = next.next;
        }

        var s = res.ToString();
        return s;
    }
}

public class SolutionTest
{
    [Fact]
    public void Test()
    {
        var solv = new Solution();
        var l1 = new ListNode(9);
        var l2 = new ListNode(1,
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9))))))))));

        var output = solv.AddTwoNumbers(l1, l2);
    }
}