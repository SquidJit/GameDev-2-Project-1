using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJ_Drop : MonoBehaviour
{

    public GameObject drop_Canvas;
    public GameObject pickup_Canvas;
    public GameObject prismItem;
    public GameObject pipeItem;
    public GameObject torusItem;
    public GameObject prismPerson;
    public GameObject pipePerson;
    public GameObject torusPerson;

    public bool dropCanvasActive;
    public bool pedestalEmpty;

    public PlayerInventory playerInventory;
    public OBJ_Pickup prism;
    public OBJ_Pickup pipe;
    public OBJ_Pickup torus;

    // Start is called before the first frame update
    void Start()
    {
        drop_Canvas.SetActive(false);
        pickup_Canvas.SetActive(false);
        prismItem.SetActive(false);
        pipeItem.SetActive(false);
        torusItem.SetActive(false);
        pedestalEmpty = true;
        dropCanvasActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        DropObject();
    }

    void DropObject()
    {
        if (dropCanvasActive == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            { 
                if (prism.prismActive == true)
                {
                    prismItem.SetActive(true);
                    prismPerson.SetActive(false);
                    drop_Canvas.SetActive(false);
                    pedestalEmpty = false;
                    dropCanvasActive = false;
                    playerInventory.holdingObject = false;


                }
                else

                  if (pipe.pipeActive == true)
                {
                    pipeItem.SetActive(true);
                    pipePerson.SetActive(false);
                    drop_Canvas.SetActive(false);
                    pedestalEmpty = false;
                    dropCanvasActive = false;
                    playerInventory.holdingObject = false;

                }
                else

                 if (torus.torusActive == true)
                {

                    torusItem.SetActive(true);
                    torusPerson.SetActive(false);
                    drop_Canvas.SetActive(false);
                    pedestalEmpty = false;
                    dropCanvasActive = false;
                    playerInventory.holdingObject = false;

                }
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (pedestalEmpty == true && playerInventory.holdingObject == true)
            {
                drop_Canvas.SetActive(true);
                dropCanvasActive = true;
            }
            else
            if(pedestalEmpty == true && playerInventory.holdingObject == false)
            {
                pickup_Canvas.SetActive(false);
                drop_Canvas.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
               
                drop_Canvas.SetActive(false);
                dropCanvasActive = false;
        
        }
    }
}
