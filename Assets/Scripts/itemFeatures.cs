using UnityEngine;

public class itemFeatures : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //end instance
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
