using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject spherePrefab;  // the 3d sphere prefab to spawn
    [SerializeField] private float spawnDistance = 10f; // how far in front of the camera the sphere will spawn

    void Update()
    {
        //Check if the spacebar was pressed this frame and use the method to spawn the sphere in random area
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SpawnRandomSphere();
        }
    }

    //spawn a sphere at a random on screen location
    public void SpawnRandomSphere()
    {
        // stop if the prefab or main camera is missing to prevent error
        if(spherePrefab == null || Camera.main == null) return;

        // generate a randomX and randomY screen coordinates (0.1, and 0.9 to keep the sphere away from the edge)

        float randomX = Random.Range(0.1f, 0.9f);
        float randomY = Random.Range(0.1f, 0.9f);

        // convert the 2d screen coordinates into a 3d world position in front of the camera

        Vector3 spawnPos = Camera.main.ViewportToWorldPoint(new Vector3(randomX, randomY, spawnDistance));
        
        // create the sphere prefab at the location with default rotation
        Instantiate(spherePrefab, spawnPos, Quaternion.identity);

        
    }




}
