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
    public GameObject pedestal;


    public bool dropCanvasActive;
    public bool pickupCanvasActive;
    public bool pedestalEmpty;
    public bool prismOnPedestal;
    public bool pipeOnPedestal;
    public bool torusOnPedestal;

    public PlayerInventory playerInventory;
    public PlayerInventory m_prismActive;
    public PlayerInventory m_pipeActive;
    public PlayerInventory m_torusActive;


    // Start is called before the first frame update
    void Start()
    {
        drop_Canvas.SetActive(false);
        pickup_Canvas.SetActive(false);
        dropCanvasActive = false;
        pickupCanvasActive = false;
        StartPedestals();
    }

    // Update is called once per frame
    void Update()
    {
        DropObject();
        PickUpObject();
    }

    void DropObject()
    {
        if (dropCanvasActive == true && playerInventory.holdingObject == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (m_prismActive.prismActive == true)
                {
                    prismItem.SetActive(true);
                    prismPerson.SetActive(false);
                    drop_Canvas.SetActive(false);
                    pedestalEmpty = false;
                    dropCanvasActive = false;
                    playerInventory.holdingObject = false;
                    m_prismActive.prismActive = false;
                    prismOnPedestal = true;
                }
               
                
                if (m_pipeActive.pipeActive == true)
                {
                   pipeItem.SetActive(true);
                   pipePerson.SetActive(false);
                   drop_Canvas.SetActive(false);
                   pedestalEmpty = false;
                   dropCanvasActive = false;
                   playerInventory.holdingObject = false;
                   m_pipeActive.pipeActive = false;
                   pipeOnPedestal = true;

                }
                    
                    
                if (m_torusActive.torusActive == true)
                {

                  torusItem.SetActive(true);
                  torusPerson.SetActive(false);
                  drop_Canvas.SetActive(false);
                  pedestalEmpty = false;
                  dropCanvasActive = false;
                  playerInventory.holdingObject = false;
                  m_torusActive.torusActive = false;
                  torusOnPedestal = true;
                }
                    
            }
        }
    }
    
    
    

    void PickUpObject()
    {
        if (pickupCanvasActive == true && playerInventory.holdingObject == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (prismOnPedestal == true)
                {
                    m_prismActive.prismActive = true;
                    prismItem.SetActive(false);
                    prismPerson.SetActive(true);
                    pickup_Canvas.SetActive(false);
                    pickupCanvasActive = false;
                    playerInventory.holdingObject = true;
                    pedestalEmpty = true;
                    prismOnPedestal = false;

                }

                  if (pipeOnPedestal == true)
                {
                    m_pipeActive.pipeActive = true;
                    pipeItem.SetActive(false);
                    pipePerson.SetActive(true);
                    pickup_Canvas.SetActive(false);
                    pickupCanvasActive = false;
                    playerInventory.holdingObject = true;
                    pedestalEmpty = true;
                    pipeOnPedestal = false;

                }
               
                 if (torusOnPedestal == true)
                {

                    m_torusActive.torusActive = true;
                    torusItem.SetActive(false);
                    torusPerson.SetActive(true);
                    pickup_Canvas.SetActive(false);
                    pickupCanvasActive = false;
                    playerInventory.holdingObject = true;
                    pedestalEmpty = true;
                    torusOnPedestal = false;

                }
            }
        }
    }

    void StartPedestals()
    {
        if (pedestal.tag == "Prism Pedestal")
        {
            prismItem.SetActive(true);
            pipeItem.SetActive(false);
            torusItem.SetActive(false);
            pedestalEmpty = false;
            prismOnPedestal = true;
        }
       
        
        if (pedestal.tag == "Pipe Pedestal")
            {
                prismItem.SetActive(false);
                pipeItem.SetActive(true);
                torusItem.SetActive(false);
                pedestalEmpty = false;
                pipeOnPedestal = true;
            }
            
            
        if (pedestal.tag == "Torus Pedestal")
            {       
                prismItem.SetActive(false);
                pipeItem.SetActive(false);
                torusItem.SetActive(true);
                pedestalEmpty = false;
                torusOnPedestal = true;
            }
                
                
        if (pedestal.tag == "Pedestal")
        {
                prismItem.SetActive(false);
                pipeItem.SetActive(false);
                torusItem.SetActive(false);
                pedestalEmpty = true;
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
           
            if(pedestalEmpty == false && playerInventory.holdingObject == false)
            {
                pickupCanvasActive = true;
                pickup_Canvas.SetActive(true);
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
               
            drop_Canvas.SetActive(false);
            dropCanvasActive = false;
            pickup_Canvas.SetActive(false);
            pickupCanvasActive = false;
        
        }
    }
}
