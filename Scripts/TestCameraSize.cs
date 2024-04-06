using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraSize : MonoBehaviour
{
    // Start is called before the first frame update
   public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        print(cam.pixelWidth);    
        print(cam.pixelHeight);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
