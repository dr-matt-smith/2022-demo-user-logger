using System;
using UnityEngine;

public class Scene2EntryLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        String message = "Scene 2 has just been entered"; 
        AddToLogFile.LogLine(message);        
    }
}
