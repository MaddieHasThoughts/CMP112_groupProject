using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        //if colliding with artifact, then add point

        if (other.CompareTag("Artifact") && Time.time >= nextScoreTime)
        {
            scoreUI.Instance.addPoint();
            playerScore ++;
            nextScoreTime = Time.time + scoreCooldown;
        }

        //Move to next level
        if (playerScore >= 7)
        {
            SceneManager.LoadScene("LevelOne");
        }

        if (playerScore >= 5 && SceneManager.GetActiveScene().name == "LevelOne")
        {

            SceneManager.LoadScene("endGame");

        }

    }
 
}
