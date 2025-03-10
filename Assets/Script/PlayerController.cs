using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    public float jump = 10f;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool isGameOver = false;


    private Animator animator;
    public ParticleSystem smokeParticle;
    public ParticleSystem dirtParticle;

    private AudioSource AudioSource;
    public AudioClip jumpSound;
    public AudioClip deathSound;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, 10);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, -10);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            AudioSource.PlayOneShot(jumpSound, 1.0f);
            dirtParticle.Stop();
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            isOnGround = false;
            animator.SetTrigger("Jump_trig");

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            dirtParticle.Play();
            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            AudioSource.PlayOneShot(deathSound, 1.0f);
            dirtParticle.Stop();
            isGameOver = true;
            animator.SetBool("Death_b", true);
            animator.SetInteger("DeathType_int", 1);
            smokeParticle.Play();
        }
    }
}
