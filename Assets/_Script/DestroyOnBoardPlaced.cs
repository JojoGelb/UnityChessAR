using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBoardPlaced : MonoBehaviour
{
    public void OnDestroyObject()
    {
        Destroy(gameObject);
    }
}
