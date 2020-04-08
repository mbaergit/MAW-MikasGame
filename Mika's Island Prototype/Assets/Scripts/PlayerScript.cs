using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float xInput;
    float zInput;
    float mouseXInput;
    float mouseYInput;
    public float rotationTop;
    public float rotationBottom;

    Rigidbody rb;
    public float moveSpeed;

    GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Move();
        Rotate();
    }

    void CheckInput()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        mouseXInput = Input.GetAxis("Mouse X");
        mouseYInput = Input.GetAxis("Mouse Y");
        //mouseYInput = Mathf.Clamp(mouseYInput, rotationBottom, rotationTop);
    }

    void Move()
    {
        transform.Translate(xInput * moveSpeed, 0, zInput * moveSpeed);
        //rb.transform.localPosition = new Vector3(rb.transform.position.x + (xInput * moveSpeed), rb.transform.position.y, rb.transform.position.z + (zInput * moveSpeed));
    }

    void Rotate()
    {
        transform.Rotate(0, mouseXInput, 0);
        mainCamera.transform.Rotate(-mouseYInput, 0, 0);
    }
}
