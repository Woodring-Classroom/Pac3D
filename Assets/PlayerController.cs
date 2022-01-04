using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Quaternion rotation;

    void Start(){
        rotation = transform.rotation;
    }

    void LateUpdate(){
        if(Input.GetKey(KeyCode.W)){
            transform.position += transform.forward * 2 * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S)){
            transform.position -= transform.forward * 2 * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A)){
            transform.position -= transform.right * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D)){
            transform.position += transform.right * Time.deltaTime;
        }


        if(Input.GetKeyDown(KeyCode.E)){
            rotation *= Quaternion.AngleAxis(90, Vector3.up);
        }

        if(Input.GetKeyDown(KeyCode.Q)){
            rotation *= Quaternion.AngleAxis(-90, Vector3.up);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 10 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        transform.position -= transform.forward * .5f;
    }
}
