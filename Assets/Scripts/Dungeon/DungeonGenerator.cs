using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public GameObject[] roomPrefabs;
    public int dungeonLength = 10;

    Vector3 spawnPoint;

    void Start()
    {
        spawnPoint = Vector3.zero;

        for (int i = 0; i < dungeonLength; i++)
        {
            Instantiate(
                roomPrefabs[Random.Range(0, roomPrefabs.Length)],
                spawnPoint,
                Quaternion.identity
            );
            spawnPoint += Vector3.forward * 20f;
        }
    }
}
