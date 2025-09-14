using System;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour {
    public Transform player;
    public GameObject roadPrefab;
    private int generateOn;
    
    public List<GameObject> roads = new List<GameObject>();

    private void Start()
    {
        generateOn = 150;
    }

    private void Update()
    {
        if (player.position.z > generateOn)
        {
            roads.Add(Instantiate(roadPrefab, new Vector3(0,0,generateOn+300), Quaternion.Euler(0,90,0)));
            generateOn += 150;
        }
    }
}
