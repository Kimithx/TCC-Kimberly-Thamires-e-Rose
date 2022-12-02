using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocity = 400.0f;
    public float rotation = 180.0f;

    void Start(){
          Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");

        Vector3 dir = new Vector3(x, 0, y) * velocity;

        transform.Translate(dir * Time.deltaTime);
        transform.Rotate(new Vector3(0, mouseX * rotation* 10 * Time.deltaTime, 0));
    }
}
