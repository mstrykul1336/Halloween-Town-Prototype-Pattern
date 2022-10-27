using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public iCopyable m_Copy;

    public Monster SpawnMonster(Monster prototype)
    {
        m_Copy = prototype.Copy();
        return (Monster)m_Copy;
    }
}
