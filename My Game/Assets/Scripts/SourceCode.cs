using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceCode : MonoBehaviour
{
    public string url = "https://github.com/1shobo/Project_1";

    public void loadUrl()
    {
        Application.OpenURL(url);
    }
}
