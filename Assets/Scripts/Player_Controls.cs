using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Controls : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    AudioSource jumpSound; 
    private int jumpStack;
    private float jumpTimer;
    private Vector2 moveInput;
    private Rigidbody2D rb;

    [Header("Movement")]
    public float jumpCooldown;
    public float jumpHeight;
    public int jumps;
    public float speed;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // instantiation stuff goes here
        rb = GetComponent<Rigidbody2D>();
        jumpStack=0;
    }
    void Start()
    {
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //timers 
        if (jumpTimer >= 0)
        {
            jumpTimer -= Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        Vector2 move = new Vector2(moveInput.x, 0);
        transform.Translate(move*speed);       
        if (move.x != 0)
        {
            _animator.SetBool("isRunning", true);
        } 
        else _animator.SetBool("isRunning", false);
        if (rb.linearVelocityY != 0)
        {
            _animator.SetBool("isJumping", true);
        } else _animator.SetBool("isJumping", false);
    }

    public void OnJump()
    {
        Debug.Log("Jump " + jumpStack);
        // first jump if on solid ground 
        if (rb.linearVelocityY==0)
        {
            // do jump 
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            // start timer
            jumpTimer = jumpCooldown;
            // update case to 1
            jumpStack=1;
            jumpSound.pitch=1;
            jumpSound.Play();
        }
        else
        {
            if (jumps > jumpStack)
            {
                // do jump 
                rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                jumpTimer = jumpCooldown;
                jumpSound.pitch = Mathf.Pow(1.2f, jumpStack);
                jumpSound.Play();
                jumpStack+=1;
            } else Debug.Log("Can not do more than " + jumps + " jumps");
            
        }
        
        // jump needs a cooldown before double jump

        // needs to not allow a triple jump 
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        // flip sprite 
        if (moveInput.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX=true;
        } else if (moveInput.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX=false;
        } 
    }
}
