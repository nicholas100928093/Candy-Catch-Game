using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Candy"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(other.gameObject);
        }
    }
}
