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
        InvokeRepeating("SpawnIce", 0, 1);
    }

    void SpawnIce()
    {
        int randomC = Random.Range(0, icePrefabs.Count);
        Instantiate( icePrefabs[randomC],SpawnP[randomC].transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
