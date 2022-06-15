public static class LeftRotation
{
    public static void Execute()
    {
        int[] array = new int[]{1, 2, 3, 4, 5};

        int rotate = 1; 

        int size = array.Length;

        int[] newArray = new int[size];

        int i = 0;

        int rotateIndex = rotate;

        while(rotateIndex < size)
        {
            newArray[i] = array[rotateIndex];

            i++;

            rotateIndex++;
        }

        rotateIndex = 0;

        while(rotateIndex < rotate)
        {
            newArray[i] = array[rotateIndex];

            i++;

            rotateIndex++;
        }

        foreach(int n in newArray)
        {
            Console.WriteLine(n);
        }
    }
}