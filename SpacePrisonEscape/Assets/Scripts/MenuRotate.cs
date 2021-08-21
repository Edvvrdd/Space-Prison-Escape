using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRotate : MonoBehaviour
{
    private PlayerActionMappings playerControlBindings;
    [SerializeField] float rotationSpeed;


   
    // Update is called once per frame
    void Update()
    {
        float horizontalmovementInput = playerControlBindings.LandMovement.Move.ReadValue<float>();
        float RotationInput = playerControlBindings.LandMovement.Rotate.ReadValue<float>();

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.forward * (-1 * rotationSpeed) * Time.deltaTime);
        }
    }
}
