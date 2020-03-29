using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandom : MonoBehaviour
{
    public List<GameObject> LiGoSpawn = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject goToSpawn = LiGoSpawn[Random.Range(0, LiGoSpawn.Count)];
        Instantiate(goToSpawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}