using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera2D : MonoBehaviour
{
    public GameObject player;
    private Vector3 offSet = new Vector3(0, 0, -10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offSet;
    }
}
