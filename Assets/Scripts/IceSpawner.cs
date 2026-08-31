using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class IceSpawner : MonoBehaviour

    
{
    
     private List<GameObject> SpawnP;
     [SerializeField] private List<GameObject> icePrefabs;

    private void Awake()
    {
        SpawnP = new List<GameObject>();
        foreach (Transform child in transform)
        {
            SpawnP.Add(child.gameObject);
            
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnIce", 0, 0.5f);
        InvokeRepeating("SpawnOrca", 0, 2);
    }

    void SpawnIce()
    {
        
        Instantiate( icePrefabs[0],SpawnP[0].transform.position, Quaternion.identity);
        Instantiate( icePrefabs[0],SpawnP[1].transform.position, Quaternion.identity);
        Instantiate( icePrefabs[0],SpawnP[2].transform.position, Quaternion.identity);
        
    }
    
    void SpawnOrca()
    {
        
        
        Instantiate( icePrefabs[1],SpawnP[3].transform.position, Quaternion.identity);
        Instantiate( icePrefabs[1],SpawnP[4].transform.position, Quaternion.identity);
        
    }
    
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
