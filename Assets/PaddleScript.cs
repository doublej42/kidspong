using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PaddleScript : MonoBehaviour
{
    [SerializeField]
    bool playerOne = true;

    [SerializeField]
    float speed = 0.1f;
    

    float currentSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var upKey = KeyCode.Q;
        var downKey = KeyCode.A;
        if (!playerOne)
        {
            upKey = KeyCode.UpArrow;
            downKey = KeyCode.DownArrow;
        }
        if (Input.GetKeyDown(upKey))
        {
            currentSpeed = speed;
        }
        if (Input.GetKeyUp(upKey) && !Input.GetKey(downKey))
        {
            currentSpeed = 0;
        }
        if (Input.GetKeyDown(downKey))
        {
            currentSpeed = -1 * speed;
        }
        if (Input.GetKeyUp(downKey) && !Input.GetKey(upKey))
        {
            currentSpeed = 0;
        }

    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, currentSpeed);

    }
}
