using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct StructA
{
    int m_Data;
    public StructA(int data)
    {
        m_Data = data;
    }
    //void SetData(int data)
    //{
    //    Data = data;
    //}
    //다음과 같이 세터겟터를 한꺼번에 만들거나, 한쪽만 사용가능.
    public int Data
    {
        //필요없는 것이 있다면 만들지 않거나 주석하면 됨.
        get { return m_Data; }
        set { m_Data = value; }
    }
}
public class ClassA
{
    int m_Data;
    public ClassA(int data)
    {
        m_Data = data;
    }
    public int Data
    {
        get { return m_Data; }
        set { m_Data = value; }
    }
}
