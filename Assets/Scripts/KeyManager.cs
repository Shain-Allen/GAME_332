using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public bool L_Key;

    [SerializeField]
    private GameObject mainCamera;
    private float maxDistance;
    public string imLookingAt;


    // Start is called before the first frame update
    void Start()
    {
        L_Key = false; //Start with the "L" shape hidden
    }

    void Update()
    {
        int x = Screen.width / 2; //Center along X
        int y = Screen.height / 2; //Center along Y
        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y)); //Raycast from center of the camera
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance)) //If the raycast sees something within the max distance 
        {
            imLookingAt = hit.collider.tag; //Set imLookingAt to the tag of the visible object
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "L")
        {
            L_Key = true; //Set L_Key to true
            Destroy(other.gameObject); //Destroy the game object 
        }
    }




}
