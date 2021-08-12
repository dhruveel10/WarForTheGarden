using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;

        if(otherCollider.GetComponent<Gravestone>())
        {
            GetComponent<Animator>().SetTrigger("Jump Trigger");         
        }

        else if (otherCollider.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }


}
