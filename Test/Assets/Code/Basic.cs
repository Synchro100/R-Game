using System.Collections;
using System.Collections.Generic;
using UnityEngine;//유니티에서 라이브러리를 가져

public class Basic : MonoBehaviour
//유니티에 스크립트를 작성할때 가장 기본적인 상속 클래스
{
    StructA m_struct;
    ClassA m_class;
    List<ClassA> m_listClassA;
    LinkedList<ClassA> m_linkedlistClassA;
    Dictionary<string, ClassA> m_dicClassA;

    // Use this for initialization
    void Start() {
        //모노비헤이어로 부터 상속받은 멤버들.
        //컴포넌트나 게임오브젝트 정보를 가지고있다.
        this.transform.position = new Vector3(0, 0, 0);

        m_struct = new StructA(200);//생성자 함수호출
        //m_struct.Data = 10;
        SetDataStruct(m_struct, 20);
        Debug.Log("StructData : " + m_struct.Data);

        m_class = new ClassA(100);//인스턴스 생성(동적할당)
        //생성된 인스턴스는 가비지컬렉션에 의해 관리되므로 해제할필요없다.
        //m_class.Data = 20;
        SetDataClass(m_class, 10);
        Debug.Log("ClassData : " + m_class.Data);
        string addPlus = "A" + "d" + "d";//1.더하기를 하여 문자열 생성
        string addFormat = string.Format("{0}{1}{2}", "A" + "d" + "d");
        //2.포맷함수를 이용하여 문자열 생성 : 문자열을
        Debug.Log(string.Format("{0}/{1}", addPlus, addFormat));
    }

    void SetDataStruct(StructA s, int data)
    {
        s.Data = data;
    }
    void SetDataClass(ClassA s, int data)
    {
        s.Data = data;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
