using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour
{

    public Transform playerPosition; //store player position

    void Update()
    {

        //camera follows player
        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y + 1, -10); 

    }
}
