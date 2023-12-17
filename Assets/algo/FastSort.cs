using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class FastSort : MonoBehaviour
{
    int[] arr = new int[] { 7,6,3, 5,8};
    // Start is called before the first frame update
    void Start()
    {
        QuickSort(arr, 0, 4);
        foreach(int x in arr)
        {

        Debug.Log(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int i = left, j = right; // i, j два указателя движутся к точке поворота
            int pivot = arr[i];
            while (i < j)
            {
                while (i < j && pivot <= arr[j]) { j--; }
                arr[i] = arr[j];
                while (i < j && pivot >= arr[i]) { i++; }
                arr[j] = arr[i];
            }
            arr[i] = pivot;
            QuickSort(arr, left, i - 1);
            QuickSort(arr, i + 1, right);
        }
    }
}
