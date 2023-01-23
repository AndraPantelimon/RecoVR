using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Feedback
{
    [TextArea(1, 10)]
    public string[] feedback;
}
