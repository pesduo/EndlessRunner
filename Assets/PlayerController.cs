using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed*Time.deltaTime *Vertical);
        transform.Rotate(Vector3.up, speed * Time.deltaTime * Horizontal);
    }
}
