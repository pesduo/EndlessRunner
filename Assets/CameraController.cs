using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera Camera;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = offset;
    }
}
