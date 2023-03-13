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
        txFocus.text = "マチルダ";
        alphaBlackM = 1;
        alphaBlackO = 0.5f;
        SetAlpha();
    }
    void FocusO()
    {
        txFocus.text = "オスカー";
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
                tx.text = "……。";
            }
            else if (count == 1)
            {
                FocusO();
                alphaOOn = false;
                tx.text = "お疲れ様です、マチルダ先輩。何の動画見てるんですか？";
            }
            else if (count == 2)
            {
                FocusM();
                tx.text = "顧客向けの販促動画の最新版よ。　　　　　　　　　　　　　　　　　うちの主力サービス「ニューメラル・フォース」のね。";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "ああ、もう共有されていたんですね。僕にも見せてください。";
            }
            else if (count == 4)
            {
                FocusM();
                tx.text = "はい、どうぞ。……言っておくけど、　　　　　　　　　　　　　　　例によって変わり映えはしないわよ？";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "もう知名度だけで新規開拓できるらしいですからね。　　　　　　　　同業他社も追随できないと聞きます。";
            }
            else if (count == 6)
            {
                FocusO();
                tx.text = "さて、動画のほうは……。";
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
                tx.text = "まあ、通常運転って感じですね。";
            }
            else if (count == 1)
            {
                FocusM();
                tx.text = "そうね。";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "そう言えば、「ニューメラル・フォース」って今の例の常務が　　　　開発プロジェクトを主導してたらしいですね。　　　　　　　　　　　当時はどんな感じだったんですか？";
            }
            else if (count == 3)
            {
                FocusM();
                alphaMOn = false;
                tx.text = "さあね、私には知る由もないわ。";
            }
            else if (count == 4)
            {
                FocusO();
                alphaMOn = true;
                tx.text = "え、待っ……どこ行くんですかー？";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "えぇーー……？？";
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
                tx.text = "この度は、サイバーセキュリティシステム「ニューメラル・フォース」の運用をご検討頂き、誠にありがとうございます。";
            }
            else if (count == 1)
            {
                tx.text = "本システムは、不正アクセスを数字で可視化し、シンプルな操作でサイバー攻撃への　　対応を可能にするものです。";
            }
            else if (count == 2)
            {
                cover[0].SetActive(true);
                tx.text = "それでは、「ニューメラル・フォース」の　使用方法をご説明させて頂きます。";
            }
            else if (count == 3)
            {
                cover[0].SetActive(false);
                cover[1].SetActive(true);
                tx.text = "これは「ライフ」です。　　　　　　　　　下側が自分、上側が相手のライフとなります。";
            }
            else if (count == 4)
            {
                cover[0].SetActive(false);
                cover[1].SetActive(true);
                tx.text = "相手のライフを0にすれば勝利です。";
            }
            else if (count == 5)
            {
                cover[0].SetActive(true);
                cover[1].SetActive(false);
                tx.text = "画面左上では、どちら側のターンかが　　　確認できます。";
            }
            else if (count == 6)
            {
                cover[1].SetActive(false);
                tx.text = "自分のターンが来るたびに操作を行い、　　敵を撃破しましょう。";
            }
            else if (count == 7)
            {
                cover[0].SetActive(true);
                cover[1].SetActive(true);
                tx.text = "自分のターンでは、「召喚」と「進軍」の　どちらかを行います。";
            }
            else if (count == 8)
            {
                cover[3].SetActive(true);
                tx.text = "早速、まずは「召喚」を行ってみましょう。";
            }
            else if (count == 9)
            {
                cover[3].SetActive(false);
                tx.text = "召喚ボタンから任意の数字を選び、　　　　好きなマスに「召喚」してみましょう。　　(Nextボタンを押して開始)";
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
                tx.text = "召喚が完了しました。";
            }
            else if (count == 12)
            {
                cover[0].SetActive(false);
                cover[4].SetActive(false);
                tx.text = "数字が大きいほど駒は強力になりますが、　召喚した数字だけライフが減少するので　　注意しましょう。";
            }
            else if (count == 13)
            {
                cover[0].SetActive(true);
                cover[4].SetActive(true);
                tx.text = "次は「進軍」についてです。";
            }
            else if (count == 14)
            {
                cover[4].SetActive(false);
                tx.text = "召喚された自分の数字をクリックすると、　「進軍」できるマスが光ります。";
            }
            else if (count == 15)
            {
                cover[4].SetActive(true);
                tx.text = "「進軍」できる方向は、上・右上・左上の　3方向です。";
            }
            else if (count == 16)
            {
                cover[4].SetActive(true);
                tx.text = "実際に「進軍」を行ってみましょう。　　　(Nextボタンを押して開始)";
            }
            else if (count == 17)
            {
                camvas.SetActive(false);
            }
            else if (count == 18)
            {
                camvas.SetActive(true);
                tx.text = "進軍が完了しました。";
            }
            else if (count == 19)
            {
                tx.text = "進軍先に敵がいれば、数字を差し引きあい、0になると消滅します。";
            }
            else if (count == 20)
            {
                tx.text = "進軍先に味方がいれば、数字が合計され　　一つの駒となります。";
            }
            else if (count == 21)
            {
                tx.text = "では最後に、相手のライフを0にして　　　　勝利しましょう。";
            }
            else if (count == 22)
            {
                tx.text = "自分の数字を最も奥の列に進軍させると、　相手のライフが－5されます。";
            }
            else if (count == 23)
            {
                tx.text = "この時使用した駒の数字は、　　　　　　　ライフへのダメージ量に影響しないことに　ご注意下さい。";
            }
            else if (count == 24)
            {
                tx.text = "それでは、　　　　　　　　　　　　　　　良いサイバーセキュリティ生活を！";
            }
            else if (count == 25)
            {
                tx.text = "(Nextボタンを押して　　　　　　　　　　　ニューメラル・フォースの実行を再開)";
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
                tx.text = "西暦21xx年。";
            }
            else if (count == 1)
            {
                tx.text = "情報通信技術は飛躍的に進歩し、全人類にとってネットワークは　　　日常生活に深く根ざすものとなって久しい。";
            }
            else if (count == 2)
            {
                tx.text = "だがそれに伴い要求される専門技術は細分化され、　　　　　　　　　少子高齢化も相俟って技術者の不足は深刻なものだった。";
            }
            else if (count == 3)
            {
                tx.text = "追い打ちを掛けるように、ネットのセキュリティや法整備の穴をついたサイバー犯罪が増加。";
            }
            else if (count == 4)
            {
                tx.text = "インターネット技術の凋落は時間の問題だった。";
            }
            else if (count == 5)
            {
                tx.text = "しかし、突如としてそれらの脅威は終焉を迎える。";
            }
            else if (count == 6)
            {
                tx.text = "理由は「ニューメラル・フォース」の普及である。";
            }
            else if (count == 7)
            {
                tx.text = "優秀なサイバー攻撃の検知・駆除システムはもとより、　　　　　　　手動では、専門知識を有さずともサイバー攻撃への干渉が可能。";
            }
            else if (count == 8)
            {
                tx.text = "カスタマーサービスによるバックアップも充実。　　　　　　　　　　即時性・柔軟性・操作性を兼ね備える代物であった。";
            }
            else if (count == 9)
            {
                tx.text = "無名のベンチャー企業がそのサービスの提供を始めるやいなや、　　　音もなくサイバー犯罪は駆逐されていった……";
            }
            else if (count == 10)
            {
                tx.text = "はずだった。";
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
                tx.text = "こんばんは、オスカーさん。何用でここに？";
            }
            else if (count == 1)
            {
                FocusO();
                tx.text = "先日見つかった、顧客企業の社内システムの　　　　　　　　　　　　脆弱性の解決方法について相談が……";
            }
            else if (count == 2)
            {
                FocusM();
                tx.text = "人事に技術の相談なんて可笑しいわね。";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "それはそうですが……マチルダ先輩は例外です。";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "かつての技術部の「唯一の生き字引」じゃないですか。";
            }
            else if (count == 5)
            {
                FocusM();
                tx.text = "私を買い被りすぎよ、何年前の話だと思っているの？";
            }
            else if (count == 6)
            {
                FocusO();
                tx.text = "実際に技量が今の技術職からも……ん？";
            }
            else if (count == 7)
            {
                FocusM();
                tx.text = "どうぞ、お入り下さい。";
            }
            else if (count == 8)
            {
                FocusOther("技術課社員");
                tx.text = "失礼します。オスカー課長、緊急です。顧客企業に不正なアクセスが　検知されまして……";
            }
            else if (count == 9)
            {
                FocusO();
                tx.text = "なんだって？";
            }
            else if (count == 10)
            {
                FocusM();
                tx.text = "……緊急らしいし、行ってあげなさい。顧客第一よ。";
            }
            else if (count == 11)
            {
                FocusO();
                alphaOOn = false;
                tx.text = "申し訳ございません、失礼しました。";
            }
            else if (count == 12)
            {
                FocusM();
                alphaOOn = true;
                tx.text = "……。";
            }
            else if (count == 13)
            {
                FocusM();
                tx.text = "（「ニューメラル・フォース」にとって　　　　　　　　　　　　　　サイバー攻撃は脅威ではなくなった。）";
            }
            else if (count == 14)
            {
                FocusM();
                tx.text = "（現に半数以上の実例が、弊社が協力するまでもなく　　　　　　　　サイバー攻撃への対処を完了しているし……。）";
            }
            else if (count == 15)
            {
                FocusM();
                tx.text = "（もはやサイバー攻撃の検知数自体が大きく低下する一強状態。）";
            }
            else if (count == 16)
            {
                FocusM();
                tx.text = "（わざわざ緊急に呼び出すほどの規模のサイバー攻撃？　　　　　　　このタイミングに？）";
            }
            else if (count == 17)
            {
                FocusM();
                tx.text = "……胸騒ぎがするわね。";
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
                tx.text = "状況は？";
            }
            else if (count == 1)
            {
                FocusOther("技術課社員");
                tx.text = "〇×社からの緊急通報で、コールセンターのオペレーターとも連携して　対応に当たっています。";
            }
            else if (count == 2)
            {
                FocusOther("技術課社員");
                tx.text = "既存の防衛システムで捌けてはいますが、短時間に大量のアクセスも　　集中しています。";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "分かった。俺は同時多発的な攻撃に備えて社内から応援を要請する。　システムで検知できない特殊な攻撃がないかどうかも引き続き　　　　監視してくれ。";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "サイバー攻撃発生源の逆探知に人員を割きすぎないように。　　　　　体制に余力を残しておいた方がいい。";
            }
            else if (count == 5)
            {
                FocusOther("技術課社員");
                tx.text = "はい！";
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
                tx.text = "攻撃が止んだな……。思ったより拍子抜けだったが。";
            }
            else if (count == 1)
            {
                FocusOther("技術課社員");
                tx.text = "はい。しかし変ですね。";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "変……ていうのはどういう意味で？";
            }
            else if (count == 3)
            {
                FocusOther("技術課社員");
                tx.text = "かなり無意味な攻撃も多く混ざっていたと思います。　　　　　　　　サイバー犯罪自体、ニューメラル・フォースの前ではほぼ無意味と　　言われる時代ですよ？";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "どうせ嫌がらせだろう。";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "いまごろ先方には被害届作成に必要な情報が手元に来ているはずだ。　警察に提供する情報をまとめておくように。";
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
                tx.text = "一体どうなってるんだ……？";
            }
            else if (count == 1)
            {
                alphaMOn = false;
                FocusM();
                tx.text = "いつになく険しい顔をしてるわね。";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "おはようございます。いや、ちょっと問題が……。";
            }
            else if (count == 3)
            {
                FocusM();
                tx.text = "問題……。先日のサイバー攻撃は収束したはずよね？　　　　　　　　この前アドバイスした社内システムの脆弱性の件かしら？";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "いや、そのいずれの企業でもない別の企業です。";
            }
            else if (count == 5)
            {
                FocusO();
                tx.text = "しかも社内データに実害を受けたようで……。　　　　　　　　　　　かなりまずいことになってます……！";
            }
            else if (count == 6)
            {
                FocusM();
                tx.text = "侵入経路は？";
            }
            else if (count == 7)
            {
                FocusO();
                tx.text = "それが分からないんです、痕跡がひとつ残らず消されていたんですよ。素人の仕業じゃありません。";
            }
            else if (count == 8)
            {
                FocusO();
                tx.text = "なにより気がかりなのは、「サイバー攻撃を受けた」という警告すら　ニューメラル・フォースが出さなかったことです。";
            }
            else if (count == 9)
            {
                FocusM();
                tx.text = "ニューメラル・フォースの更新プログラムに不具合は？";
            }

            else if (count == 10)
            {
                FocusO();
                tx.text = "今のところ異常は見つかっていません。";
            }
            else if (count == 11)
            {
                FocusO();
                tx.text = "ですが警察から、「ニューメラル・フォースのサービスが　　　　　　提供されている企業にサイバー攻撃が集中している」と連絡を受けまして……。";
            }

            else if (count == 12)
            {
                FocusO();
                tx.text = "サイバー犯罪対策課がサービスの頒布ルートを精査していますが、　　こちら側に落ち度がある可能性が高いです。";
            }
            else if (count == 13)
            {
                FocusM();
                tx.text = "そう……。……ごめんなさい、時間取らせたわね。";
            }
            else if (count == 14)
            {
                alphaOOn = false;
                FocusO();
                tx.text = "いえいえ。お互いお仕事がんばりましょう！";
            }
            else if (count == 15)
            {
                alphaOOn = true;
                FocusM();
                tx.text = "……。";
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
                tx.text = "手口が分からない……。どうすれば……。";
            }
            else if (count == 1)
            {
                FocusOther("技術課社員");
                tx.text = "課長、営業部からのクレームはどうしますか？";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "ああ……分かった、対応する。";
            }
            else if (count == 3)
            {
                alphaMOn = false;
                FocusM();
                tx.text = "人事からちょっと文句を言おうと思って来たのだけれど、　　　　　　随分な騒ぎね。";
            }
            else if (count == 4)
            {
                FocusO();
                tx.text = "マチルダ先輩……！";
            }
            else if (count == 5)
            {
                FocusM();
                tx.text = "勤怠管理をしていて驚いたわ。";
            }
            else if (count == 6)
            {
                FocusM();
                tx.text = "長時間労働と成果は同義ではないのよ？";
            }
            else if (count == 7)
            {
                FocusM();
                tx.text = "人員の補強だってタダじゃない。こちらから出来ることにも　　　　　限りがあるわ。";
            }
            else if (count == 8)
            {
                FocusO();
                tx.text = "すいません。僕の不手際で……。";
            }
            else if (count == 9)
            {
                FocusOther("技術課社員");
                tx.text = "課長、ニューメラル・フォースからサイバー攻撃の警告が！";
            }
            else if (count == 10)
            {
                FocusO();
                tx.text = "ぐっ……。ただでさえ忙しい時に誰の仕業だ……！";
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
                tx.text = "しのいだ……が……、やはりこれも本命ではないのか……？";
            }
            else if (count == 1)
            {
                FocusO();
                tx.text = "だとすれば陽動作戦……。しかしニューメラル・フォースが　　　　　本命の攻撃を検知出来ない以上は……。";
            }
            else if (count == 2)
            {
                FocusO();
                tx.text = "数多の顧客のシステムから、異常をリアルタイムかつ手動で　　　　　発見するのは不可能に等しい。";
            }
            else if (count == 3)
            {
                FocusO();
                tx.text = "ここまでなのか……？";
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
                FocusOther("人事部長");
                tx.text = "こんばんは。";
            }
            else if (count == 1)
            {
                FocusM();
                tx.text = "部長、要件って何ですか？";
            }
            else if (count == 2) 
            {
                FocusOther("人事部長");
                tx.text = "技術課から連絡があって、ニューメラル・フォースの更新履歴を　　　調査していたら、履歴の一部が欠落していたらしい。";
            }
            else if (count == 3)
            {
                FocusOther("人事部長");
                tx.text = "時期的に当時の技術課長、例の常務の人がニューメラル・フォースの　手柄を横取りした挙句、技術課社員の大量退職があった時期なんだが……。";
            }
            else if (count == 4)
            {
                FocusOther("人事部長");
                tx.text = "その時の担当の一人が君だったはずだ。手掛かりが欲しくてな、　　　何か覚えていることはないかな？";
            }
            else if (count == 5)
            {
                FocusM();
                tx.text = "（履歴が欠落……？あの頃のことはあまり思い出したくないわね……　でもニューメラル・フォースを持ち込んだのは言わずもがな……。……え？）";
            }
            else if (count == 6)
            {
                FocusM();
                tx.text = "まさか！";
            }
            else if (count == 7)
            {
                FocusOther("人事部長");
                tx.text = "どうした急に……。";
            }
            else if (count == 8)
            {
                FocusM();
                tx.text = "まだ確証は持てませんが、私の推測が正しければ…………";
            }
            else if (count == 9)
            {
                FocusM();
                tx.text = "ニューメラル・フォースは「根元」が腐っています。";
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
            //    tx.text = "警察から、「ニューメラル・フォースのサービスが提供されている　　企業にサイバー攻撃が集中している」と連絡を受けまして……。";
            //}

            //else if (count == 10)
            //{
            //    FocusO();
            //    tx.text = "サイバー犯罪対策課がサービスの頒布ルートを精査していますが、　　こちら側に落ち度がある可能性が高いです。";
            //}
            //else if (count == 11)
            //{
            //    FocusO();
            //    tx.text = "システムを幾重にも確認しても手掛かりが掴めず。";
            //}
        }
        #endregion
    }
}
