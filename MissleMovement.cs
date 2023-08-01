using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleMovement : MonoBehaviour
{
    public float moveSpeed = 30.0f;

    private void Awake()
    {
        DestroyObject(gameObject, 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * moveSpeed * Vector3.up);
    }
}
