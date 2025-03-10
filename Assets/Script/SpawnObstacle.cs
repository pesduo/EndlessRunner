using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] prefab;
    public Transform[] pos;

    void Start()
    {
        InvokeRepeating("SpawnObs",2f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObs()
    {
        int indexPrefab = Random.Range(0, prefab.Length);
        int posSpawn = Random.Range(0, pos.Length);
        Instantiate(prefab[indexPrefab], pos[posSpawn].position,transform.rotation);
    }
}
