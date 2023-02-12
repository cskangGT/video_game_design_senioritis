using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float smoothness;
    public Transform player;
    private Vector3 offset;
    public Vector3 cameraPosition;

    void Start()
    {  
        offset = new Vector3(0, 20f, -5f);
    }

    void LateUpdate()
    {
        cameraPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, cameraPosition, smoothness*Time.fixedDeltaTime);
    }
}