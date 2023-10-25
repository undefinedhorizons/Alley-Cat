using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private float _cooldown = 1f;

    void Start()
    {
        StartCoroutine(WindowAI());
    }

    IEnumerator WindowAI()
    {
        while (enabled)
        {
            
            yield return new WaitForSeconds(_cooldown);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
