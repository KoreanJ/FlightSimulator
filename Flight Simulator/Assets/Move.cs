using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Variables
    public float pitch_rate = 20.0f;
    public float yaw_rate = 10.0f;
    public float roll_rate = 20.0f;
    public float thrust = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Time.deltaTime converts to m/s instead of m/frame
        float pitch = Input.GetAxis("Vertical") * pitch_rate * Time.deltaTime;
        float roll = Input.GetAxis("Horizontal") * roll_rate * Time.deltaTime;

        transform.Rotate(pitch, 0, 0);
        transform.Rotate(0, 0, -roll);

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * thrust * Time.deltaTime);
        }
    }
}
