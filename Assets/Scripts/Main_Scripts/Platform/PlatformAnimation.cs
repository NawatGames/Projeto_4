using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAnimation : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class ElementMap{
    public static int firePlatform = 0;
    public static int glassPlatform = 1;
    public static int groundPlatform = 2;
    public static int waterPlatform = 3;
    public static int windPlatform = 4;
}
