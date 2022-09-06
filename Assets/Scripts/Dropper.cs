using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    public float wait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //float yValue = -1 * Time.deltaTime;
        if(Time.time > wait) {
            //transform.Translate(0,yValue,0);
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
