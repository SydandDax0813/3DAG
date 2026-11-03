using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Collision detection
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Check if the player hits an object with the houseDoor tag
        if(hit.gameObject.CompareTag("houseDoor"))
        {
           print("Hit the door!"); 
        }
    }
}
