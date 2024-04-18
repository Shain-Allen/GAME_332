using System.Collections.Generic;
using UnityEngine;

public enum Keys
{   
    L,
    T,
    Z
}

public class KeyManager : MonoBehaviour
{
    public List<Keys> foundKeys = new List<Keys>(); //List of Keys>

    [SerializeField]
    private Camera mainCamera;
    [SerializeField] private float maxDistance;
    public string imLookingAt;


    // Start is called before the first frame update
    void Start()
    {
        foundKeys.Clear();
        mainCamera = Camera.main;
    }

    void Update()
    {
        int x = Screen.width / 2; //Center along X
        int y = Screen.height / 2; //Center along Y
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(x, y)); //Raycast from center of the camera

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance)) //If the raycast sees something within the max distance 
        {
            imLookingAt = hit.collider.tag; //Set imLookingAt to the tag of the visible object
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("L"))
        {
            foundKeys.Add(Keys.L); //Add L to the list of found keys
            Destroy(other.gameObject); //Destroy the game object 
        }
        else if (other.gameObject.CompareTag("T"))
        {
            foundKeys.Add(Keys.T); //Add T to the list of found keys
            Destroy(other.gameObject); //Destroy the game object 
        }
        else if (other.gameObject.CompareTag("Z"))
        {
            foundKeys.Add(Keys.Z); //Add Z to the list of found keys
            Destroy(other.gameObject); //Destroy the game object 
        }
    }




}
