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

        if(Input.GetKeyDown(KeyCode.D)){
            rotation *= Quaternion.AngleAxis(90, Vector3.up);
        }

        if(Input.GetKeyDown(KeyCode.A)){
            rotation *= Quaternion.AngleAxis(-90, Vector3.up);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 10 * Time.deltaTime);
    }
}
