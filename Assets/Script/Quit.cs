using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void QuitApp(){
        Application.Quit();
        Debug.Log("quit");
    }
}
