using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public class CharacterController : MonoBehaviour {
    //This Class is meant to be attached to any 'Player Controlled' Game Object. Thanks.
//****************************************************************************************************************************************
//Variables for Controlling the Player Character
    [SerializeField]public GameObject character;  //Object that Represents the Player's Character
    [SerializeField]public GameObject selector;   //GameObject for determining player facing direction  FUTURE: For player aiming
    private float speed = .01f;                   //Player Character Scalor for continuous movement
    private bool isCharacterMoving = false;
    private Collider characterCollider;
//****************************************************************************************************************************************
    void Start() {
        //Initializes variables and runs method before first update.
//************************************************************************************************************************************
        characterCollider = GetComponent<CapsuleCollider>();

//************************************************************************************************************************************
    }
    void Update() {
        //This Method runs once per frame.
//*********************************************************************************************************************************************
    //Variables and Events related to Camera and Character
                                                                                                                                            ///
        if(Input.GetKeyDown("w"))                                                                  //W Key Pressed?
        {isCharacterMoving = true;}                                                                //When W gets pressed Move Character
        if(Input.GetKeyUp("w"))                                                                    //W Key Lifted?
        {isCharacterMoving = false;}                                                               //When W gets lifted Stop Character
        if(Input.GetKeyDown("s")){}                                                                //S Key Pressed?
        if(Input.GetKeyDown("d")){}                                                                //D Key Pressed?
        if(Input.GetKeyDown("a")){}                                                                //A Key Pressed?
                                                                                                                                            ///
        if(isCharacterMoving){moveCharacter("w");}
//*********************************************************************************************************************************************
    }
    private void moveCharacter(string keydown) {
        //This Method controls Movement After the Player presses the Forward Button.
//*******************************************************************************************************************
    //Calculations for Translations
        Vector3 heading = selector.transform.position - character.transform.position;     //Second Vector - First Vector
        heading.y = 0f;                                                                   //Prevent Vertical Movements
        float distance = Mathf.Abs(heading.magnitude);                                    //Distance for Normalization
        Vector3 direction = (heading/distance)*speed;                                     //Direction = Normalized Vector
    //Executing Translations
        Vector3 charRef = character.transform.position;           //Storing Character Position for Camera Controls
        character.transform.Translate(direction, Space.World);    //Space.World for non-local referenced Translations
        Vector3 charDif = character.transform.position - charRef; //Second Vector - First Ventor for Camera movements
        charDif.y = 0;                                            //Prevent Vector Math to create Vertical Movements
//*******************************************************************************************************************
    }
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
}
