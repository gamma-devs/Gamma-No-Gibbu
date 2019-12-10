using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform playerObject;

    [SerializeField]
    private float cameraSmoothing;

    [SerializeField]
    private Vector2 maxPosition;

    [SerializeField]
    private Vector2 minPosition;


    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != playerObject.position) { 
            Vector3 targetPosition = new Vector3(playerObject.position.x, playerObject.position.y, transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSmoothing);
        }
    }
}
