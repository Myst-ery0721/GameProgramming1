using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int hp;
    public int str;
    // Start is called before the first frame update

    public MeshRenderer playerMesh;
    public Color playerColor;
    void Start()
    {
        playerMesh.material.color = playerColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
