using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate: Singleton<Delegate> {

    public delegate void noParam();
    public delegate void oneParamInt(int param);
}
