using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerInput input;

    [SerializeField] private GameObject cam;




    void Awake()
    {
        input = new PlayerInput();
        

    }

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += new Vector3(input.Direction.x * cam.transform.forward.x, 0.0f, input.Direction.y * cam.transform.forward.z) * Time.deltaTime * 5.0f;
        
    }
}
