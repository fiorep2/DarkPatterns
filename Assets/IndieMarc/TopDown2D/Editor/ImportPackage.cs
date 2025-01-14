﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build;

/// <summary>
/// Will initialize the right settings after importing package
/// Author: Indie Marc (Marc-Antoine Desbiens)
/// </summary>

namespace IndieMarc.TopDown
{
    [InitializeOnLoad]
    public class ImportPackage
    {
        static bool completed = false;

        static ImportPackage()
        {
            EditorApplication.hierarchyChanged += AfterLoad;
        }

        static void AfterLoad()
        {
            if (!completed)
            {
                //Nothing to load yet

                completed = true;
            }
        }
        
    }

}