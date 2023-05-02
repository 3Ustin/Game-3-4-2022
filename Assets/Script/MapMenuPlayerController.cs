using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public class MapMenuPlayerController : MonoBehaviour {
//*************************************************************************************************************
    public string currentLocation = "";  //String for current location of character
    public string[] locations;           //String for all locations to check through
    void Update() {
        if(Input.GetKeyDown("space")){                               //Has the Space Bar been Pressed?
            SceneManager.LoadScene("3D Map", LoadSceneMode.Single);  //Scene based on Location.
        }
    }
//*************************************************************************************************************
}
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------