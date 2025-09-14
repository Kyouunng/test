using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Coin : MonoBehaviour {
    
    public List<Item> items = new List<Item>();
    private void Start()
    {
        items.Add(new HealthItem());
        items.Add(new SpeedItem());

        items[0].MyFunc();
        transform.DOLocalMoveY(0.5f, 2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutCubic);
        transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}


public class Item {
    protected int num;

    public virtual void MyFunc()
    {
        
    }
}

public class HealthItem : Item {
    
    public void MyFunc()
    {
        
    }
}

public class SpeedItem : Item {
    public void MyFunc()
    {
        
    }
}

