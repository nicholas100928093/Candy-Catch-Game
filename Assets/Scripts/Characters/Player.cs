using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float speed;

    private Vector3 moveDirection;

    void Start()
    {
        InputManager.Initialize(this);
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * moveDirection;

    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        moveDirection = newDirection;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //If player collides with object tagged "Coin"
        if (other.transform.tag == "Candy")
        {

            //add score here
            // print score here
            Destroy(other.gameObject);
        }
    }
}
