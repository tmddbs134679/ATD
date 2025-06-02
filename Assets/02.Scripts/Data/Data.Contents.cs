using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;


namespace Data
{
    #region CreatureData
    [Serializable]
    public class CreatureData
    {
        public int DataId;
        public string DescriptionTextID;
        public string PrefabLabel;
        public float MaxHp;
        public float MaxHpBonus;
        public float Atk;
        public float AtkBonus;
        public float Def;
        public float MoveSpeed;
        public float TotalExp;
        public float HpRate;
        public float AtkRate;
        public float DefRate;
        public float MoveSpeedRate;
        public string IconLabel;
        public List<int> SkillTypeList;//InGameSkills�� ������ �߰���ų��
    }

    [Serializable]
    public class CreatureDataLoader : ILoader<int, CreatureData>
    {
        public List<CreatureData> creatures = new List<CreatureData>();
        public Dictionary<int, CreatureData> MakeDict()
        {
            Dictionary<int, CreatureData> dict = new Dictionary<int, CreatureData>();
            foreach (CreatureData creature in creatures)
                dict.Add(creature.DataId, creature);
            return dict;
        }
    }
    #endregion




    #region SkillData
    [Serializable]
    public class SkillData
    {
        public int DataId;
        public string Name;
        public string Description;
        public string PrefabLabel; //������ ���
        public string IconLabel;//������ ���
        public string SoundLabel;// �ߵ����� ���
        public string Category;//��ų ī�װ�
        public float CoolTime; // ��Ÿ��
        public float DamageMultiplier; //��ų������ (���ϱ�)
        public float ProjectileSpacing;// �߻�ü ���� ����
        public float Duration; //��ų ���ӽð�
        public float RecognitionRange;//�νĹ���
        public int NumProjectiles;// ȸ�� ����Ƚ��
        public string CastingSound; // ��������
        public float AngleBetweenProj;// �߻�ü ���� ����
        public float AttackInterval; //���ݰ���
        public int NumBounce;//�ٿ Ƚ��
        public float BounceSpeed;// �ٿ �ӵ�
        public float BounceDist;//�ٿ �Ÿ�
        public int NumPenerations; //���� Ƚ��
        public int CastingEffect; // ��ų �ߵ��� ȿ��
        public string HitSoundLabel; // ��Ʈ����
        public float ProbCastingEffect; // ��ų �ߵ� ȿ�� Ȯ��
        public int HitEffect;// ���߽� ����Ʈ
        public float ProbHitEffect; // ��ų �ߵ� ȿ�� Ȯ��
        public float ProjRange; //����ü ��Ÿ�
        public float MinCoverage; //�ּ� ȿ�� ���� ����
        public float MaxCoverage; // �ִ� ȿ�� ���� ����
        public float RoatateSpeed; // ȸ�� �ӵ�
        public float ProjSpeed; //�߻�ü �ӵ�
        public float ScaleMultiplier;
    }
    [Serializable]
    public class SkillDataLoader : ILoader<int, SkillData>
    {
        public List<SkillData> skills = new List<SkillData>();

        public Dictionary<int, SkillData> MakeDict()
        {
            Dictionary<int, SkillData> dict = new Dictionary<int, SkillData>();
            foreach (SkillData skill in skills)
                dict.Add(skill.DataId, skill);
            return dict;
        }
    }
    #endregion


}