using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //making variable of type player action controls
    private PlayerActionMappings playerControlBindings;

    [SerializeField] private float speed, jumpSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private LayerMask ground;
    [SerializeField] private LayerMask rotationSwitch;

    [SerializeField] private GameObject RotatableEnvironment;




    private Collider2D collider2D;

    private Rigidbody2D rb;
    void Awake()
    {
        //instanciating the variable 
        playerControlBindings = new PlayerActionMappings();
        rb = GetComponent<Rigidbody2D>();
        collider2D = GetComponent<Collider2D>();

    }
    //Enabling controls 
    private void OnEnable()
    {
        playerControlBindings.Enable();
    }
    private void OnDisable()
    {
        playerControlBindings.Disable();
    }
    void Start()
    {
        playerControlBindings.LandMovement.Jump.performed += _ => Jump();
    }

    private void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        Vector2 topLeftPoint = transform.position;
        topLeftPoint.x -= collider2D.bounds.extents.x;
        topLeftPoint.y += collider2D.bounds.extents.y;

        Vector2 bottomRightPoint = transform.position;
        bottomRightPoint.x += collider2D.bounds.extents.x;
        bottomRightPoint.y -= collider2D.bounds.extents.y;

        return Physics2D.OverlapArea(topLeftPoint, bottomRightPoint, ground);
    }
    private bool IsOnSwitch()
    {
        Vector2 topLeftPoint = transform.position;
        topLeftPoint.x -= collider2D.bounds.extents.x;
        topLeftPoint.y += collider2D.bounds.extents.y;

        Vector2 bottomRightPoint = transform.position;
        bottomRightPoint.x += collider2D.bounds.extents.x;
        bottomRightPoint.y -= collider2D.bounds.extents.y;

        return Physics2D.OverlapArea(topLeftPoint, bottomRightPoint, rotationSwitch);
    }

    // Update is called once per frame
    void Update()
    {
        //read input from keyvboard action bindings
        float horizontalmovementInput = playerControlBindings.LandMovement.Move.ReadValue<float>();
        float RotationInput = playerControlBindings.LandMovement.Rotate.ReadValue<float>();

        //movement
        if (horizontalmovementInput != 0)
        {
            GetComponent<Animator>().SetBool("IsRunning", true);
            //Debug.Log("IsRunning");
            //turns the player the correct direction 
            if (horizontalmovementInput > 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            //move the player
            Vector3 currentPosition = transform.position;
            currentPosition.x += horizontalmovementInput * speed * Time.deltaTime;
            transform.position = currentPosition;
        }
        else
        {
            GetComponent<Animator>().SetBool("IsRunning", false);
            Debug.Log("NotRunning");
        }
        if (IsOnSwitch())
        {
            Debug.Log("OnSwitch");
            //rotate player using enivronment rotation 

           // this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
                //GetComponent<Rigidbody>();
                //This locks the RigidBody so that it does not move or rotate in the Z axis.
          //  m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
            {
                if (RotationInput < 0)
                {
                    Debug.Log("Reciving Left Rotation Input");
                    // Rotate the object around its local X axis at 1 degree per second
                    RotatableEnvironment.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
                    this.transform.parent = RotatableEnvironment.transform;
                   this.GetComponent<Rigidbody2D>().gravityScale = 0;
                  //  this.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
                }
                if (RotationInput > 0)
                {
                    Debug.Log("Reciving Left Rotation Input");
                    // Rotate the object around its local X axis at 1 degree per second
                    RotatableEnvironment.transform.Rotate(Vector3.forward * -1 * rotationSpeed * Time.deltaTime);
                    this.transform.parent = RotatableEnvironment.transform;
                    this.GetComponent<Rigidbody2D>().gravityScale = 0;
                    //this.transform.Rotate(Vector3.forward * -1 * rotationSpeed * Time.deltaTime);
                }


                // ...also rotate around the World's Y axis
                //transform.Rotate(Vector3.up * 2 * Time.deltaTime, Space.World);

            }
            // }
        }
        else
        {
            // unlock freezing 
            this.transform.parent = null;
            this.GetComponent<Rigidbody2D>().gravityScale = 1;
            // this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
    }
}
