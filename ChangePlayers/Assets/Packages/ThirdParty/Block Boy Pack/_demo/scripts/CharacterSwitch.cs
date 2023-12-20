using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    [Header("Character Sets")]
    public GameObject characterSet1;
    public GameObject characterSet2;
    public GameObject characterSet3;
    public GameObject characterSet4;
    public GameObject characterSet5;
    public GameObject characterSet6;
    public GameObject characterSet7;
    public GameObject characterSet8;
    public GameObject characterSet9;
    public GameObject characterSet10;

    [Header("Button Panels")]
    public GameObject panelButtons1;
    public GameObject panelButtons2;
    public GameObject panelButtons3;
    public GameObject panelButtons4;
    public GameObject panelButtons5;
    public GameObject panelButtons6;
    public GameObject panelButtons7;
    public GameObject panelButtons8;
    public GameObject panelButtons9;
    public GameObject panelButtons10;

    public void SwitchCharacters_01()
    {
        characterSet1.SetActive(true);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(true);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_02()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(true);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(true);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_03()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(true);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(true);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_04()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(true);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(true);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_05()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(true);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(true);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_06()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(true);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(true);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_07()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(true);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(true);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_08()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(true);
        characterSet9.SetActive(false);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(true);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_09()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(true);
        characterSet10.SetActive(false);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(true);
        panelButtons10.SetActive(false);
    }

    public void SwitchCharacters_10()
    {
        characterSet1.SetActive(false);
        characterSet2.SetActive(false);
        characterSet3.SetActive(false);
        characterSet4.SetActive(false);
        characterSet5.SetActive(false);
        characterSet6.SetActive(false);
        characterSet7.SetActive(false);
        characterSet8.SetActive(false);
        characterSet9.SetActive(false);
        characterSet10.SetActive(true);

        panelButtons1.SetActive(false);
        panelButtons2.SetActive(false);
        panelButtons3.SetActive(false);
        panelButtons4.SetActive(false);
        panelButtons5.SetActive(false);
        panelButtons6.SetActive(false);
        panelButtons7.SetActive(false);
        panelButtons8.SetActive(false);
        panelButtons9.SetActive(false);
        panelButtons10.SetActive(true);
    }
}
