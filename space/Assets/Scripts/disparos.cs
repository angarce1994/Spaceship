using UnityEngine;
using FMOD.Studio;
using System.Collections;

public class disparos : MonoBehaviour {

    [FMODUnity.EventRef]
    public string inputSound = "event:/Nave";
    FMOD.Studio.EventInstance inputSoundEv;
    FMOD.Studio.ParameterInstance inputSoundParam;

    
    // Use this for initialization
    void Start () {

        inputSoundEv = FMODUnity.RuntimeManager.CreateInstance(inputSound);
        //inputSoundEv.getParameter("time", out inputSoundParam);
        
    }
	
	// Update is called once per frame
	void Update () {

            disparo();

    }

    void disparo()
    {
        if (Input.GetKeyDown("mouse 0"))
        {
            inputSoundEv.start();
        }
        }
}
