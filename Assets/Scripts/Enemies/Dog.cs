using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    [SerializeField] private float _speed = 2f;
    private float _max_distance = 0.05f;
    [SerializeField] private float _wait_time = 3f;
    private float _initial_wait_time;

    // Update is called once per frame
    void Start()
    {
        _initial_wait_time = Random.Range(_wait_time, _wait_time * 2);
        StartCoroutine(DogAI());
        
    }

    IEnumerator DogAI()
    {
        yield return new WaitForSeconds(_initial_wait_time);

        while (enabled)
        {
            if (hasArrivedToWaypoint())
            {
                yield return new WaitForSeconds(_wait_time);

                currentWaypointIndex++;
                if (currentWaypointIndex >= waypoints.Length)
                {
                    currentWaypointIndex = 0;
                }
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * _speed);
                yield return null;
            }
        }

    }


    private bool hasArrivedToWaypoint()
    {
        float distance = Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position);
        return distance < _max_distance;
    }
}
