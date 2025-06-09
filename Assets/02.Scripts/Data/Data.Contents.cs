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
        public float Atk;
        public float AtkBonus;
        public float MoveSpeed;
        public float TotalExp;
        public float HpRate;
        public float AtkRate;
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
        public string AnimName;
        public string PrefabLabel; //������ ���
        public string IconLabel;//������ ���
        public string SoundLabel;// �ߵ����� ���
        public string Category;//��ų ī�װ�
        public float CoolTime; // ��Ÿ��
        public float ProjectileSpacing;// �߻�ü ���� ����
        public float Duration; //��ų ���ӽð�
        public float RecognitionRange;//�νĹ���
        public string CastingSound; // ��������
        public float AngleBetweenProj;// �߻�ü ���� ����
        public float AttackInterval; //���ݰ���
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
        public bool IsMove;         //�����̸鼭 ������ ����
        public float moveSpeed;
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


    #region StageData

    [Serializable]
    public class StageData
    {
        public int StageIndex = 1;
        public string StageName;
        public int StageLevel = 1;
        public string MapName;
        //public int StageSkill;

        
    }
    public class StageDataLoader : ILoader<int, StageData>
    {
        public List<StageData> stages = new List<StageData>();

        public Dictionary<int, StageData> MakeDict()
        {
            Dictionary<int, StageData> dict = new Dictionary<int, StageData>();
            foreach (StageData stage in stages)
                dict.Add(stage.StageIndex, stage);
            return dict;
        }
    }

    #endregion
}