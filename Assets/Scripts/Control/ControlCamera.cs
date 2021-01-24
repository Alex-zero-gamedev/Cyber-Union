using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public float speed = 100f;
    public int sensivity;
    public Transform player;
    float xRotation = 0f, yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        player.Rotate(Vector3.up * mouseX * mouseY);

        xRotation += mouseX * sensivity;
        yRotation -= mouseY * sensivity;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);
        yRotation = Mathf.Clamp(-90f, yRotation, 90);
        player.localRotation = Quaternion.Euler(yRotation, xRotation, 0f);
        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
