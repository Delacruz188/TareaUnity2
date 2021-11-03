using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(inputX * speed, inputY*speed);
        movement *= Time.deltaTime;
        if(movement.x < 0)
        {
            Vector2 escala = transform.localScale;
            escala.x *= -1;
            transform.localScale = escala;
            transform.Translate(movement);

        }
        if (movement.x > 0)
        {
            Vector2 escala = transform.localScale;
            escala.x *= 1;
            transform.localScale = escala;
            transform.Translate(movement);

        }
    }
}
