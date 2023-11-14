using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;


    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Unit playerUnit;
    Unit enemyUnit;

    public Text dialogueText;
    public Text countdownText;

    public BattleBanner playerBanner;
    public BattleBanner enemyBanner;

    public int countdownTime;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetUpBattle());

        StartCoroutine(CountdownToStart());
    }

    IEnumerator SetUpBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();

        dialogueText.text = "A cruel" + enemyUnit.unitName + " approaches.";

        playerBanner.SetBanner(playerUnit);
        enemyBanner.SetBanner(enemyUnit);

        yield return new WaitForSeconds(2f);
        
        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyBanner.SetHP(enemyUnit.currentHP);
        dialogueText.text = "Attack Successful!";

        yield return new WaitForSeconds(2f);

       if(isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
       else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
        
    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit.unitName + "Attacks!";

        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerBanner.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if(isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }


    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogueText.text = "Battle won!";
        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = "Detective Down!";
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = " Choose an action:";
    }

    IEnumerator PlayerHeal()
    {
        playerUnit.Heal(3);

        playerBanner.SetHP(playerUnit.currentHP);
        dialogueText.text = "Strength renewed!";

        yield return new WaitForSeconds(2f);

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }

    IEnumerator PlayerBlock()
    {
        playerUnit.Block(3);

        playerBanner.SetHP(playerUnit.currentHP);
        dialogueText.text = "Attack Blocked! Strength Gained";

        yield return new WaitForSeconds(2f);

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }


    public void OnHealButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }

    public void OnBlockButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerBlock());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownText.text = "FIGHT!";

        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);
    }
}
