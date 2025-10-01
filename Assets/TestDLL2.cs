using System;
using System.Diagnostics;
using UnityEngine;
using System.Runtime.InteropServices;
using Test2;

public class TestDLL2 : MonoBehaviour
{
    private Class1 test2;


    void Start()
    {
        test2 = new Class1();
        test2.MeasureFunctionExecutionTime();
        UnityEngine.Debug.Log($"Managed plugin took {test2.elapsedMilliseconds} ms to execute.");
    }
}
        //test2 = new Class1(); // Initialize the object
        //Debug.Log($"Managed plugin took {test2.elapsedMilliseconds} ms to execute.");

