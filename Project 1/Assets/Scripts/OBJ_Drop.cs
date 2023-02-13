using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJ_Drop : MonoBehaviour
{

    public GameObject drop_Canvas;
    public GameObject pickup_Canvas;

    public bool dropCanvasActive;
    public bool pedestalEmpty;

    // Start is called before the first frame update
    void Start()
    {
        drop_Canvas.SetActive(false);
        pickup_Canvas.SetActive(false);
        pedestalEmpty= true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (pedestalEmpty == true)
            {
                drop_Canvas.SetActive(true);
                dropCanvasActive = true;
            }
            else
            {
                pickup_Canvas.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if(pedestalEmpty ==true)
            {
                drop_Canvas.SetActive(false);
                
            }    
            else
            {
                pickup_Canvas.SetActive(false);
            }
            
        }
    }
}
