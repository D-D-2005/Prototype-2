using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 5;
    public float turnSpeed = 50;
    public float horizontalInput;
    private float verticalInput;
    public GameObject projectilePrefab;

    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Turns the car on the Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKey(KeyCode.F))
        {
             float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        

        


       Vector3 moveX = transform.right * x * speed;
        Vector3 moveZ = transform.forward * z * speed;


        Vector3 movement = moveX + moveZ;

        controller.SimpleMove(movement);

        }
    }

}