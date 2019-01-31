using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string _PrintText;
    public GameObject player;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintText()
    {
        Debug.Log(_PrintText);
    }

    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }

    public void SpawnCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<Rigidbody>();
        cube.transform.position = new Vector3(1, 10, -5);
    }

    public void SpawnLotsOfSpheres()
    {
        for(int i = 0; i < count; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.AddComponent<Rigidbody>();
            sphere.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z + i);
        }
    }
}
