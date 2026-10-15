using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float cameraspeed;
    public float minX, maxX, minY, maxY;
    void Start()
    {
        
    }

    void FixedUpdate()  
    {
        if(target != null)
        {
        Vector2 newCamPosition = Vector2.Lerp(transform.position, target.position, Time.deltaTime * cameraspeed);
         float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
        float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);
        transform.position = new Vector3(ClampX, ClampY, -10f);
        }
       
        
    }
    void Update()
    {
        
    }
}
