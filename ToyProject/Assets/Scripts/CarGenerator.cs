using UnityEngine;

public class CarGenerator : MonoBehaviour
{
    public GameObject carPrefab;

    public GameObject coinPrefab;


    private void Start()
    {
        for (int i = 0; i < 20; i++)
            GenerateCar(new Vector3(Random.Range(5,20), 16, Random.Range(0, 150)), carPrefab);
        
        for (int i = 0; i < 30; i++)
            GenerateCoin(new Vector3(Random.Range(5,20), 16, Random.Range(0, 150)), coinPrefab);
    }

    void GenerateCar(Vector3 position, GameObject prefab)
    {
        Instantiate(prefab, position, Quaternion.Euler(-90,0,180));
    }
    void GenerateCoin (Vector3 position, GameObject prefab)
    {
        Instantiate(prefab, position, Quaternion.identity);
    }
}
