using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject laserprefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Instantiate(this.laserprefab, this.transform.position, Quaternion.identity);
    }
}