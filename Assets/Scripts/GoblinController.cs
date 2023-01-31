using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : MonoBehaviour
{
    public GameObject cameraDock;
    public bool onGround;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics.Raycast(transform.position, Vector3.down, 1.6f);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        cameraDock.transform.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
        cameraDock.transform.eulerAngles = new Vector3(cameraDock.transform.eulerAngles.x, cameraDock.transform.eulerAngles.y, 0);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        Vector3 vel = transform.forward * Input.GetAxis("Vertical") * 20;
        vel.y = GetComponent<Rigidbody>().velocity.y;
        if (Input.GetKey(KeyCode.Space) && onGround)
        {
            vel.y = 10;
        }
            GetComponent<Rigidbody>().velocity = vel;
    }
}
