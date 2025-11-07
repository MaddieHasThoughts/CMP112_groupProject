using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour
{

    public Transform playerPosition; //store player position

    void Update()
    {

        transform.position = new Vector3(playerPosition.position.x, playerPosition.position.y, -10); //camera follows player



    }
}
