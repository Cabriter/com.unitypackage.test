using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using FW.Logger;

namespace FW.Logger
{
    public class LoggerEditor : Editor
    {
        [MenuItem("Logger/Log")]
        public static void Log()
        {
            Debug.Log("aaa");
        }
    }
}
