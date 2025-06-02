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

public class SkillUsedEvent : BaseEvent
{
    public SkillBase skill;
    public int skillIdx;

    public SkillUsedEvent(SkillBase skill, int idx)
    {
        this.skill = skill;
        this.skillIdx = idx;
    }
}



// Enum, String�� class ���� ����  