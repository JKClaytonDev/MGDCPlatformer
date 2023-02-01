using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinController : MonoBehaviour
{
    public GameObject cameraDock;
    public bool onGround;
    Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void FixedUpdate()
    {

        lastPos.y = transform.position.y;
        float animSpeedTime = Vector3.Distance(transform.position, lastPos)/Time.fixedDeltaTime;
        if (!onGround)
            animSpeedTime /= 5;
        GetComponent<Animator>().speed = animSpeedTime/10;
lastPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        onGround = Physics.Raycast(transform.position, Vector3.down, 1.6f);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
        cameraDock.transform.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
        cameraDock.transform.eulerAngles = new Vector3(cameraDock.transform.eulerAngles.x, cameraDock.transform.eulerAngles.y, 0);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        Vector3 vel = transform.forward  * 15;
        vel.y = GetComponent<Rigidbody>().velocity.y;
        if (Input.GetMouseButton(0) && onGround)
        {
            vel.y = 15;
        }
            GetComponent<Rigidbody>().velocity = vel;
    }
}
