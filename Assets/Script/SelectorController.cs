using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorController : MonoBehaviour {
    [SerializeField]public GameObject character;  //Object that Represents the Player's Character
    private int layerMask;
    // Start is called before the first frame update
    void Start()
    {
        layerMask = (1 << 6);
    }
    // Update is called once per frame
    void Update()
    {
        positionSelector();
    }
    private void positionSelector() {
         //Matching Mouse Input to Selector Game Object Position
//*********************************************************************************************************************
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);     //Ray casting from Camera where mouse is on screen
        if(Physics.Raycast(ray, out RaycastHit raycastHit, layerMask)) {       //Did that ray cast hit anying? : Store in raycastHit
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);
            //if(raycastHit.collider.gameObject.layer == 6) {
                Vector3 first = raycastHit.point- character.transform.position;
                first.y = 0f;
                float distance = Mathf.Abs(first.magnitude);
                Vector3 heading = first/distance;
                if(distance > 4) {
                    Vector3 temp = character.transform.position + heading*4;
                    temp.y = .1f;
                    transform.position = temp;                //Selector Object Position become raycastHit
                    Quaternion rotation = Quaternion.LookRotation(     //Selector dictating player facing rotation
                    transform.position - character.transform.position, Vector3.up);     //Rotaion for player facing
                    character.transform.rotation = new Quaternion(0, rotation.y, 0, rotation.w); //New Character Rotation
                }
                else {
                    transform.position = raycastHit.point;     //Selector Object Position become raycastHit
                    Quaternion rotation = Quaternion.LookRotation(      //Selector dictating player facing rotation
                    transform.position - character.transform.position, Vector3.up);     //Rotaion for player facing
                    character.transform.rotation = new Quaternion(0, rotation.y, 0, rotation.w); //New Character Rotation
                                                                                                                        ///
                }
            ///}
        }
    }
//*********************************************************************************************************************
}
