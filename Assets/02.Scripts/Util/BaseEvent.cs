using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Todo: �ּ� �� �ޱ�.
public abstract class BaseEvent { }

/// <summary>
/// ��������
/// </summary>

public class PlayerDamagedEvent : BaseEvent
{

    public int NewHP;
    public int MaxHP;
}


// Enum, String�� class ���� ����  