using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterWeight : MonoBehaviour
{
    [SerializeField]public GameObject character;
    private Rigidbody rb;
    private float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 heading =  character.transform.position - transform.position;
        float distance = heading.magnitude;
        Vector3 headingSaved = heading;
        heading = heading/distance;
        //rb.AddForce(Vector3.forward,ForceMode.Force);
        rb.AddForce(headingSaved*5f - heading*3f,ForceMode.VelocityChange);
        ///transform.position += heading*Time.deltaTime*speed;
    }
}
