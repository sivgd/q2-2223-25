using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayer : MonoBehaviour
{

    private Vector3 PlayerOrigin;
    public GameObject mainPlayer;
    // Start is called before the first frame update
    void Start()
    {
        PlayerOrigin = mainPlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
