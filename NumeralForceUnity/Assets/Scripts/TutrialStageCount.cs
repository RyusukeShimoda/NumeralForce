using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;
using CriWare;

public class TutrialStageCount : MonoBehaviour
{
    public int count = 0;
    [SerializeField] GameObject camvas;
    [SerializeField] TextMeshProUGUI tx;
    [SerializeField] TextMeshProUGUI txFocus;
    [SerializeField] GameObject[] cover;

    [SerializeField] bool alphaMOn;
    [SerializeField] bool alphaOOn;
    [SerializeField] float alphaFloatM;
    [SerializeField] float alphaFloatO;
    [SerializeField] float alphaBlackM;
    [SerializeField] float alphaBlackO;
    [SerializeField] Renderer matM;
    [SerializeField] Renderer matO;
    [SerializeField] string mode;

    [SerializeField] CriAtomSource cas;

    // Start is called before the first frame update
    void Start()
    {
        if (mode == "tutrial")
        {
            alphaFloatM = matM.material.color.a;
            alphaFloatO = matO.material.color.a;
            alphaBlackO = 0.5f;
            alphaFloatO = 0;
            alphaOOn = true;
            SetAlpha();
        }
        else if (mode == "tutrial2"|| mode == "story2_3" || mode == "story5") 
        {
            alphaFloatM = matM.material.color.a;
            alphaFloatO = matO.material.color.a;
            alphaBlackM = 0.5f;
            SetAlpha();
            cover[0].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f);
            DOVirtual.DelayedCall(0.1f, () => cover[1].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.2f, () => cover[2].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.3f, () => cover[3].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.4f, () => cover[4].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.5f, () => cover[5].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.6f, () => cover[6].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.7f, () => cover[7].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.8f, () => cover[8].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.9f, () => cover[9].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
        }
        else if (mode == "story2")
        {
            alphaFloatM = matM.material.color.a;
            alphaFloatO = matO.material.color.a;
            alphaBlackO = 0.5f;
            SetAlpha();
        }
        else if (mode == "story2_2")
        {
            alphaFloatM = matM.material.color.a;
            alphaFloatO = matO.material.color.a;
            alphaBlackM = 0.5f;
            SetAlpha();
            cover[0].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f);
            DOVirtual.DelayedCall(0.1f, () => cover[1].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.2f, () => cover[2].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.3f, () => cover[3].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.4f, () => cover[4].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.5f, () => cover[5].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.6f, () => cover[6].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.7f, () => cover[7].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.8f, () => cover[8].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
            DOVirtual.DelayedCall(0.9f, () => cover[9].transform.DOLocalRotate(new Vector3(90, 0, 0), 0.5f));
        }
        else if (mode == "story3" || mode == "story4" || mode == "story4_2")
        {
            alphaFloatM = matM.material.color.a;
            alphaFloatO = matO.material.color.a;
            alphaBlackM = 0.5f;
            alphaFloatM = 0;
            alphaMOn = true;
            SetAlpha();
            cover[0].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f);
            DOVirtual.DelayedCall(0.1f, () => cover[1].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.2f, () => cover[2].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.3f, () => cover[3].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.4f, () => cover[4].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.5f, () => cover[5].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.6f, () => cover[6].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.7f, () => cover[7].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.8f, () => cover[8].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
            DOVirtual.DelayedCall(0.9f, () => cover[9].transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == "tutrial" || mode == "tutrial2"||mode=="story2" || mode == "story3" || mode == "story4") 
        {
            if (alphaMOn && alphaFloatM > 0)
            {
                alphaFloatM -= 0.03f;
                SetAlpha();
            }
            else if (alphaOOn && alphaFloatO > 0)
            {
                alphaFloatO -= 0.03f;
                SetAlpha();
            }
            else if (alphaMOn == false && alphaFloatM < 1)
            {
                alphaFloatM += 0.03f;
                SetAlpha();
            }
            else if (alphaOOn == false && alphaFloatO < 1)
            {
                alphaFloatO += 0.03f;
                SetAlpha();
            }
        }
    }

    void SetAlpha()
    {
        matM.material.color = new Color(alphaBlackM, alphaBlackM, alphaBlackM, alphaFloatM);
        matO.material.color = new Color(alphaBlackO, alphaBlackO, alphaBlackO, alphaFloatO);
    }

    public void CountUp() 
    {
        count += 1;
        CountChange();
    }

    public void CountDown()
    {
        if(mode == "tutrialStage") 
        {
            if (count != 0 && count != 11 && count != 18)
            {
                count -= 1;
                CountChange();
            }
        }
        else
        {
            if (count != 0)
            {
                count -= 1;
                CountChange();
            }
        }
    }

    void BGM(int cueNum)
    {
        cas.Play(cueNum);
    }

    void FocusM() 
    {
        txFocus.text = "�}�`���_";
        alphaBlackM = 1;
        alphaBlackO = 0.5f;
        SetAlpha();
    }
    void FocusO()
    {
        txFocus.text = "�I�X�J�[";
        alphaBlackM = 0.5f;
        alphaBlackO = 1;
        SetAlpha();
    }
    void FocusOther(string man)
    {
        txFocus.text = man;
        alphaBlackM = 0.5f;
        alphaBlackO = 0.5f;
        SetAlpha();
    }

    public void CountChange() 
    {

        #region TutrialStory
        if (mode == "tutrial") 
        {
            if (count == 0)
            {
                FocusM();
                alphaOOn = true;
                tx.text = "�c�c�B";
            }
            else if (count == 1)
            {
                FocusO();
                alphaOOn = false;
                tx.text = "�����l�ł��A�}�`���_��y�B���̓��挩�Ă��ł����H";
            }
            else if (count == 2)
            {
                FocusM();
                tx.text = "�ڋq�����̔̑�����̍ŐV�ł�B�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�����̎�̓T�[�r�X�u�j���[�������E�t�H�[�X�v�̂ˁB";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "�����A�������L����Ă�����ł��ˁB�l�ɂ������Ă��������B";
            }
            else if (count == 4)
            {
                FocusM();
                tx.text = "�͂��A�ǂ����B�c�c�����Ă������ǁA�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@��ɂ���ĕς��f���͂��Ȃ����H";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "�����m���x�����ŐV�K�J��ł���炵���ł�����ˁB�@�@�@�@�@�@�@�@���Ƒ��Ђ��ǐ��ł��Ȃ��ƕ����܂��B";
            }
            else if (count == 6)
            {
                FocusO();
                tx.text = "���āA����̂ق��́c�c�B";
            }
            else if (count == 7)
            {
                cover[0].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                DOVirtual.DelayedCall(0.1f, () => cover[1].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.2f, () => cover[2].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.3f, () => cover[3].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.4f, () => cover[4].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.5f, () => cover[5].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.6f, () => cover[6].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.7f, () => cover[7].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.8f, () => cover[8].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.9f, () => cover[9].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(1.5f, () => SceneManager.LoadScene(3));
            }
        }
        #endregion

        #region Tutrial2Story
        else if (mode == "tutrial2") 
        {
            if (count == 0)
            {
                FocusO();
                tx.text = "�܂��A�ʏ�^�]���Ċ����ł��ˁB";
            }
            else if (count == 1)
            {
                FocusM();
                tx.text = "�����ˁB";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "���������΁A�u�j���[�������E�t�H�[�X�v���č��̗�̏햱���@�@�@�@�J���v���W�F�N�g���哱���Ă��炵���ł��ˁB�@�@�@�@�@�@�@�@�@�@�@�����͂ǂ�Ȋ�����������ł����H";
            }
            else if (count == 3)
            {
                FocusM();
                alphaMOn = false;
                tx.text = "�����ˁA���ɂ͒m��R���Ȃ���B";
            }
            else if (count == 4)
            {
                FocusO();
                alphaMOn = true;
                tx.text = "���A�҂��c�c�ǂ��s����ł����[�H";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "�����[�[�c�c�H�H";
            }
            else if (count == 6)
            {
                for(int i = 0; i <= 9; i++) 
                {
                    cover[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                }
                DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(0));
            }
        }
        #endregion

        #region TutrialStage
        else if (mode == "tutrialStage") 
        {
            if (count == 0)
            {
                tx.text = "���̓x�́A�T�C�o�[�Z�L�����e�B�V�X�e���u�j���[�������E�t�H�[�X�v�̉^�p�������������A���ɂ��肪�Ƃ��������܂��B";
            }
            else if (count == 1)
            {
                tx.text = "�{�V�X�e���́A�s���A�N�Z�X�𐔎��ŉ������A�V���v���ȑ���ŃT�C�o�[�U���ւ́@�@�Ή����\�ɂ�����̂ł��B";
            }
            else if (count == 2)
            {
                cover[0].SetActive(true);
                tx.text = "����ł́A�u�j���[�������E�t�H�[�X�v�́@�g�p���@�������������Ē����܂��B";
            }
            else if (count == 3)
            {
                cover[0].SetActive(false);
                cover[1].SetActive(true);
                tx.text = "����́u���C�t�v�ł��B�@�@�@�@�@�@�@�@�@�����������A�㑤������̃��C�t�ƂȂ�܂��B";
            }
            else if (count == 4)
            {
                cover[0].SetActive(false);
                cover[1].SetActive(true);
                tx.text = "����̃��C�t��0�ɂ���Ώ����ł��B";
            }
            else if (count == 5)
            {
                cover[0].SetActive(true);
                cover[1].SetActive(false);
                tx.text = "��ʍ���ł́A�ǂ��瑤�̃^�[�������@�@�@�m�F�ł��܂��B";
            }
            else if (count == 6)
            {
                cover[1].SetActive(false);
                tx.text = "�����̃^�[�������邽�тɑ�����s���A�@�@�G�����j���܂��傤�B";
            }
            else if (count == 7)
            {
                cover[0].SetActive(true);
                cover[1].SetActive(true);
                tx.text = "�����̃^�[���ł́A�u�����v�Ɓu�i�R�v�́@�ǂ��炩���s���܂��B";
            }
            else if (count == 8)
            {
                cover[3].SetActive(true);
                tx.text = "�����A�܂��́u�����v���s���Ă݂܂��傤�B";
            }
            else if (count == 9)
            {
                cover[3].SetActive(false);
                tx.text = "�����{�^������C�ӂ̐�����I�сA�@�@�@�@�D���ȃ}�X�Ɂu�����v���Ă݂܂��傤�B�@�@(Next�{�^���������ĊJ�n)";
            }
            else if (count == 10)
            {
                camvas.SetActive(false);
            }
            else if (count == 11)
            {
                camvas.SetActive(true);
                cover[0].SetActive(true);
                cover[3].SetActive(true);
                cover[4].SetActive(false);
                tx.text = "�������������܂����B";
            }
            else if (count == 12)
            {
                cover[0].SetActive(false);
                cover[4].SetActive(false);
                tx.text = "�������傫���قǋ�͋��͂ɂȂ�܂����A�@�������������������C�t����������̂Ł@�@���ӂ��܂��傤�B";
            }
            else if (count == 13)
            {
                cover[0].SetActive(true);
                cover[4].SetActive(true);
                tx.text = "���́u�i�R�v�ɂ��Ăł��B";
            }
            else if (count == 14)
            {
                cover[4].SetActive(false);
                tx.text = "�������ꂽ�����̐������N���b�N����ƁA�@�u�i�R�v�ł���}�X������܂��B";
            }
            else if (count == 15)
            {
                cover[4].SetActive(true);
                tx.text = "�u�i�R�v�ł�������́A��E�E��E����́@3�����ł��B";
            }
            else if (count == 16)
            {
                cover[4].SetActive(true);
                tx.text = "���ۂɁu�i�R�v���s���Ă݂܂��傤�B�@�@�@(Next�{�^���������ĊJ�n)";
            }
            else if (count == 17)
            {
                camvas.SetActive(false);
            }
            else if (count == 18)
            {
                camvas.SetActive(true);
                tx.text = "�i�R���������܂����B";
            }
            else if (count == 19)
            {
                tx.text = "�i�R��ɓG������΁A�������������������A0�ɂȂ�Ə��ł��܂��B";
            }
            else if (count == 20)
            {
                tx.text = "�i�R��ɖ���������΁A���������v����@�@��̋�ƂȂ�܂��B";
            }
            else if (count == 21)
            {
                tx.text = "�ł͍Ō�ɁA����̃��C�t��0�ɂ��ā@�@�@�@�������܂��傤�B";
            }
            else if (count == 22)
            {
                tx.text = "�����̐������ł����̗�ɐi�R������ƁA�@����̃��C�t���|5����܂��B";
            }
            else if (count == 23)
            {
                tx.text = "���̎��g�p������̐����́A�@�@�@�@�@�@�@���C�t�ւ̃_���[�W�ʂɉe�����Ȃ����ƂɁ@�����Ӊ������B";
            }
            else if (count == 24)
            {
                tx.text = "����ł́A�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�ǂ��T�C�o�[�Z�L�����e�B�������I";
            }
            else if (count == 25)
            {
                tx.text = "(Next�{�^���������ā@�@�@�@�@�@�@�@�@�@�@�j���[�������E�t�H�[�X�̎��s���ĊJ)";
            }
            else if (count == 26)
            {
                camvas.SetActive(false);
            }
        }
        #endregion

        #region Story1
        else if (mode == "story1")
        {
            if (count == 0)
            {
                FocusO();
                tx.text = "����21xx�N�B";
            }
            else if (count == 1)
            {
                tx.text = "���ʐM�Z�p�͔���I�ɐi�����A�S�l�ނɂƂ��ăl�b�g���[�N�́@�@�@���퐶���ɐ[�����������̂ƂȂ��ċv�����B";
            }
            else if (count == 2)
            {
                tx.text = "��������ɔ����v���������Z�p�͍ו�������A�@�@�@�@�@�@�@�@�@���q��������ւ��ċZ�p�҂̕s���͐[���Ȃ��̂������B";
            }
            else if (count == 3)
            {
                tx.text = "�ǂ��ł����|����悤�ɁA�l�b�g�̃Z�L�����e�B��@�����̌��������T�C�o�[�ƍ߂������B";
            }
            else if (count == 4)
            {
                tx.text = "�C���^�[�l�b�g�Z�p�̒����͎��Ԃ̖�肾�����B";
            }
            else if (count == 5)
            {
                tx.text = "�������A�˔@�Ƃ��Ă����̋��Ђ͏I�����}����B";
            }
            else if (count == 6)
            {
                tx.text = "���R�́u�j���[�������E�t�H�[�X�v�̕��y�ł���B";
            }
            else if (count == 7)
            {
                tx.text = "�D�G�ȃT�C�o�[�U���̌��m�E�쏜�V�X�e���͂��Ƃ��A�@�@�@�@�@�@�@�蓮�ł́A���m����L�����Ƃ��T�C�o�[�U���ւ̊����\�B";
            }
            else if (count == 8)
            {
                tx.text = "�J�X�^�}�[�T�[�r�X�ɂ��o�b�N�A�b�v���[���B�@�@�@�@�@�@�@�@�@�@�������E�_��E���쐫�����˔�����㕨�ł������B";
            }
            else if (count == 9)
            {
                tx.text = "�����̃x���`���[��Ƃ����̃T�[�r�X�̒񋟂��n�߂�₢�Ȃ�A�@�@�@�����Ȃ��T�C�o�[�ƍ߂͋쒀����Ă������c�c";
            }
            else if (count == 10)
            {
                tx.text = "�͂��������B";
            }
            else if (count == 11)
            {
                for (int i = 0; i <= 9; i++)
                {
                    cover[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                }
                DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(0));
            }
        }
        #endregion

        #region Story2
        else if (mode == "story2")
        {
            if (count == 0)
            {
                FocusM();
                tx.text = "����΂�́A�I�X�J�[����B���p�ł����ɁH";
            }
            else if (count == 1)
            {
                FocusO();
                tx.text = "������������A�ڋq��Ƃ̎Г��V�X�e���́@�@�@�@�@�@�@�@�@�@�@�@�Ǝ㐫�̉������@�ɂ��đ��k���c�c";
            }
            else if (count == 2)
            {
                FocusM();
                tx.text = "�l���ɋZ�p�̑��k�Ȃ�ĉ΂�����ˁB";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "����͂����ł����c�c�}�`���_��y�͗�O�ł��B";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "���Ă̋Z�p���́u�B��̐��������v����Ȃ��ł����B";
            }
            else if (count == 5)
            {
                FocusM();
                tx.text = "���𔃂���肷����A���N�O�̘b���Ǝv���Ă���́H";
            }
            else if (count == 6)
            {
                FocusO();
                tx.text = "���ۂɋZ�ʂ����̋Z�p�E������c�c��H";
            }
            else if (count == 7)
            {
                FocusM();
                tx.text = "�ǂ����A�����艺�����B";
            }
            else if (count == 8)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "���炵�܂��B�I�X�J�[�ے��A�ً}�ł��B�ڋq��Ƃɕs���ȃA�N�Z�X���@���m����܂��āc�c";
            }
            else if (count == 9)
            {
                FocusO();
                tx.text = "�Ȃ񂾂��āH";
            }
            else if (count == 10)
            {
                FocusM();
                tx.text = "�c�c�ً}�炵�����A�s���Ă����Ȃ����B�ڋq����B";
            }
            else if (count == 11)
            {
                FocusO();
                alphaOOn = false;
                tx.text = "�\���󂲂����܂���A���炵�܂����B";
            }
            else if (count == 12)
            {
                FocusM();
                alphaOOn = true;
                tx.text = "�c�c�B";
            }
            else if (count == 13)
            {
                FocusM();
                tx.text = "�i�u�j���[�������E�t�H�[�X�v�ɂƂ��ā@�@�@�@�@�@�@�@�@�@�@�@�@�@�T�C�o�[�U���͋��Ђł͂Ȃ��Ȃ����B�j";
            }
            else if (count == 14)
            {
                FocusM();
                tx.text = "�i���ɔ����ȏ�̎��Ⴊ�A���Ђ����͂���܂ł��Ȃ��@�@�@�@�@�@�@�@�T�C�o�[�U���ւ̑Ώ����������Ă��邵�c�c�B�j";
            }
            else if (count == 15)
            {
                FocusM();
                tx.text = "�i���͂�T�C�o�[�U���̌��m�����̂��傫���ቺ����ꋭ��ԁB�j";
            }
            else if (count == 16)
            {
                FocusM();
                tx.text = "�i�킴�킴�ً}�ɌĂяo���قǂ̋K�͂̃T�C�o�[�U���H�@�@�@�@�@�@�@���̃^�C�~���O�ɁH�j";
            }
            else if (count == 17)
            {
                FocusM();
                tx.text = "�c�c�������������ˁB";
            }
            else if (count == 18)
            {
                for (int i = 0; i <= 9; i++)
                {
                    cover[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                }
                DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(9));
            }
        }
        #endregion

        #region Story2_2
        else if (mode == "story2_2")
        {
            if (count == 0)
            {
                FocusO();
                tx.text = "�󋵂́H";
            }
            else if (count == 1)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "�Z�~�Ђ���ً̋}�ʕ�ŁA�R�[���Z���^�[�̃I�y���[�^�[�Ƃ��A�g���ā@�Ή��ɓ������Ă��܂��B";
            }
            else if (count == 2)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "�����̖h�q�V�X�e���ŎJ���Ă͂��܂����A�Z���Ԃɑ�ʂ̃A�N�Z�X���@�@�W�����Ă��܂��B";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "���������B���͓��������I�ȍU���ɔ����ĎГ����牞����v������B�@�V�X�e���Ō��m�ł��Ȃ�����ȍU�����Ȃ����ǂ��������������@�@�@�@�Ď����Ă���B";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "�T�C�o�[�U���������̋t�T�m�ɐl�������������Ȃ��悤�ɁB�@�@�@�@�@�̐��ɗ]�͂��c���Ă��������������B";
            }
            else if (count == 5)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "�͂��I";
            }
            else if (count == 6)
            {
                cover[0].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                DOVirtual.DelayedCall(0.1f, () => cover[1].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.2f, () => cover[2].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.3f, () => cover[3].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.4f, () => cover[4].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.5f, () => cover[5].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.6f, () => cover[6].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.7f, () => cover[7].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.8f, () => cover[8].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.9f, () => cover[9].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(1.5f, () => SceneManager.LoadScene(10));
            }
        }
        #endregion

