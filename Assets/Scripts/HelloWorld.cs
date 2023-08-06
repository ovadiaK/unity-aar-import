using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI textObj;
    void Start()
    {
        textObj = gameObject.GetComponent<TextMeshProUGUI>();

        
        textObj.text = CaptiveReality.Jni.Util.StaticCall("sayHello",
            "Invalid Response From JNI", "com.example.plug_in_tester.HelloWorld");
    }
    
}
