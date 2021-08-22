using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingGoal : MonoBehaviour
{
    //making variable of type player action controls
    private PlayerActionMappings playerControlBindings;
    [SerializeField] private System.String NextLevelSceneName;
    

    [SerializeField] private bool IsFinalLevel;
    private bool hasDisplayedEndingText = false;

    [SerializeField] GameObject escapedText;
    [SerializeField] GameObject ContinueText;


    void Awake()
    {
        //instanciating the variable 
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

    // Start is called before the first frame update
    void Start()
    {
        playerControlBindings.LandMovement.Jump.performed += _ => Jump();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("EndingGoal Reached");
            //scene transition

            //display Otions 
            //Left -> Replay
            //Right -> Next Level
            
          
            if (IsFinalLevel)
            {
                Debug.Log("Render Text");
                escapedText.SetActive(true);
                ContinueText.SetActive(true);
                hasDisplayedEndingText = true;
            }
            else
            {
                SceneManager.LoadScene(NextLevelSceneName);
            }
           
        }
    }
    private void Jump()
    {
        if(hasDisplayedEndingText)
        {
            SceneManager.LoadScene(NextLevelSceneName);
        }
    }
}
