using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Monster m_Ghost;
    public Monster m_Killer;
    public Monster m_Witch;
    public Monster m_Scarecrow;
    public Monster m_Mushroom;
    public MonsterSpawner m_Spawner;
    public int MonstersSpawned = 0;
    public int GhSpawn = 0;
    public int KiSpawn = 0;
    public int WiSpawn = 0;
    public int MuSpawn = 0;
    public int ScSpawn = 0;

    private Monster m_Spawn;
    private int m_IncrementorGhost = 0;
    private int m_IncrementorKiller = 0;
    private int m_IncrementorWitch = 0;
    private int m_IncrementorMushroom = 0;
    private int m_IncrementorScarecrow = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            m_Spawn = m_Spawner.SpawnMonster(m_Ghost);

            m_Spawn.name = "ghost_clone_" + ++m_IncrementorGhost;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorGhost * 2f);
            MonstersSpawned++;
            GhSpawn++;

        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            m_Spawn = m_Spawner.SpawnMonster(m_Killer);

            m_Spawn.name = "killer_clone_" + ++m_IncrementorKiller;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorKiller * 2f);
            MonstersSpawned++;
            KiSpawn++;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_Spawn = m_Spawner.SpawnMonster(m_Witch);

            m_Spawn.name = "witch_clone_" + ++m_IncrementorWitch;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorWitch * 2f);
            MonstersSpawned++;
            WiSpawn++;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            m_Spawn = m_Spawner.SpawnMonster(m_Mushroom);

            m_Spawn.name = "mush_clone_" + ++m_IncrementorMushroom;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorMushroom * 2f);
            MonstersSpawned++;
            MuSpawn++;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnMonster(m_Scarecrow);

            m_Spawn.name = "scarecrow_clone_" + ++m_IncrementorScarecrow;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorScarecrow * 2f);
            MonstersSpawned++;
            ScSpawn++;
        }
    }

}
