using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float highPosX = 1.3f;
    private float lowPosY = -1.3f;

    private float holeSizeMin = 0.5f;
    private float holeSizeMax = 0.8f;

    [SerializeField] private Transform topObject;
    [SerializeField] private Transform bottomObject;

    private float widthpadding = 5f;

    MiniGame1Manager gameManager;

    private void Start()
    {
        gameManager = MiniGame1Manager.Instance;
    }
    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstacleCount)
    {
        float holeSize = Random.Range(holeSizeMin, holeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObject.localPosition = new Vector3(0, halfHoleSize);
        bottomObject.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placePosition = lastPosition + new Vector3(widthpadding, 0);
        placePosition.y = Random.Range(lowPosY,highPosX);

        transform.position = placePosition;

        return placePosition;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        MiniGamePlayerController player = other.GetComponent<MiniGamePlayerController>();
        if (player != null && player.isDead == false)
        {

            gameManager.AddScore(1);
            //ScoreManager.instance.AddScore(1);
        }
    }
}
