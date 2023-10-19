using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        if (other.gameObject.CompareTag("Candy"))
        {

            //add score here
            // print score here
            Destroy(other.gameObject);
        }
    }
}
