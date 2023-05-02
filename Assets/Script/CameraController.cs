using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    //This Class is to be attached to a Camera Game Object. Thanks.
//***************************************************************
//Variables for Controlling the Player Character
    [SerializeField]public Camera[] cameras;
    private int currentCamera = 0;
    //public Camera mainCamera;
//***************************************************************
    void Start() {
        //Initializes variables and runs method before first update.
//************************************************************************************************************************************
        for(int i = 0; i!=cameras.Length;i++){
            cameras[i].enabled = false;
        }
        cameras[currentCamera].enabled = true;
//************************************************************************************************************************************
    }

    void Update() {
        //Method Responsible for Camera Movement. Should be moved to it's own class.
//***********************************************************************************************************************************************
    if (Input.GetKeyDown(KeyCode.C)) {
        currentCamera+=1;
        if(currentCamera==cameras.Length){
            currentCamera=0;
        }
        for(int i = 0; i!=cameras.Length;i++){
            cameras[i].enabled = false;
        }
        cameras[currentCamera].enabled = true;
    }
//************************************************************************************************************************************************
    }
}
