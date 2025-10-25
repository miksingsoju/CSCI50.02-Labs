
|int N = 7; 
|int[] arr = {64, 34, 25, 12, 22, 11, 90}; 

|int i = 0; 
       
|while (i < N - 1) { 
|       int j = 0;
|       int swapped = 0; 
|       while (j < N - i - 1) { 
|               if (arr[j] > arr[j + 1]) { 
|                       // swap arr[j] and arr[j+1] 
|                        int temp = arr[j]; 
|                        arr[j] = arr[j + 1]; 
|                         arr[j + 1] = temp; 
                        | swapped = 1; 
                } 

|        j = j + 1; 
|        } 
        if (swapped == 0) { 
|        break; // no swaps → already sorted 
        } 
|       i = i + 1; 
|}
