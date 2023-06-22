using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Template : MonoBehaviour {
    public KMBombInfo Bomb;
    public KMAudio Audio;
    static int ModuleIdCounter = 1;
    int ModuleId;

    private void Awake()
    {
        ModuleId = ModuleIdCounter++;
        
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
