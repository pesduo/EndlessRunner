using UnityEngine;

public class MoveForward : MonoBehaviour
{

    [SerializeField] private float speed;
    private PlayerController controller;
    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if(controller.isGameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(transform.position.y< -10 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
