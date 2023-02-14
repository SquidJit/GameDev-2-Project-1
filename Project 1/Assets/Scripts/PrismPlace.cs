using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class PrismPlace : MonoBehaviour
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
        if (prism.prismOnPedestal == true)
        {
            correctObject.Play();
        }
        else
        {
            correctObject.Stop();
        }

        if (prism.pipeOnPedestal == true | prism.torusOnPedestal == true)
        {
            incorrectObject.Play();
        }
        else
        {
            incorrectObject.Stop();
        }
    }
}
