using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    //making variable of type player action controls
    private PlayerActionMappings playerControlBindings;

    [SerializeField] private float rotationSpeed;

    [SerializeField] GameObject[] ObjectArray;

    private bool HasRotated = false;

    private void Awake()
    {
        playerControlBindings = new PlayerActionMappings();

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
        //Display Player Objective
        //"Create a patyh to the exit"

      

    }
    private void Jump()
    {
        for (int i = 0; i < ObjectArray.Length; i++)
        {
            Debug.Log("Box # " + i);
            ObjectArray[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
        HasRotated = true;
    }

    void Update()
    {
        if(!HasRotated)
        {
            float RotationInput = playerControlBindings.LandMovement.Rotate.ReadValue<float>();

            if (RotationInput < 0)
            {
                Debug.Log("Reciving Left Rotation Input");
                // Rotate the object around its local X axis at 1 degree per second
                this.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
                this.transform.parent = this.transform;
                this.GetComponent<Rigidbody2D>().gravityScale = 0;
                //  this.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
            if (RotationInput > 0)
            {
                Debug.Log("Reciving Left Rotation Input");
                // Rotate the object around its local X axis at 1 degree per second
                this.transform.Rotate(Vector3.forward * -1 * rotationSpeed * Time.deltaTime);


            }
        }
     
    }
}