        #region Story2_3
        else if (mode == "story2_3")
        {
            if (count == 0)
            {
                FocusO();
                tx.text = "�U�����~�񂾂ȁc�c�B�v������蔏�q�������������B";
            }
            else if (count == 1)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "�͂��B�������ςł��ˁB";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "�ρc�c�Ă����̂͂ǂ������Ӗ��ŁH";
            }
            else if (count == 3)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "���Ȃ薳�Ӗ��ȍU���������������Ă����Ǝv���܂��B�@�@�@�@�@�@�@�@�T�C�o�[�ƍߎ��́A�j���[�������E�t�H�[�X�̑O�ł͂قږ��Ӗ��Ɓ@�@�����鎞��ł���H";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "�ǂ��������点���낤�B";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "���܂������ɂ͔�Q�͍쐬�ɕK�v�ȏ�񂪎茳�ɗ��Ă���͂����B�@�x�@�ɒ񋟂�������܂Ƃ߂Ă����悤�ɁB";
            }
            else if (count == 6)
            {
                for (int i = 0; i <= 9; i++)
                {
                    cover[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                }
                DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(0));
            }
        }
        #endregion

        #region Story3
        else if (mode == "story3")
        {
            if (count == 0)
            {
                alphaMOn = true;
                FocusO();
                tx.text = "��̂ǂ��Ȃ��Ă�񂾁c�c�H";
            }
            else if (count == 1)
            {
                alphaMOn = false;
                FocusM();
                tx.text = "���ɂȂ�������������Ă��ˁB";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "���͂悤�������܂��B����A������Ɩ�肪�c�c�B";
            }
            else if (count == 3)
            {
                FocusM();
                tx.text = "���c�c�B����̃T�C�o�[�U���͎��������͂���ˁH�@�@�@�@�@�@�@�@���̑O�A�h�o�C�X�����Г��V�X�e���̐Ǝ㐫�̌�������H";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "����A���̂�����̊�Ƃł��Ȃ��ʂ̊�Ƃł��B";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "�������Г��f�[�^�Ɏ��Q���󂯂��悤�Łc�c�B�@�@�@�@�@�@�@�@�@�@�@���Ȃ�܂������ƂɂȂ��Ă܂��c�c�I";
            }
            else if (count == 6)
            {
                FocusM();
                tx.text = "�N���o�H�́H";
            }
            else if (count == 7)
            {
                FocusO();
                tx.text = "���ꂪ������Ȃ���ł��A���Ղ��ЂƂc�炸������Ă�����ł���B�f�l�̎d�Ƃ��Ⴀ��܂���B";
            }
            else if (count == 8)
            {
                FocusO();
                tx.text = "�Ȃɂ��C������Ȃ̂́A�u�T�C�o�[�U�����󂯂��v�Ƃ����x������@�j���[�������E�t�H�[�X���o���Ȃ��������Ƃł��B";
            }
            else if (count == 9)
            {
                FocusM();
                tx.text = "�j���[�������E�t�H�[�X�̍X�V�v���O�����ɕs��́H";
            }

            else if (count == 10)
            {
                FocusO();
                tx.text = "���̂Ƃ���ُ�͌������Ă��܂���B";
            }
            else if (count == 11)
            {
                FocusO();
                tx.text = "�ł����x�@����A�u�j���[�������E�t�H�[�X�̃T�[�r�X���@�@�@�@�@�@�񋟂���Ă����ƂɃT�C�o�[�U�����W�����Ă���v�ƘA�����󂯂܂��āc�c�B";
            }

            else if (count == 12)
            {
                FocusO();
                tx.text = "�T�C�o�[�ƍߑ΍�ۂ��T�[�r�X�̔Еz���[�g�𐸍����Ă��܂����A�@�@�����瑤�ɗ����x������\���������ł��B";
            }
            else if (count == 13)
            {
                FocusM();
                tx.text = "�����c�c�B�c�c���߂�Ȃ����A���Ԏ�点����ˁB";
            }
            else if (count == 14)
            {
                alphaOOn = false;
                FocusO();
                tx.text = "���������B���݂����d������΂�܂��傤�I";
            }
            else if (count == 15)
            {
                alphaOOn = true;
                FocusM();
                tx.text = "�c�c�B";
            }
            else if (count == 16)
            {
                for (int i = 0; i <= 9; i++)
                {
                    cover[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                }
                DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(0));
            }
        }
        #endregion

        #region Story4
        else if (mode == "story4")
        {
            if (count == 0)
            {
                alphaMOn = true;
                FocusO();
                tx.text = "�����������Ȃ��c�c�B�ǂ�����΁c�c�B";
            }
            else if (count == 1)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "�ے��A�c�ƕ�����̃N���[���͂ǂ����܂����H";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "�����c�c���������A�Ή�����B";
            }
            else if (count == 3)
            {
                alphaMOn = false;
                FocusM();
                tx.text = "�l�����炿����ƕ�����������Ǝv���ė����̂�����ǁA�@�@�@�@�@�@�����ȑ����ˁB";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "�}�`���_��y�c�c�I";
            }
            else if (count == 5)
            {
                FocusM();
                tx.text = "�ΑӊǗ������Ă��ċ�������B";
            }
            else if (count == 6)
            {
                FocusM();
                tx.text = "�����ԘJ���Ɛ��ʂ͓��`�ł͂Ȃ��̂�H";
            }
            else if (count == 7)
            {
                FocusM();
                tx.text = "�l���̕⋭�����ă^�_����Ȃ��B�����炩��o���邱�Ƃɂ��@�@�@�@�@���肪�����B";
            }
            else if (count == 8)
            {
                FocusO();
                tx.text = "�����܂���B�l�̕s��ۂŁc�c�B";
            }
            else if (count == 9)
            {
                FocusOther("�Z�p�ێЈ�");
                tx.text = "�ے��A�j���[�������E�t�H�[�X����T�C�o�[�U���̌x�����I";
            }
            else if (count == 10)
            {
                FocusO();
                tx.text = "�����c�c�B�����ł����Z�������ɒN�̎d�Ƃ��c�c�I";
            }
            else if (count == 11)
            {
                cover[0].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                DOVirtual.DelayedCall(0.1f, () => cover[1].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.2f, () => cover[2].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.3f, () => cover[3].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.4f, () => cover[4].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.5f, () => cover[5].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.6f, () => cover[6].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.7f, () => cover[7].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.8f, () => cover[8].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(0.9f, () => cover[9].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
                DOVirtual.DelayedCall(1.5f, () => SceneManager.LoadScene(14));
            }
        }
        #endregion

        #region Story4_2
        else if (mode == "story4_2")
        {
            if (count == 0)
            {
                FocusO();
                tx.text = "���̂����c�c���c�c�A��͂肱����{���ł͂Ȃ��̂��c�c�H";
            }
            else if (count == 1)
            {
                FocusO();
                tx.text = "���Ƃ���Ηz�����c�c�B�������j���[�������E�t�H�[�X���@�@�@�@�@�{���̍U�������m�o���Ȃ��ȏ�́c�c�B";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "�����̌ڋq�̃V�X�e������A�ُ�����A���^�C�����蓮�Ł@�@�@�@�@��������͕̂s�\�ɓ������B";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "�����܂łȂ̂��c�c�H";
            }
            else if (count == 4)
            {
                for (int i = 0; i <= 9; i++)
                {
                    cover[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                }
                DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(0));
            }
        }
        #endregion

        #region Story5
        else if (mode == "story5")
        {
            if (count == 0)
            {
                FocusOther("�l������");
                tx.text = "����΂�́B";
            }
            else if (count == 1)
            {
                FocusM();
                tx.text = "�����A�v�����ĉ��ł����H";
            }
            else if (count == 2) 
            {
                FocusOther("�l������");
                tx.text = "�Z�p�ۂ���A���������āA�j���[�������E�t�H�[�X�̍X�V�������@�@�@�������Ă�����A�����̈ꕔ���������Ă����炵���B";
            }
            else if (count == 3)
            {
                FocusOther("�l������");
                tx.text = "�����I�ɓ����̋Z�p�ے��A��̏햱�̐l���j���[�������E�t�H�[�X�́@�蕿������肵������A�Z�p�ێЈ��̑�ʑސE�������������Ȃ񂾂��c�c�B";
            }
            else if (count == 4)
            {
                FocusOther("�l������");
                tx.text = "���̎��̒S���̈�l���N�������͂����B��|���肪�~�����ĂȁA�@�@�@�����o���Ă��邱�Ƃ͂Ȃ����ȁH";
            }
            else if (count == 5)
            {
                FocusM();
                tx.text = "�i�����������c�c�H���̍��̂��Ƃ͂��܂�v���o�������Ȃ���ˁc�c�@�ł��j���[�������E�t�H�[�X���������񂾂̂͌��킸�����ȁc�c�B�c�c���H�j";
            }
            else if (count == 6)
            {
                FocusM();
                tx.text = "�܂����I";
            }
            else if (count == 7)
            {
                FocusOther("�l������");
                tx.text = "�ǂ������}�Ɂc�c�B";
            }
            else if (count == 8)
            {
                FocusM();
                tx.text = "�܂��m�؂͎��Ă܂��񂪁A���̐�������������΁c�c�c�c";
            }
            else if (count == 9)
            {
                FocusM();
                tx.text = "�j���[�������E�t�H�[�X�́u�����v�������Ă��܂��B";
            }
            else if (count == 10)
            {
                for (int i = 0; i <= 9; i++)
                {
                    cover[i].transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f);
                }
                DOVirtual.DelayedCall(1, () => SceneManager.LoadScene(0));
            }
            //else if (count == 9)
            //{
            //    FocusO();
            //    tx.text = "�x�@����A�u�j���[�������E�t�H�[�X�̃T�[�r�X���񋟂���Ă���@�@��ƂɃT�C�o�[�U�����W�����Ă���v�ƘA�����󂯂܂��āc�c�B";
            //}

            //else if (count == 10)
            //{
            //    FocusO();
            //    tx.text = "�T�C�o�[�ƍߑ΍�ۂ��T�[�r�X�̔Еz���[�g�𐸍����Ă��܂����A�@�@�����瑤�ɗ����x������\���������ł��B";
            //}
            //else if (count == 11)
            //{
            //    FocusO();
            //    tx.text = "�V�X�e������d�ɂ��m�F���Ă���|���肪�͂߂��B";
            //}
        }
        #endregion
    }
}
