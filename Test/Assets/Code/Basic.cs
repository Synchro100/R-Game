using System.Collections;
using System.Collections.Generic;
using UnityEngine;//유니티에서 라이브러리를 가져

public class Basic : MonoBehaviour
    //유니티에 스크립트를 작성할때 가장 기본적인 상속 클래스
{
    StructA m_struct;
    ClassA m_class;
    // Use this for initialization
    void Start () {
        //모노비헤이어로 부터 상속받은 멤버들.
        //컴포넌트나 게임오브젝트 정보를 가지고있다.
        this.transform.position = new Vector3(0, 0, 0);

        m_struct = new StructA(200);
        //m_struct.Data = 10;
        Debug.Log("StructData : " + m_struct.Data);

        m_class = new ClassA(100);
        //m_class.Data = 20;
        Debug.Log("ClassData : " + m_class.Data);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
