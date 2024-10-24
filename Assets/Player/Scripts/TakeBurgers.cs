using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBurgers : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Burger")
        {
            other.gameObject.SetActive(false);
        }
    }
}
