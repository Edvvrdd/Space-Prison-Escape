using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCollisions : MonoBehaviour
{
    private PlayerActionMappings playerControlBindings;

    [SerializeField] private System.String StartingLevelName;

    [SerializeField] GameObject CreditsText;

    public bool isStart;
    public bool isOption;

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
    }

    void Jump()
    {
      //  if(isStart)
      //  {
            //load starting level
            SceneManager.LoadScene(StartingLevelName);

      //  }
        //if(isOption)
       // {
      //      //load option menu
      //      CreditsText.SetActive(true);
      //  }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("MenuTagTop"))
        {
            Debug.Log("Credits");
            isOption = true;

            CreditsText.SetActive(true);
            isStart = false;
        }
        if (collision.CompareTag("MenuTagBottom"))
        {
            isOption = false;
            Debug.Log("Start");
            isStart = true;
            CreditsText.SetActive(false);

        }
    }
}
