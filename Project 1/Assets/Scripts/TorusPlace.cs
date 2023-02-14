using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorusPlace : MonoBehaviour
{
    public ParticleSystem correctObject;
    public ParticleSystem incorrectObject;
    public OBJ_Drop prism;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (prism.torusOnPedestal == true)
        {
            correctObject.Play();
        }
        else
        {
            correctObject.Stop();
        }

        if (prism.pipeOnPedestal == true)
        {
            incorrectObject.Play();
        }
        else
        {
            incorrectObject.Stop();
        }

        if (prism.prismOnPedestal == true)
        {
            incorrectObject.Play();
        }
        else
        {
            incorrectObject.Stop();
        }
    }

       

}
