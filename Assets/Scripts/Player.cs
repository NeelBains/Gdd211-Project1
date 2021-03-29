using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MouseSensitivity;
    public Transform CamTransform;
    private float camRotation = 0f;

    public CharacterController CC;
    public float MoveSpeed;
    public float Gravity = -9.8f;
    public float JumpSpeed;
    public float verticalSpeed;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        //Camera Controls
        float mouseInputY = Input.GetAxis("Mouse Y") * MouseSensitivity;
        camRotation -= mouseInputY;
        camRotation = Mathf.Clamp(camRotation, -90f, 90f);
        CamTransform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0f, 0f));

        float mouseInputX = Input.GetAxis("Mouse X") * MouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0f, mouseInputX, 0f));

        //Movement
        Vector3 movement = Vector3.zero;

        // X/Z movement
        float forwardMovement = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        float sideMovement = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;

        movement += (transform.forward * forwardMovement) + (transform.right * sideMovement);

        if (CC.isGrounded)
        {
            verticalSpeed = 0f;
            if (Input.GetKey(KeyCode.Space))
            {
                verticalSpeed = JumpSpeed;
            }
        }

        verticalSpeed += (Gravity * Time.deltaTime);
        movement += (transform.up * verticalSpeed * Time.deltaTime);

        CC.Move(movement);


        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(CamTransform.position, CamTransform.forward, out hit))
            {
                Debug.DrawLine(CamTransform.position + new Vector3(0f, -1f, 0f), hit.point, Color.red);

                if (hit.collider.GetComponent<Interactable>())
                {
                    hit.collider.GetComponent<Interactable>().Hit();
                }
            }
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            CC.height = 1.0f;
        }
        else
        {
            CC.height = 2.0f;
        }

    }
}
