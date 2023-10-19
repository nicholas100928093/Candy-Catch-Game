using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] private Text text;

    private Vector3 moveDirection;
    private int score = 0;

    void Start()
    {
        InputManager.Initialize(this);
        text.text = "Score : 0";
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

            score++;
            text.text = "Score : " + score;
            Destroy(other.gameObject);
        }
    }
}
