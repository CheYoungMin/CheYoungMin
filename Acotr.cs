
using System.Diagnostics;

public class Actor
{
    //private:외부 클래스에 비공개로 성절하는 접근자 *모든 변수, 함수 등의 앞에 생략되어있다.
    //public:외부 클래스에 공개로 성절하는 접근자
    public int id;
    public string name;
    public string title;

    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다";
    }

    public string Hasweapon()
    {
        return weapon;
    }

    public void LeveUp()
    {
        level = level + 1;

    }
}
