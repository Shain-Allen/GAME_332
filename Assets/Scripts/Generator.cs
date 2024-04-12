using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    GameObject L;
    GameObject FPSController;
    public bool haveKeyL;
    public string facingCheck;

    // Start is called before the first frame update
    void Start()
    {
        L = GameObject.Find("Generator_L_Key"); //Find the game object labeled "Generator_L_Key"
        L.GetComponent<MeshRenderer>().enabled = false; //Start with "L" object invisible
        FPSController = GameObject.Find("FPSController"); //Find the game object labeled "FPSController"
    }

    private void Update()
    {
        facingCheck = FPSController.GetComponent<KeyManager>().imLookingAt; ; //Set facingCheck to imLookingAt from the KeyManager
        haveKeyL = FPSController.GetComponent<KeyManager>().L_Key; //Set haveKeyL to L_Key from the KeyManager

        if (haveKeyL == true && facingCheck == "Generator_L" && Input.GetKeyDown("e")) //If you have the key, facing the generator, and hit "e" on the keyboard
        {
            L.GetComponent<MeshRenderer>().enabled = true; //Enable the visibility for "L"
        }
    }

}
