using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        loadingscreen,
        delen,
        ezwin,
        foutenzijngemaakt,
        foutenzijngemaakt2,
        ontsnapt,
        ontsnapt2,
        ontsnapt3,
        ontsnapt4,
        terugkeer,
        terugkeer2,
        dezelfdefout,
        dezelfdefout2,
        boss1,
        ziekenhuiswinst,
        eindelijkvrij,
        eindelijkvrij2,
        dood,
        decult,
        decult2,
    }

    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        Terminal.WriteLine("In de terminal");
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij HorrorNight.");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd");
        Terminal.WriteLine("verhaal.");
        Terminal.WriteLine("Typ start om te beginnen");
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.start:
                if (input == "start")
                {
                    StartIntro();
                }
                else if (input == "9999")
                {
                    Terminal.WriteLine("YEET you instantly died!");
                }
                else if (input == "abcd")
                {
                    Terminal.WriteLine("begin gewoon met de game domoor");
                }
                else if (input == "dead")
                {
                    Terminal.WriteLine("Typ gewoon start dombo");
                }

                break;

            case States.loadingscreen:
                if (input == "yolo")
                {
                    GegevensDelen();
                }

                break;

            case States.delen:
                if (input == "ja")
                {
                    FoutenZijnGemaakt();
                }
                else if (input == "nee")
                {
                    EZwin();
                }

                break;

            case States.foutenzijngemaakt:
                if (input == "next")
                {
                    FoutenZijnGemaakt2();
                }

                break;

            case States.foutenzijngemaakt2:
                if (input == "next")
                {
                    ontsnapt();
                }

                break;

            case States.ezwin:
                if (input == "reset")
                {
                    ShowMainMenu();
                    currentState = States.start;
                }

                break;

            case States.ontsnapt:
                if (input == "next")
                {
                    ontsnapt2();
                }

                break;

            case States.ontsnapt2:
                if (input == "next")
                {
                    ontsnapt3();
                }

                break;

            case States.ontsnapt3:
                if (input == "next")
                {
                    ontsnapt4();
                }

                break;

            case States.ontsnapt4:
                if (input == "overleefd")
                {
                    terugkeer();
                }

                break;

            case States.terugkeer:
                if (input == "next")
                {
                    terugkeer2();
                }

                break;

            case States.terugkeer2:
                if (input == "alweer")
                {
                    DezelfdeFout();
                }

                break;

            case States.dezelfdefout:
                if (input == "next")
                {
                    DezelfdeFout2();
                }

                break;

            case States.dezelfdefout2:
                if (input == "bossfight")
                {
                    BOSS();
                }

                break;

            case States.boss1:
                if (input == "vuisten")
                {
                    DeCult();
                }
                else if (input == "pistool")
                {
                    dood();
                }
                else if (input == "zakmes")
                {
                    Ziekenhuis();
                }

                break;

            case States.decult:
                if (input == "next")
                {
                    DeCult2();
                }

                break;

            case States.decult2:
                if (input == "reset")
                {
                    ShowMainMenu();
                    currentState = States.start;
                }
                else if (input == "boss")
                {
                    BOSS();
                    currentState = States.boss1;
                }

                break;

            case States.dood:
                if (input == "reset")
                {
                    ShowMainMenu();
                    currentState = States.start;
                }
                else if (input == "boss")
                {
                    BOSS();
                    currentState = States.boss1;
                }

                break;

            case States.ziekenhuiswinst:
                if (input == "next")
                {
                    vrij();
                }

                break;

            case States.eindelijkvrij:
                if (input == "next")
                {
                    vrij2();
                }

                break;

            case States.eindelijkvrij2:
                if (input == "reset")
                {
                    ShowMainMenu();
                    currentState = States.start;
                }
                else if (input == "boss")
                {
                    BOSS();
                    currentState = States.boss1;
                }

                break;
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een koude, donkere nacht.");
        Terminal.WriteLine("Een hele goede nacht om thuis op je");
        Terminal.WriteLine("laptop te gamen.");
        Terminal.WriteLine("Typ YOLO om verder te gaan");
        currentState = States.loadingscreen;
    }

    void GegevensDelen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Een speler vraagt om je Discord");
        Terminal.WriteLine("gegevens.");
        Terminal.WriteLine("Wil je deze met de speler delen?");
        Terminal.WriteLine("Typ ja om te delen");
        Terminal.WriteLine("Typ nee om niet te delen");
        currentState = States.delen;
    }

    void FoutenZijnGemaakt()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("In het begin wordt je nieuwe");
        Terminal.WriteLine("vrienden en speel je online met");
        Terminal.WriteLine("voicechat. Het gaat goed en je");
        Terminal.WriteLine("vind het leuk om samen te spelen,");
        Terminal.WriteLine("maar wat je nog niet wist is dat");
        Terminal.WriteLine("je de grootste fout van je leven");
        Terminal.WriteLine("maakt, want hij heeft wanneer");
        Terminal.WriteLine("je offline was je account gehacked");
        Terminal.WriteLine("en is achter jouw adress gekomen.");
        Terminal.WriteLine("Het is een gewone normale dag.");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.foutenzijngemaakt;
    }

    void FoutenZijnGemaakt2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent op weg van school naar");
        Terminal.WriteLine("huis wanneer je opeens een bekende");
        Terminal.WriteLine("stem achter je hoort en als je");
        Terminal.WriteLine("omkijkt zie je een reus van een");
        Terminal.WriteLine("mens staan en je zegt");
        Terminal.WriteLine("zijn spelersnaam. Hij antwoord");
        Terminal.WriteLine("luidruchtig JA DAT BEN IK. Je");
        Terminal.WriteLine("struikelt achter over van angst");
        Terminal.WriteLine("en dan zie je iets.");
        Terminal.WriteLine("Wat is dat in zijn hand?");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.foutenzijngemaakt2;
    }

    void EZwin()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("WOW dat was makkelijk je");
        Terminal.WriteLine("hebt nu al gewonnen !!!!!");
        Terminal.WriteLine("Typ reset om naar start te gaan");
        currentState = States.ezwin;
    }

    void ontsnapt()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je geloofd het nog steeds niet.");
        Terminal.WriteLine("Met grote ogen kijk je naar het");
        Terminal.WriteLine("pistool in zijn handen. Met deze");
        Terminal.WriteLine("man heb ik zitten spelen? hoe dan?");
        Terminal.WriteLine("Je komt terug op aarde en gaat kijken");
        Terminal.WriteLine("hoe kom ik hier levend weg? Je kijkt");
        Terminal.WriteLine("en kijkt en dan zie je een open weg");
        Terminal.WriteLine("naar een leeg oud gebouw. Zonder verder");
        Terminal.WriteLine("na te denken begin je met rennen.");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.ontsnapt;
    }

    void ontsnapt2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hoort grote zware voetstappen");
        Terminal.WriteLine("achter je aan komen, dus je blijft");
        Terminal.WriteLine("doorgaan door het gebouw heen tot");
        Terminal.WriteLine("je zijn voetstappen niet hoort en");
        Terminal.WriteLine("begint weer met denken. Als eerst");
        Terminal.WriteLine("begin je met de politie bellen en");
        Terminal.WriteLine("dan denk je hoe ga ik het volhouden?");
        Terminal.WriteLine("Tegen zo een groot en sterk iemand red");
        Terminal.WriteLine("ik het nog geen minuut, dus je blijft");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.ontsnapt2;
    }

    void ontsnapt3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("jezelf verstoppen. Tientallen minuten");
        Terminal.WriteLine("tikken voorbij en je hoort nog steeds");
        Terminal.WriteLine("niks, maar dan ineens wordt de deur");
        Terminal.WriteLine("achter je gebroken. Er is een pistool");
        Terminal.WriteLine("op je gericht en zonder na te denken");
        Terminal.WriteLine("spring je door het raam naast je heen.");
        Terminal.WriteLine("De pijn boeit je nu niet en je begint");
        Terminal.WriteLine("met dingen naar zijn gezicht gooien en");
        Terminal.WriteLine("dan hoor je het een politie sirene.");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.ontsnapt3;
    }

    void ontsnapt4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gooit nog 1 ding en begint met");
        Terminal.WriteLine("rennen. Gellukig ben je sneller en");
        Terminal.WriteLine("eerder buiten. De politie vangt je op");
        Terminal.WriteLine("en een paar gaan het gebouw binnen.");
        Terminal.WriteLine("Een half uur later kwamen ze weer");
        Terminal.WriteLine("naar buiten en zijden dat ze een");
        Terminal.WriteLine("groot persoon met een pistool hebben");
        Terminal.WriteLine("neergeschoten en je denkt bij jezelf");
        Terminal.WriteLine("is het voorbij?");
        Terminal.WriteLine("Typ overleefd in om verder te gaan");
        currentState = States.ontsnapt4;
    }

    void terugkeer()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("2 jaar zijn voorbij gegaan en je");
        Terminal.WriteLine("hebt je leven weer terug op het");
        Terminal.WriteLine("goede pad en je gamed ook nog.");
        Terminal.WriteLine("Je hebt bij het gamen nu een heel");
        Terminal.WriteLine("groepje gevonden, dus je ziet er");
        Terminal.WriteLine("geen problemen bij, maar wat je niet");
        Terminal.WriteLine("wist is dat dit alle vrienden waren");
        Terminal.WriteLine("van de stalker die je heeft proberen");
        Terminal.WriteLine("te doden. Je groep zegt dat er een");
        Terminal.WriteLine("event aan komt van onze game.");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.terugkeer;
    }

    void terugkeer2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je denkt leuk dan kunnen we elkaar");
        Terminal.WriteLine("ontmoeten.Het is de dag van het event");
        Terminal.WriteLine("en je gaat naar de plaats die ze hebben");
        Terminal.WriteLine("doorgegeven.Wanneer je aankomt merk je");
        Terminal.WriteLine("dat het niet druk is, maar je wist dat");
        Terminal.WriteLine("al en gaat naar de verdieping die ze");
        Terminal.WriteLine("hadden aangegeven.Je loopt naarbinnen");
        Terminal.WriteLine("maar je ziet niemand.Wat gebeurt hier?");
        Terminal.WriteLine("Typ alweer om verder te gaan");
        currentState = States.terugkeer2;
    }

    void DezelfdeFout()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je wordt vanuit achter omvergegooid");
        Terminal.WriteLine("Je hapt naar adem, terwijl je kijkt wie");
        Terminal.WriteLine("het was en je pupillen ontploffen");
        Terminal.WriteLine("bijna. Het was defelfde man als 2 jaar");
        Terminal.WriteLine("geleden, maar dat is onmogelijk. Was");
        Terminal.WriteLine("hij niet dood? Je trapt hem in de noten");
        Terminal.WriteLine("en rent naar beneden, maar als je");
        Terminal.WriteLine("beneden aankomt zijn alle deuren");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.dezelfdefout;
    }

    void DezelfdeFout2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("opslot en je denkt bij jezelf hoe kan");
        Terminal.WriteLine("ik zo dom zijn en in een val trappen.");
        Terminal.WriteLine("Typ bossfight om verder te gaan");
        currentState = States.dezelfdefout2;
    }

    void BOSS()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hoort hem naar beneden stormen,");
        Terminal.WriteLine("dus je rent een kantoor binnen om");
        Terminal.WriteLine("jezelf te verstoppen en je weet");
        Terminal.WriteLine("dat dit niet gaat ophouden totdat");
        Terminal.WriteLine("er iemand dood is. Je kijkt de");
        Terminal.WriteLine("kamer rond en ziet 3 keuzes");
        Terminal.WriteLine("Typ zakmes voor een einde");
        Terminal.WriteLine("Typ vuisten voor een einde");
        Terminal.WriteLine("Typ pistool voor een einde");
        currentState = States.boss1;
    }

    void dood()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je maakt harde geluiden om hem");
        Terminal.WriteLine("te lokken en het lukt. Hij");
        Terminal.WriteLine("stormt door de deur heen en");
        Terminal.WriteLine("je begint met schieten, maar");
        Terminal.WriteLine("wat gebeurt er nu? Er vliegen");
        Terminal.WriteLine("geen kogels uit. De man lacht");
        Terminal.WriteLine("je uit en maakt er een einde aan");
        Terminal.WriteLine("Typ reset om naar start te gaan");
        Terminal.WriteLine("Typ boss voor een andere keuze");
        currentState = States.dood;
    }

    void DeCult()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je stormt de deur uit en");
        Terminal.WriteLine("vliegt op de man af. Je gooit");
        Terminal.WriteLine("de ene klap naar de andere");
        Terminal.WriteLine("zonder te stoppen blijf je");
        Terminal.WriteLine("doorgaan totdat je uitgeput");
        Terminal.WriteLine("bent en dan kijk je omhoog en");
        Terminal.WriteLine("zie je de man naar je kijken.");
        Terminal.WriteLine("Je begint te schreeuwen en");
        Terminal.WriteLine("dan na een klap gaat alles zwart");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.decult;
    }

    void DeCult2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je wordt wakker in een vreemde");
        Terminal.WriteLine("circel en ziet allemaal mensen");
        Terminal.WriteLine("in gewaden staan. Ze roepen je");
        Terminal.WriteLine("hebt onze respect gewonnen met");
        Terminal.WriteLine("jouw gevecht tegen onze bruut.");
        Terminal.WriteLine("Kom wordt een van ons en je");
        Terminal.WriteLine("zal rust vinden. Je weet dat je");
        Terminal.WriteLine("geen keuze hebt, dus je doet mee.");
        Terminal.WriteLine("Typ reset om naar start te gaan");
        Terminal.WriteLine("Typ boss voor een andere keuze");
        currentState = States.decult2;
    }

    void Ziekenhuis()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je weet dat hij overal gaat");
        Terminal.WriteLine("checken dus je wacht bij de");
        Terminal.WriteLine("deur op een plek waar hij je");
        Terminal.WriteLine("niet kan zien en zodra hij binnen");
        Terminal.WriteLine("is steek je hem in zijn nek.");
        Terminal.WriteLine("Hij krijst en schiet in het rond.");
        Terminal.WriteLine("Je werd rood voor de ogen en");
        Terminal.WriteLine("bleef maar steken tot je zwart ging");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.ziekenhuiswinst;
    }

    void vrij()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je wordt wakker en kijkt om je");
        Terminal.WriteLine("heen en ziet dat je in een");
        Terminal.WriteLine("ziekenhuis ligt met je familie");
        Terminal.WriteLine("om je heen. Je vraagt wat is dit?");
        Terminal.WriteLine("Ze schieten omhoog en roepen");
        Terminal.WriteLine("GODZIJDANK JE BENT IN ORDE.");
        Terminal.WriteLine("Dan krijg je te horen dat je");
        Terminal.WriteLine("die man hebt gedood en bewusteloos");
        Terminal.WriteLine("bent geraakt van je verwondingen");
        Terminal.WriteLine("Typ next om verder te gaan");
        currentState = States.eindelijkvrij;
    }

    void vrij2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("JE HEBT DE MAN GEDOOD?");
        Terminal.WriteLine("JE HEBT DE MAN GEDOOD?");
        Terminal.WriteLine("JE HEBT DE MAN GEDOOD?");
        Terminal.WriteLine("Je denkt bij jezelf is het");
        Terminal.WriteLine("echt gelukt? en dan schreeuw");
        Terminal.WriteLine("je IK BEN EINDELIJK VRIJ!!!!!!!");
        Terminal.WriteLine("Typ reset om naar start te gaan");
        Terminal.WriteLine("Typ boss voor een andere keuze");
        currentState = States.eindelijkvrij2;
    }
    // Update is called once per frame

    void Update()
    {
        
    }
}
