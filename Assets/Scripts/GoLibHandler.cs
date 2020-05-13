using System;
using System.Runtime.InteropServices;
using Go.Interop;
using UnityEngine;

public class GoLibHandler : MonoBehaviour
{
    [DllImport("golib", EntryPoint = "GetString")] private static extern GoString InternalGetString();
    public static string GetString() { return InternalGetString(); }
    
    [DllImport("golib")] public static extern int GetInt();

    [DllImport("golib")] public static extern int Add(int x, int y);
    
    void Start()
    {
        Debug.Log(GetString());
        Debug.Log(GetInt());
        Debug.Log(Add(1,2));
    }
}
