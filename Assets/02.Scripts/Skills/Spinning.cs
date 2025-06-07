using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
public class Spinning : IntervalSkill                                                      
{

    private void Awake()
    {
        SkillType = Define.ESKILLTYPE.Spinning;
    }

    public override void ActivateSkill(Action OnComplete)
    {
        base.ActivateSkill();
        StartCoroutine(SpinAttackRoutine(OnComplete));
    }

    private IEnumerator SpinAttackRoutine(Action onComplete)
    {
        float elapsed = 0f;
        float timer = 0f;

        //HashSet���� Target �־ TriggerEnter�� ��ó�� �Ͽ� ����ȭ ���� �����.
        while (elapsed < SkillData.Duration)
        {
            elapsed += Time.deltaTime;
            timer += Time.deltaTime;

            // Ÿ��
            if (timer >= SkillData.AttackInterval)
            {
                timer = 0f;
                Collider[] hits = Physics.OverlapSphere(transform.position, SkillData.RecognitionRange);
                foreach (var hit in hits)
                {
                    hit.GetComponent<Health>()?.DealDamage(Owner, Owner.CreatureData.Atk);
                }
            }

            yield return null;
        }
        onComplete?.Invoke();
    }


    protected override void DoSkillJob()
    {

    }



}

