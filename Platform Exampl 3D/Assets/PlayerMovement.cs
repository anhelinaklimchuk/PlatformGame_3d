using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rb;
    public float horizontInput;
    public float vertInput;
    public float horizontalMultiplier = 1;

    public bool isGrounded;
    void OnCollisionEnter()
    {
        isGrounded = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        //Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.forward * horizontInput * speed * Time.fixedDeltaTime*horizontalMultiplier;
        rb.MovePosition(rb.position + horizontalMove);
        

    }
    // Update is called once per frame
    void Update()
    {
        horizontInput = Input.GetAxis("Horizontal");
        //vertInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 400, 0));
        }

    }

}
