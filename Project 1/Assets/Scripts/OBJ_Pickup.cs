using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class OBJ_Pickup : MonoBehaviour
{
    public GameObject pickup_Canvas;
   
    // Start is called before the first frame update
    void Start()
    {
        pickup_Canvas.SetActive(false);
    }

    private void OnColliderEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pickup_Canvas.SetActive(true);
        }
    }
}
