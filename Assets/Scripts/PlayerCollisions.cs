using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    // Door Animator
    [SerializeField] private GameObject door; // An open slot in the Inspector to drag the door object into



    Animator doorAnimator;

    // Door timer
    private bool startDoorTimer = false;

    private float doorTimer = 0.0f

    [SerializeField] private float doorOpenTime = 3.0f


    // Battery sound
    [SerializeField] private AudioClip pickupCollectSound;

    // Start is called once before the first execution of update
    void Start()
    {
       doorAnimator = door.GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Run a door timer
        if (startDoorTimer)
        {
            doorTimer += Time.deltaTime;
        }

        // Automatically shut door after timer
        if (doorTimer > doorOpenTime)
        {
            ShutDoor(); // This is a custom method call

            doorTimer = 0.0f
        }
        
    }

    // Collision detection
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Check if the player hits an object with the houseDoor tag
        if(hit.gameObject.CompareTag("houseDoor"))
        {
           // print("Hit the door!");

           OpenDoor(); // This is a custom method call
        }
    }

    // Custom open door method
    void OpenDoor()
    {
        // print ("Door opening.");

        // Set Animator paramter
        doorAnimator.SetBool("doorOpen", true);

        // Start the door timer
        startDoorTimer = true;
    }

    // Custom shut door method
    void ShutDoor()
    {
        // Debug.Log("Door shutting.");

        // Set Animator parameter
        doorAnimator.SetBool("doorOpen", false);

        // Stop the door timer
        startDoorTimer = false;
    }



    // Pickup collection
    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.CompareTag("pickup"))
        {
            PickupCollect.pickupAmount++;


            audio.PlayOneShot(pickupCollectSound);


            Destroy(coll.gameObject);
        }
    }


}
