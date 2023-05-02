using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObject : MonoBehaviour {
    //This Class is to be attached to a Camera Game Object. Thanks.
//*****************************************************************************************************************
//Variables for Controlling the Player Character 
    private float rotationNumber;
    private float curRot = 0f;
    [SerializeField]public GameObject character;  //Object that Represents the Player's Character
    private float sensitivity = .2f;              //For Camera Movement speed scaling with mouse movement
    private Vector3 mouseReference;               //For storing mouse positional data inside of mouseReference
    private Vector3 cameraToCharacterConstantVector;
    private bool isCameraMoving = false;          
//*****************************************************************************************************************
    void Start() {
        //Initializes variables and runs method before first update.
//************************************************************************************************************************************
        cameraToCharacterConstantVector = transform.position - character.transform.position; //Sets Constant Distance from Character
//************************************************************************************************************************************
    }

    void Update() {
        //Method Responsible for Camera Movement. Should be moved to it's own class.
//***********************************************************************************************************************************************
        if(Input.GetMouseButtonDown(1)){isCameraMoving = true;mouseReference=Input.mousePosition;} //On right mouse press store mousePosition
        if(Input.GetMouseButtonUp(1)){isCameraMoving = false;rotationNumber=0f;}                   //Camera doesn't move if right mouse off
        if(isCameraMoving){moveCamera();}                                                          //Move Camera
        curRot += rotationNumber;
        transform.LookAt(character.transform.position);
        transform.position = (Quaternion.AngleAxis(curRot, Vector3.up)*(cameraToCharacterConstantVector)) + character.transform.position;
//************************************************************************************************************************************************
    }
    private void moveCamera(){
        //Method Responsible for Updating rotationNumber variable
//*********************************************************************************************************************
    //Gets Mouse off set from this frame and last. It then stores that as a rotation to be used later.
        Vector3 mouseOffset = (Input.mousePosition - mouseReference);                               // find offset
        rotationNumber = -(mouseOffset.x + mouseOffset.y) * sensitivity;                            // store offset
        mouseReference = Input.mousePosition;                                                       // update mouseRef
//*********************************************************************************************************************
    }
}
