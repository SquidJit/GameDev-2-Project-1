using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePlace : MonoBehaviour
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
        if (prism.pipeOnPedestal == true)
        {
            correctObject.Play();
        }
        else
        {
            correctObject.Stop();
        }

        if (prism.prismOnPedestal == true | prism.torusOnPedestal == true)
        {
            incorrectObject.Play();
        }
        else
        {
            incorrectObject.Stop();
        }
    }
}
