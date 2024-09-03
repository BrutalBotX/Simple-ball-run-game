using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transf : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(player.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position+offset;
    }
}
