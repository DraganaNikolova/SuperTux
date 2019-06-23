# SuperTux
Windows Forms Project by: Dragana Nikolova and Mario Boshkovski

1. Опис на апликацијата:
Оваа игра е приближно слична со веќе постоечката игра Super Tux, малку променета и додадени различен вид пречки и препреки.


2. Упатство за користење:
  2.1 Како се игра (HOW TO PLAY)
  На почетниот прозорец при стартување на оваа игра имаме две опции за одбирање. Првата опција е да го одбереме копчето
  "Како се игра" (HOW TO PLAY). Со притискање на ова копче се отвара нов прозор во кој е објаснето што треба да се прави во оваа игра
  и која е нејзината цел. Целта е главниот лик односно пингвинот да стигнете до својата куќа и да се спаси од непријателите.
  По својот пат пингвинот ќе налета на боцки кои му одземаат живот, лилјаци кои истотака одземаат живот како и топче со боцки кое треба 
  да го одбегне. Покрај стигањето во својата куќа, корисникот треба да се потруди да собере што е можно повеќе парички до целта.
    
  2.2 Почеток на игра (START GAME)
  Со одбирање за започнување на нова игра на корисникот му се дава можност да ја одбере тежината на играта дали таа ќе биде
  - Easy
  - Hard
  
  Контролите за оваа игра се стрелките на тастатурата за движење како и користењето на Space за пингвинот да скока по пречките.
  Доколку стигне до својата куќа и ги собере сите 16 парички тогаш тој е победник и го завршува нивото.
  Во случај на губење на сите три животи се појавува прозор во кој го прашува корисникот дали сака да започне да игра повторно.
  Целиот овој предизвик треба да биде завршен во временски интервал од 300 секунди односно 5 минути. 
  
  
 3. Претставување на проблемот
  Техничкиот дел на апликацијата се состои од неколку прозори од кој еден е главен во кој е главната активност и движењето на пингвинот.
  Во оваа форма искористени се 6 тајмери секој со своја цел. 
  
  Во голем дел е искористена колизија односно секој допир на пингивнот со било кој објект да се запази. Со блоковите да не може да се удира,
  а со пречките кои одземаат живот тоа да биде сакнционирано. Запазено е и паѓањето на пингивнот после секој скок
  
  Би издвоиле еден дел во кој доколку пингвинот стигне до некоја препрека која го убива ќе му го одземе животот.
  
            //kolizija so nekoja od preprekite koi go ubivaat
            foreach (PictureBox o in obstacles)
            {
                bool flag = false;
                Rectangle r = new Rectangle();
                r.Location = o.Location;
                r.Size = o.Size;
                if (penguin.Bounds.IntersectsWith(r))
                {
                    flag = true;

                }
                if (flag)
                {
                    Lifes -= 1;
                    timerLife.Stop();
                    Refresh();
                    newGame();
                }
            }
            
     На горниот дел од екранот се поставени вредностите за преостанатото време, бројот на парички и бројот на животи.
