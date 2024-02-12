using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // This script is in the collider that cover the space between up and down razors

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}
