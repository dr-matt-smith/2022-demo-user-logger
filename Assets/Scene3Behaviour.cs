using System;
using UnityEngine;

public class Scene3Behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        String userId = "101";
        AddToLogFile.CreateNewLogFileWithId(userId);
        
        String message = "Scene 3 - started"; 
        AddToLogFile.LogLine(message); 
        
    }

}
