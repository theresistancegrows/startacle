using UnityEngine;

public class ground : MonoBehaviour
{
    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;

    void Start()
    {
        for (int i = 0; i < 15; i++) {
            spawnTile();
        }
    }

    public void spawnTile() {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

}
