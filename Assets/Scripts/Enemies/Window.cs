using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private GameObject[] _projectiles;
    [SerializeField] private float _cooldown = 2f;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    public void StartShooting()
    {
        StartCoroutine(WindowAI());
    }

    IEnumerator WindowAI()
    {
        while (enabled)
        {
            ShootProjectile();
            yield return new WaitForSeconds(_cooldown);
        }

    }

    void ShootProjectile()
    {
        int projectile_number = FindProjectile();
        
        if (projectile_number == -1)
        {
            return;
        }

        _projectiles[projectile_number].transform.position = transform.position;
        _projectiles[projectile_number].GetComponent<Projectile>().ShootAt(_player.transform.position);
    }

    private int FindProjectile()
    {
        for (int i = 0; i < _projectiles.Length; ++i)
        {
            if (!_projectiles[i].activeInHierarchy)
                return i;
        }

        return -1;
    }


}
