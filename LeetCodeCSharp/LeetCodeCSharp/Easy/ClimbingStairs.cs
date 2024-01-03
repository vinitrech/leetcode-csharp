namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the ClimbingStairs problem.
    /// </summary>
    /// 

    public static class ClimbingStairs
    {
        /// <summary>
        ///You are climbing a staircase. It takes n steps to reach the top.<br/>
        ///Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?<br/><br/>
        ///Example 1:<br/>
        ///Input: n = 2<br/>
        ///Output: 2<br/>
        ///Explanation: There are two ways to climb to the top.<br/>
        ///1. 1 step + 1 step<br/>
        ///2. 2 steps<br/><br/>
        ///Example 2:<br/>
        ///Input: n = 3<br/>
        ///Output: 3<br/>
        ///Explanation: There are three ways to climb to the top.<br/>
        ///1. 1 step + 1 step + 1 step<br/>
        ///2. 1 step + 2 steps<br/>
        ///3. 2 steps + 1 step<br/><br/>
        ///Constraints:<br/>
        ///1 &lt;= n &lt;= 45
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SolveClimbingStairs(int n)
        {
            var (steps, previousSteps, count) = (1, 0, 0);

            while (count < n)
            {
                (previousSteps, steps) = (steps, steps + previousSteps);
                count++;
            }

            return steps;
        }
    }
}
