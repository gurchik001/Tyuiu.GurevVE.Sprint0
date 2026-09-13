namespace Tyuiu.GurevVE.Sprint0.Task7.V0.lib
{


    public class DataService
    {

        public static int[] AddiitonArrays(int[] numOne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }
            return resultArray;
        }

        public static int[] AdditionArrays(int[] nums1, int[] nums2)
        {
            throw new NotImplementedException();
        }
    }    

}