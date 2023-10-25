using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<GameManager>().EndGame();
            transform.gameObject.SetActive(false);
        }
    }
}
