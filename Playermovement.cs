using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed = 5f; // Adjust this to change movement speed

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        // Apply movement to the GameObject
        transform.Translate(movement);

        // (Optional) You may want to rotate the player to face the direction of movement
        // For example, uncomment the following lines to rotate the player
        // if (movement != Vector3.zero)
        // {
        //     transform.rotation = Quaternion.LookRotation(movement);
        // }
    }
}


