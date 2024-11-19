using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnotherClass : MonoBehaviour
{
    public int Apples;
    public int Bananas;

    private int stapler;
    private int sellotape;    
    // Start is called before the first frame update
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    // Update is called once per frame
    void OfficeSort( int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office supplies totall: " + answer);
    }
}
