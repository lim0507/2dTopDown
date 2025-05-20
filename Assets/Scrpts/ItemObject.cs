using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ItemSo data;

    public int GetPoint()
    {
        return data.point;
    }
}
