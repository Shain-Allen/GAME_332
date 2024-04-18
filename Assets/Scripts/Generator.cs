using UnityEngine;

public class Generator : MonoBehaviour
{
    private MeshRenderer GeneratorKeyMesh;
    KeyManager FPSController;
    public Keys key;
    public string facingCheck;

    // Start is called before the first frame update
    void Start()
    {
        GeneratorKeyMesh = transform.Find("Generator_Key").GetComponent<MeshRenderer>(); //Find the keymesh of generator
        
        GeneratorKeyMesh.enabled = false; //Start with Generator_Key object invisible
        FPSController = FindFirstObjectByType<KeyManager>(); //Find the game object labeled "FPSController"
    }

    private void Update()
    {
        facingCheck = FPSController.imLookingAt; ; //Set facingCheck to imLookingAt from the KeyManager

        if (FPSController.foundKeys.Contains(key) && gameObject.CompareTag(facingCheck) && Input.GetKeyDown("e")) //If you have the key, facing the generator, and hit "e" on the keyboard
        {
            GeneratorKeyMesh.enabled = true; //Enable the visibility for "L"
        }
    }

}
