using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;

    private void Start()
    {
        SetLaneSpawner();
    }

    /*
    private void Update()
    {
        if(IsAttackerInLane())
        {

        }

    }
    */
    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
    }

    public void Fire()
    {   
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }

}
