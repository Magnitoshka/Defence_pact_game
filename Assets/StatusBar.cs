using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBar : MonoBehaviour
{
    [SerializeField] Transform bar;

    public void SetState(int currnet,int max)
    {
        float state =(float) currnet;
        state /= max;

        if (state<0f)
        {
            state = 0f;
        }
        bar.transform.localScale = new Vector3(state,1f,1f);

    }
}
