using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsLocal { get; private set; }
    [SerializeField] private Transform camTransform;
    private void Move(Vector3 newPosition, Vector3 forward)
    {
        transform.position = newPosition;

        if (!IsLocal)
        {
            camTransform.forward = forward;
        }
    }
}
