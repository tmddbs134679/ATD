using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Todo: �ּ� �� �ޱ�.
public abstract class BaseEvent { }

/// <summary>
/// Player HP��, Text ó�� �̺�Ʈ
/// </summary>
public class PlayerDamagedEvent : BaseEvent
{
    public GameObject Player;
    public int NewHP;
    public int MaxHP;
}


// Enum, String�� class ���� ����  