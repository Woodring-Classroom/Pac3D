using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 5 * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other){
        transform.position -= transform.forward * 1.0f;
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(180, Vector3.up), 10 * Time.deltaTime);
        double val = Random.value;
        if(val < .33){
            transform.Rotate(0, 90, 0);
        } else if(val < .66){
            transform.Rotate(0, -90, 0);
        } else {
            transform.Rotate(0, 180, 0);
        }
    }
}
