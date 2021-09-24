using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movmentSpeed = 10f;
    void Start()
    {
      
    }

    
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movmentSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movmentSpeed;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);
    }
}
