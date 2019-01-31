using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string _PrintText;
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
}
