using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move8 : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    private Vector3 a;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedModifier = .42f;
    }

    // Update is called once per frame
    void Update()
    {
        // rb.velocity = Vector3.zero;
        // rb.angularVelocity = Vector3.zero;
        if (Input.touchCount > 0) {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved){
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier * Time.deltaTime,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier * Time.deltaTime);
            }
        }
        else {
            a = rb.velocity;
            rb.velocity = new Vector3(0, a.y, 0);
        }
    }
}
