public class SortingArray
{
    private static void Main(string[] args)
    {
        int[] arr = { 5,2,8,7,1};

        for (int i = 0; i < arr.Length; i++) {   
            for (int j = i+1; j < arr.Length; j++) {   
               if(arr[i] > arr[j]) {  
                  int temp = arr[i];  
                   arr[i] = arr[j];  
                   arr[j] = temp;  
               }   
            }   
        }  
       for (int i = 0; i < arr.Length; i++) {   
            Console.Write(arr[i] + " ");  
        }  
       
    }
}
