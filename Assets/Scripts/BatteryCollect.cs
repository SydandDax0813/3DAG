using UnityEngine;
using UnityEngine.UI;

public class BatteryCollect : MonoBehaviour
{
    // Battery collection logic

    public static int pickupAmount = 0;

    // Holds the images
    public static Image hud;

    // Battery sprites
    [SerializeField] Sprite pickup1Tex;
    [SerializeField] Sprite pickup2Tex;
    [SerializeField] Sprite pickup3Tex;
    [SerializeField] Sprite pickup4Tex;
    [SerializeField] Sprite pickup0Tex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the GameObject
        hud = gameObject.GetComponentsInChildren<>();

        // Hide the Image on Start
        hud.enabled = false;

        // Set initial pickup amount
        pickupAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(pickupAmount == 1)
        {

        }
    }
}
