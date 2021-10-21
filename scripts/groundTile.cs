using UnityEngine;

public class groundTile : MonoBehaviour
{
    ground thisGround;
    public GameObject obstacle01;
    public GameObject obstacle02;
    public GameObject obstacle04;
    public GameObject jellyFish01;
    public GameObject jellyFish02;
    public GameObject jellyFish03;
    public GameObject starFish01;
    public GameObject starFish02;
    public GameObject starFish03;
    public GameObject starFish04;
    public float turnSpeed = 90f;

    void Start()
    {
        thisGround = GameObject.FindObjectOfType<ground>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other) {
        thisGround.spawnTile();
        Destroy(gameObject, 2);
    }

    void SpawnObstacle() {
        int obstacleSpawnIndex = Random.Range(2,6);
        if (obstacleSpawnIndex == 2) {
            obstacle01.SetActive(true);
            obstacle02.SetActive(true);
        }
        else if (obstacleSpawnIndex == 3) {
            obstacle04.SetActive(true);
        }
        else if (obstacleSpawnIndex == 4) {
            obstacle01.SetActive(true);
        }
        else if (obstacleSpawnIndex == 5) {
            obstacle02.SetActive(true);
            obstacle04.SetActive(true);
        }

        int jellyFishIndex = Random.Range(1,6);
        if (jellyFishIndex == 1) {
            jellyFish01.SetActive(true);
            jellyFish01.transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        else if (jellyFishIndex == 2) {
            jellyFish02.SetActive(true);
            jellyFish02.transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        else if (jellyFishIndex == 3) {
            jellyFish03.SetActive(true);
            jellyFish03.transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        int starFishIndex = Random.Range(1,6);
        if (starFishIndex == 1) {
            starFish01.SetActive(true);
            starFish01.transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        else if (starFishIndex == 2) {
            starFish02.SetActive(true);
            starFish02.transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        else if (starFishIndex == 3) {
            starFish03.SetActive(true);
            starFish03.transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        else {
            starFish04.SetActive(true);
            starFish04.transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }

    }
}
