using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PrismCutscene : MonoBehaviour
{

    public PlayableDirector director;
    public OBJ_Drop prism;
    // Start is called before the first frame update
    void Start()
    {
        director= GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if(prism.prismOnPedestal == true)
        {
            director.Play();
        }
    }
}
