using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class HeroController : MonoBehaviour
{

    public float speed = 5;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector2 movimentVector = new Vector2(Input.GetAxisRaw("Horizontal"), 
            Input.GetAxisRaw("Vertical"));

        if(movimentVector != Vector2.zero)
        {
            var playerMovement = new Vector2(movimentVector.x, movimentVector.y) * speed;

            body.velocity = playerMovement;
        } 
        else 
        {
            body.velocity = Vector2.zero;
        }

    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "exit")
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}
