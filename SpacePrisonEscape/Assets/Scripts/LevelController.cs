using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelController : MonoBehaviour
{
    //making variable of type player action controls
    private PlayerActionMappings playerControlBindings;
    

    [SerializeField] private System.String CurrentSceneName;

    [SerializeField] private float rotationSpeed;

    [SerializeField] private Transform SpawnLoacation;


    [SerializeField] private GameObject[] ObjectArray;

    [SerializeField] private GameObject PlayerSpawn;


    private bool HasRotated = false;
    private bool HasSpawnedPlayer = false;

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

        playerControlBindings.LandMovement.Reset.performed += _ => Reset();
        //Display Player Objective
        //"Create a patyh to the exit"

    }

    private void Jump()
    {
        // using action map to freeze all objects in level
        Stasis();
        //after finish rotating level player may pawn
        SpawnPlayer();
    }

    private void Reset()
    {
        SceneManager.LoadScene(CurrentSceneName);
    }

    private void Stasis()
    {
        for (int i = 0; i < ObjectArray.Length; i++)
        {
            Debug.Log("Box # " + i);
            ObjectArray[i].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }

        HasRotated = true;
    }
    private void SpawnPlayer()
        {
        //Spawn Player at spawnLocation
        if (!HasSpawnedPlayer)
        {
            Instantiate(PlayerSpawn, SpawnLoacation.position, Quaternion.identity);
            HasSpawnedPlayer = true;
        }
    }


    void Update()
    {
        if(!HasRotated)
        {
            float RotationInput = playerControlBindings.LandMovement.Rotate.ReadValue<float>();
            float RotationInputWASD = playerControlBindings.LandMovement.Move.ReadValue<float>();

            if ((RotationInput < 0) || (RotationInputWASD < 0))
            {
              //  Debug.Log("Reciving Left Rotation Input");
                // Rotate the object around its local X axis at 1 degree per second
                this.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
                //this.transform.parent = this.transform;
               // this.GetComponent<Rigidbody2D>().gravityScale = 0;
                
            }
            if ((RotationInput > 0) || (RotationInputWASD > 0))
            {
              //  Debug.Log("Reciving Left Rotation Input");
                // Rotate the object around its local X axis at 1 degree per second
                this.transform.Rotate(Vector3.forward * -1 * rotationSpeed * Time.deltaTime);


            }
        }
     
    }
}
