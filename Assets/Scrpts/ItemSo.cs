using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item", fileName = "NewItem")]
public class ItemSo : ScriptableObject
{
    [Header("Score Value")]
    public int point = 10;
}
