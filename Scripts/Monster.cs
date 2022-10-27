using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, iCopyable
{
    public iCopyable Copy()
    {
        return Instantiate(this);
    }
}
