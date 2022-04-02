using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DiceObservable : IObservable<int>
{
    private List<IObserver<int>> _observers;

    private int _value;

    public DiceObservable()
    {
        _observers = new List<IObserver<int>>();
    }

    public void Add(int deltaValue)
    {
        _value += deltaValue;
        foreach (IObserver<int> obs in _observers)
        {
            obs.OnNext(_value);
        }
    }

    public void Set(int deltaValue)
    {
        _value = deltaValue;
        foreach (IObserver<int> obs in _observers)
        {
            obs.OnNext(_value);
        }
    }


    public IDisposable Subscribe(IObserver<int> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
        return null;
    }
}
