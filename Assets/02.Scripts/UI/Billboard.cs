using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame

    private void LateUpdate()
    {
        if (mainCam == null) return;

        // ī�޶󿡼� �� ������Ʈ�� ���ϴ� ����
        Vector3 lookDir = mainCam.transform.position - transform.position;
        lookDir.y = 0f; // Y�� ����


        transform.rotation = Quaternion.LookRotation(-lookDir);


    }
}
