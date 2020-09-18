using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float xInput;
    private float yInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves player Left and Right
        xInput = Input.GetAxis("Horizontal");

        // Moves player Up and Down
        yInput = Input.GetAxis("Vertical");

        // Moves player up and down based on vertical input
        transform.Translate(Vector2.up * Time.deltaTime * speed * yInput);

        // Moves player left and right based on horizontal input
        transform.Translate(Vector2.right * Time.deltaTime * speed * xInput);


    }
}
