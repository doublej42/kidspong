using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    private Rigidbody2D variable_rigidbody;

    [SerializeField]
    private float startingSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        variable_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            variable_rigidbody.AddForce(new Vector2(-1, 0) * startingSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("impact: " + collision.gameObject.name);
        variable_rigidbody.AddForce(collision.contacts[0].normal * startingSpeed);
    }
}
