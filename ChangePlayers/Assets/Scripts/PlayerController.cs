using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    private CharacterController charController; //character controller refrence
    private  Animator thisAnimator; //our player animator refrence
    //our floats for horizontal and vertical movement
    private float hor; 
    private float ver;
    [SerializeField] private float speed = 5; //speed value
    [SerializeField] private float jumpForce = 8; //the jump force value
    public LayerMask groundLayer; //the ground layermask 
    public Transform groundCheckTransform; //the ground check transform to check if we are grounded
    [SerializeField] private float groundCheckRadius = 0.2f; //the ground check radius to check if we are grounded
    [SerializeField] private bool isGrounded; //bool to check if we are groundedc
    private  Vector3 jumpDirection; //the vector that represents the direction we jump at

    private void Awake()
    {
        instance = this;
    }
    //we get the components and lock the cursor 
    void Start()
    {
        charController = GetComponent<CharacterController>();
        thisAnimator = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //we get both horizontal and vertical input
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(hor, 0, ver);

        if (direction.magnitude > 0.1f)
        {
            //we calculate the angle to face the input direction
            float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
            //we rotate the player towards the angle
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 5);
        }
        //we set the Speed parameter in the animator based on the input direction
        thisAnimator.SetFloat("Speed", direction.normalized.magnitude, 0.1F, Time.deltaTime);
        //we move the character controller in the forward direction based on the input 
        charController.Move(transform.forward * direction.magnitude * speed * Time.deltaTime);

        //ground check
        isGrounded = Physics.CheckSphere(groundCheckTransform.position, groundCheckRadius, groundLayer);

        //if we are grounded and we press the jump button we can jump
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        //if we are grounded we apply gravity
        if (!isGrounded)
        {
            jumpDirection.y += Physics.gravity.y * Time.deltaTime;
        }

        //we move the character controller in the jump direction to make it more realistic
        charController.Move(jumpDirection * Time.deltaTime);
    }

    void Jump()
    {
        //we set the jump direction to make the character controller move upward
        thisAnimator.SetTrigger("Jump");
        jumpDirection = Vector3.up * jumpForce;
    }
}
