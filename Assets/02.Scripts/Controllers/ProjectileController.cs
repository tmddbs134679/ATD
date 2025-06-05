using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : BaseController
{
    CreatureController _owner;
    public SkillBase Skill;
    Vector2 _spawnPos;
    Vector3 _dir = Vector3.zero;
    Vector3 _target = Vector3.zero;
    Rigidbody2D _rigid;

    Coroutine _coDotDamage;

    private void OnDisable()
    {
        StopAllCoroutines();
    }
    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        ObjectType = Define.EOBJECTTPYE.PROJECTILE;
        return true;
    }
    public void SetInfo(CreatureController owner, Vector2 position, Vector2 dir, Vector2 target, SkillBase skill)
    {
        _owner = owner;
        _spawnPos = position;
        _dir = dir;
        Skill = skill;
        _rigid = GetComponent<Rigidbody2D>();
        _target = target;
        transform.localScale = Vector3.one * Skill.SkillData.ScaleMultiplier;

        switch (skill.SkillType)
        {
            case Define.ESKILLTYPE.FIREBALL:
                StartCoroutine(CoFireBall(_spawnPos, _target, true));
                break;
            
        }

    }

    IEnumerator CoFireBall(Vector2 spawnPos, Vector3 target, bool isFollow = false)
    {
        float flightTime = 1.0f; // ����ü�� �����ϴ� �� �ɸ��� �ð�
        float gravity = Mathf.Abs(Physics.gravity.y);

        // ���� ��ġ�� Ÿ�� ��ġ ���� (�ణ ���� ���ø�)
        Vector3 start = spawnPos + Vector2.up * 1.0f;
        Vector3 end = target + Vector3.up * 1.0f;

        Vector3 displacement = end - start;
        Vector3 displacementXZ = new Vector3(displacement.x, 0, displacement.z);

        float horizontalDistance = displacementXZ.magnitude;
        float verticalDistance = displacement.y;

        // ���� �ӵ�
        float vx = horizontalDistance / flightTime;

        // ���� �ӵ� (vy) ���
        float vy = (verticalDistance + 0.5f * gravity * flightTime * flightTime) / flightTime;

        // ���� ���� (����)
        Vector3 directionXZ = displacementXZ.normalized;

        // ���� �ӵ� ����
        Vector3 velocity = directionXZ * vx;
        velocity.y = vy;

        //// ����ü ����
        //GameObject projectile = Instantiate(projectilePrefab, start, Quaternion.LookRotation(directionXZ));
        //Rigidbody rb = projectile.GetComponent<Rigidbody>();

        Rigidbody rb = GetComponent<Rigidbody>();
        // ����ü �ӵ� ����
        if (rb != null)
        {
            rb.velocity = velocity;
        }

        yield return null; // �ʿ��� ��� �߰� ���� ����
    }
}
