using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] private Transform target;
    private Vector3 offSet;
    private float smoothSpeed = 5;

    [SerializeField] private Vector2 minBounds;
    [SerializeField] private Vector2 maxBounds;


    public void Start()
    {
        offSet = transform.position - target.position;
    }

    private void LateUpdate()
    {
        Vector3 desirePosition = target.position + offSet;
        desirePosition.z = transform.position.z;

        desirePosition.x= Mathf.Clamp(desirePosition.x, minBounds.x, maxBounds.x);
        desirePosition.y = Mathf.Clamp(desirePosition.y, minBounds.y, maxBounds.y);

        transform.position = Vector3.Lerp(transform.position, desirePosition, Time.deltaTime * smoothSpeed);
    }
}
