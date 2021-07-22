using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{   
    public Transform lookAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate() 
    {
        Vector3 delta = Vector3.zero;
        
        // check if inside of bounds on x axis
        float deltaX = lookAt.position.x - transform.position.x;
        if (deltaX > boundX) 
        {
            delta.x = deltaX - boundX;
        } 
        else if (deltaX < -boundX)
        {
            delta.x = deltaX + boundX;
        }

        // check if inside of bounds on y axis
        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundY) 
        {
            delta.y = deltaY - boundY;
        } 
        else if (deltaY < -boundY)
        {
            delta.y = deltaY + boundY;
        }

        transform.position += new Vector3(delta.x, delta.y, 0);

    }
}
