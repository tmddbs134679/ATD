using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MonsterZone : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject monsterPrefab;
    [SerializeField] private GameObject wall; // ���� ���� ���ܿ�
    private int monsterCount = 0;
    private int killedCount = 0;
   // private StageManager stageManager;

    //public void Activate(StageManager mgr)
    //{
    //    stageManager = mgr;
    //    wall.SetActive(true); // �� �ݱ� (���� ��)
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        SpawnMonsters();
    }

    private void SpawnMonsters()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            var m = Instantiate(monsterPrefab, spawnPoints[i].transform.position, Quaternion.identity);
            m.GetComponent<EnemyStateMachine>().Health.OnDie += OnMonsterKilled;
            monsterCount++;
        }
    }

    private void OnMonsterKilled()
    {
        killedCount++;
        if (killedCount >= monsterCount)
        {
            wall.SetActive(false); // ���� ���� �̵� ����
            //stageManager.OnZoneCleared();
        }
    }


}
