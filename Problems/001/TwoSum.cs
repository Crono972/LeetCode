namespace LeetCode.Problems._001;

public class Pb
{
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i , j];
                }
            }
        }

        throw new ApplicationException("imp");
    }
}


public class PbTest
{
    [Theory]
    [InlineData(new [] {2,7,11,15}, 9, new [] {0,1})]
    [InlineData(new [] {3,2,4}, 6, new [] {1,2})]
    [InlineData(new [] {3,3}, 6, new [] {0,1})]
    public void Example1(int[] nums, int target, int[] result)
    {
        var pb = new Pb();
        var output = pb.TwoSum(nums, target);
        Assert.Equal(result, output);
    }
}