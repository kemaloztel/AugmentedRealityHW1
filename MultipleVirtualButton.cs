using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultipleVirtualButton : MonoBehaviour
{
    public GameObject gtuGo, havelsanGo, trabzonGo;

    VirtualButtonBehaviour[] vrb;
    void Start()
    {
        gtuGo.SetActive(false);
        havelsanGo.SetActive(false);
        trabzonGo.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for(int i=0; i<vrb.Length; i++){
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);
        }
    }

    public void onButtonPressed(VirtualButtonBehaviour vb){
        if(vb.VirtualButtonName == "YuksekLisansVirtualButton"){
            gtuGo.SetActive(true);
            havelsanGo.SetActive(false);
            trabzonGo.SetActive(false);
        }
        else if(vb.VirtualButtonName == "IsHayatiVirtualButton"){
            gtuGo.SetActive(false);
            havelsanGo.SetActive(true);
            trabzonGo.SetActive(false);
        }
        else if(vb.VirtualButtonName == "HobilerVirtualButton"){
            gtuGo.SetActive(false);
            havelsanGo.SetActive(false);
            trabzonGo.SetActive(true);
        }else{
            throw new UnityException(vb.VirtualButtonName + "Virtual button not supported");
        }
    }

    public void onButtonReleased(VirtualButtonBehaviour vb){
        Debug.Log("Button Released");
    }

}
