using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour
{
    public static AIPlayer instance;
    private CharacterController controller; //refrence to our controller
    private Animator anim; //refrence to our animator
    public float speed = 5f; //refrence to our speed
    public Transform target;  //our target
    public float followRadius = 5f; //the follow radius in whiich the ai will follow the target

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //get all the components,lokc the cursor and look at the target
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        transform.LookAt(target);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, followRadius);
    
    }

   
    void Update()
    {
       

        if (target != null)
        {
            Vector3 dirToTarget = (target.position - transform.position).normalized;

          
            if (dirToTarget != Vector3.zero)
            {
                //we calculate the target angle to face the target
                float angle = Mathf.Atan2(dirToTarget.x, dirToTarget.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
                Quaternion rotation = Quaternion.Euler(0, angle, 0);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 5);
            }

            float disToTarget = Vector3.Distance(transform.position, target.position);

           
            if (disToTarget > followRadius)
            {
                transform.LookAt(target); //look at the target
                anim.SetFloat("Speed", 1.0f, 0.1f, Time.deltaTime); //we set the animation speed to follow the target
                controller.Move(dirToTarget * speed * Time.deltaTime); //we move the controller to the target direction
            }
            else
            {
                //the ai stops moving if within the follow radius
                anim.SetFloat("Speed", 0.0f, 0.0f, Time.deltaTime);
            }
        }
    }
}