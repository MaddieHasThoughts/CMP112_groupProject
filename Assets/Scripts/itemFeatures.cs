using UnityEngine;

public class itemFeatures : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when collides with player collider, add 1 point
        
        //insert point code here

        //end instance
       
        Destroy(gameObject);

    }
}
