using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingGoal : MonoBehaviour
{
    //making variable of type player action controls
    private PlayerActionMappings playerControlBindings;
    //  [SerializeField] private Scene nextScene;

    // Start is called before the first frame update
    void Start()
    {
        
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
            
            SceneManager.LoadScene("Level1");
        }
    }
}
