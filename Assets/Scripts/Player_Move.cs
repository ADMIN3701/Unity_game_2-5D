using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0.5f;
    private Vector3 moveVector;
    private Animator _animator;
    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal") * speed;
        moveVector.z = Input.GetAxis("Vertical") * speed;
        rb.MovePosition(rb.position + moveVector * Time.deltaTime);
        _animator.SetFloat("RunSide", Mathf.Abs(Input.GetAxisRaw("Horizontal")));

        if (moveVector.x < 0) spriteRenderer.flipX = true;
        else spriteRenderer.flipX = false;

        if (moveVector.z < 0)
            _animator.SetFloat("RunFront", -1);
        else
            _animator.SetFloat("RunFront", 0);

        if (moveVector.z > 0)
            _animator.SetFloat("RunBack", 1);
        else
            _animator.SetFloat("RunBack", 0);

        if (moveVector.z != 0 || moveVector.x != 0)
            audioSource.mute = false;
        else audioSource.mute = true;
    }
}