using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class OBJ_Pickup : MonoBehaviour
{
    public GameObject pickup_Canvas;
    public bool canvasActive;
    public GameObject startCollectible;
    public GameObject personCollectible;
    public bool prismActive;
    public bool pipeActive;
    public bool torusActive;

    // Start is called before the first frame update
    void Start()
    {
        pickup_Canvas.SetActive(false);
        startCollectible.SetActive(true);
        personCollectible.SetActive(false);
        prismActive = false;
        pipeActive = false;
        torusActive = false;

    }

    void Update()
    {
        if (canvasActive == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                startCollectible.SetActive(false);
                personCollectible.SetActive(true);
                pickup_Canvas.SetActive(false);

                if (startCollectible.tag == "Prism")
                {
                    prismActive = true;

                }
                else
                {
                    if (startCollectible.tag == "Pipe")
                    {

                        pipeActive = true;
                    }

                    else
                    {
                        if (startCollectible.tag == "Torus")
                        {

                            torusActive = true;
                        }
                    }
                }
            }
        }
    }

        public void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                pickup_Canvas.SetActive(true);
                canvasActive = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == "Player")
            {
                pickup_Canvas.SetActive(false);
                canvasActive = false;
            }
        }
    
}
