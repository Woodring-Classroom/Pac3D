using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Transform player;
    private Vector3 offset;
    private Vector3 direction;

    void Start(){
        player = GameObject.Find("Player").transform;
        offset = new Vector3(0, 0, -2);
    }

    void Update(){
        direction = player.transform.forward + offset;
        transform.position = player.transform.position + direction;
        transform.rotation = player.transform.rotation;
    }
}
