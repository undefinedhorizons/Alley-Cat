using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowInteraction : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Window"))
        {
            FindObjectOfType<GameManager>().WinGame();
            transform.gameObject.SetActive(false);
        }
    }
}
