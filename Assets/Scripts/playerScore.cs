using Unity.VisualScripting;
using UnityEngine;

public class playerScoreManager : MonoBehaviour
{
    public static int playerScore; //static = non instance based
    public float scoreCooldown = 1f; //Adding cooldown to fix bug where it doubles the score
    public float nextScoreTime = 0f;

    void Start()
    {

        playerScore = 0; //initialise

    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        //if colliding with artifact, then add point (stop adding points with floor collision T^T )

        if (other.CompareTag("Artifact") && Time.time >= nextScoreTime)
        {
            playerScore ++;
            nextScoreTime = Time.time + scoreCooldown;

            Debug.Log("Yay! Points: " + playerScore); //remove before submission!!
        }

    }
 
}
