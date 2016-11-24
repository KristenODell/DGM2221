using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleBackgroundLevel : MonoBehaviour
{
    public List<BackgroundSendToRecycler> recycleList;
    private Vector3 movePos;

    void SendThisHandler(BackgroundSendToRecycler _r)
    {
        recycleList.Add(_r);
    }

    void Start()
    {
        recycleList = new List<BackgroundSendToRecycler>();
        BackgroundSendToRecycler.SendThis += SendThisHandler;
        movePos.z = 58;
        movePos.y = 0;
    }

    void OnTriggerEnter()
    {
        int i = UnityEngine.Random.Range(0, recycleList.Count - 1);
        movePos.x = Statics.backgroundNextPosition;
        recycleList[i].transform.position = movePos;
        recycleList.RemoveAt(i);
        Statics.backgroundNextPosition += Statics.backgroundDistance;
        movePos.z = 58;
        movePos.y = 0;
    }

}