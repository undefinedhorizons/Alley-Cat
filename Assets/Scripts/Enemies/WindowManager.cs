using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _windows;
    [SerializeField] private int _current_window_number = 0;
    [SerializeField] private float _cooldown = 2.1f;
    [SerializeField] private float _delay_between_switching = 0.5f;

    void Start()
    {
        StartCoroutine(WindowManagerAI());
    }

    IEnumerator WindowManagerAI()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(_cooldown);
            StartCoroutine(ChangeActiveWindow());
        }

    }

    IEnumerator ChangeActiveWindow()
    {
        int window_number = Random.Range(0, _windows.Length);
        _windows[_current_window_number].SetActive(false);
        _windows[window_number].SetActive(true);
        yield return new WaitForSeconds(_delay_between_switching);
        _windows[window_number].GetComponent<Window>().StartShooting();
        _current_window_number = window_number;
    }
}
