using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    protected float movementSpeed;

    [SerializeField]
    protected Rigidbody2D rigidBody;
}
