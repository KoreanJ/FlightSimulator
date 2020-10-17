using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objPosition;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Object's position: " + objPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
