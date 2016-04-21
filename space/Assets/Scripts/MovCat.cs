using UnityEngine;
using FMOD.Studio;
using System.Collections;

public class MovCat : MonoBehaviour
{

    [FMODUnity.EventRef]
    public string inputSound = "event:/Nave";
    FMOD.Studio.EventInstance inputSoundEv;
    FMOD.Studio.ParameterInstance inputSoundParam;

    public float step =100f; 

    public float current_speed = 200f; 
    public float maxSpeed=300f;


    public float instrmento;




    // Use this for initialization
    void Start()
    {


        inputSoundEv = FMODUnity.RuntimeManager.CreateInstance(inputSound);
        inputSoundEv.getParameter("speed", out inputSoundParam);
        inputSoundEv.start();


    }

    // Update is called once per frame
    void Update()
    {

          instrumento();
          inputSoundParam.setValue(current_speed*6);


    }

    void instrumento()
    {
        if (Input.GetKeyDown("up"))
        {
            if (current_speed < maxSpeed)
            {
                current_speed = current_speed + step;
            }
            else {

                current_speed = current_speed-step;
            }
         
        }
        if (Input.GetKeyDown("down"))
        {
            if (current_speed > 0)
            {
                current_speed = current_speed - step;
            }
            else {

                current_speed = current_speed + step;
            }
        }

    }



}


