using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowPlayer : MonoBehaviour
{
    ////public float Heightx;
    ////public float Heighty;
    ////public float Heightz;
    public static Transform playerPos;
    public Vector3 offect;
    private Quaternion rotate; //�S��
    private Vector3 cameraVelocity = Vector3.one;
    public float smoothTime = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.rotation *= rotate;
        //���ե���rotate

        //gameObject.transform.position = new Vector3(playerPos.position.x + offect.x , playerPos.position.y + offect.y, playerPos.position.z + offect.z);
        //�ץ��᪺�쪩

        //gameObject.transform.position = Vector3.SmoothDamp(transform.position, playerPos.position + new Vector3(0,0,0),ref cameraVelocity , smoothTime );
        //SmoothDamp(�ۤv��pos,�ؼЪ�pos,�S�����·ӧ�,�ưʪ��ɶ�)

        gameObject.transform.position = Vector3.SmoothDamp(transform.position, playerPos.position + new Vector3(offect.x, offect.y, offect.z), ref cameraVelocity, smoothTime);
    }
}
