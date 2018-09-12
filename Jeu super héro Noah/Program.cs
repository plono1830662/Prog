using System;

namespace Jeu_super_héro_Noah
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();

            bool man = false;
            bool fin = false;
            //partie cellule
            int c1 = 0;
            int c2 = 0;
            int c3 = gen.Next(1, 3);
            int c4 = 0;
            int c5 = 0;

            //partie brisure
            int b1 = gen.Next(1, 3);
            int b2 = gen.Next(1, 3);
            int b3 = gen.Next(1, 4);
            int b4 = 0;

            //partie dodo
            int do1 = 0;
            int do2 = 0;


            //partie evasion
            int ev1 = 0;
            int ev2 = 0;
            int fa1 = 0;
            int fa2 = 0;

            //partie Hallucination
            int ha1 = 0;
            int ha2 = 0;
            int ha3 = 0;
            int ha4 = 0;
            int ha5 = 0;
            int ha6 = 0;



            //partie reveil
            int re1 = 0;
            int re2 = 0;

            //partie manger cellule
            int ma1 = 0;
            int ma2 = 0;

            //partie cour
            int cou1 = 0;

            //partie vitre
            int vi1 = 0;
            int vi2 = 0;
            int co1 = 0;
            int co2 = 0;
            int co3 = 0;
            int ba1 = 0;
            int ba2 = 0;

            //Variable pas fini
            while (fin == false)
            {

                Console.WriteLine("Tu te reveilles au beau millieu d'une prison");
                Console.WriteLine("    ||  ||  ||  ||  ||");
                Console.WriteLine("    ||  ||  ||  ||  ||");
                Console.WriteLine("    ||  ||  ||  ||  ||");
                Console.WriteLine("    ||  ||  ||  ||  ||");
                Console.WriteLine("N'ayant rien à faire ici deux options s'offre à toi:");
                Console.WriteLine("1-Se recoucher (C'est peut-être un mauvais rêve après tout!)");
                Console.WriteLine("ou");
                Console.WriteLine("2-Se lever pour voir se qu'il se passe");

                c1 = Convert.ToInt32(Console.ReadLine());
                //Dodo 1
                if (c1 == 1)
                {

                    Console.WriteLine("24 Heures plus tard vous vous reveillez, la faim vous ronge l'intérieur");
                    Console.WriteLine("1-C'est peut-être un autre cauchemar");
                    Console.WriteLine("2-Vous devez allez trouver à MANGER!!");

                    do1 = Convert.ToInt32(Console.ReadLine());
                }
                //Dodo2
                if (do1 == 1)
                {

                    Console.WriteLine(" ..... ");
                    Console.WriteLine("1-Dormir");
                    Console.WriteLine("2-Lever");

                    do2 = Convert.ToInt32(Console.ReadLine());

                    if (do2 == 1)
                    {

                        Console.WriteLine("......");
                        Console.WriteLine("1-Dormir...");
                        Console.WriteLine("....");
                        Console.WriteLine("....");
                        Console.WriteLine("....");
                        Console.WriteLine("Plongé dans un sommeil profond, vous mourez de déshydratation..");
                        Console.WriteLine("FIN");
                        fin = true;
                    }
                    else if (do2 == 2)
                    {

                        Console.WriteLine("jdbjgbskjlf");
                        Console.WriteLine("1-kjneuflsjd");
                        Console.WriteLine("2-fioheaooif");

                        ha1 = Convert.ToInt32(Console.ReadLine());

                        if (ha1 == 1)
                        {

                            Console.WriteLine("(*?($)()_=");
                            Console.WriteLine("1-/$*%*(/()");
                            Console.WriteLine("2-)$*&/%()_");

                            ha2 = Convert.ToInt32(Console.ReadLine());

                            if (ha2 == 1)
                            {
                                Console.WriteLine("Vous vous reveillez en dehors de la prison, les vètements déchirés..");
                                Console.WriteLine("FIN");
                                fin = true;
                            }
                            else if (ha2 == 2)
                            {
                                Console.WriteLine("Vous vous reveillez dans votre lit, chez vous, ce n'était peut-être qu'un rêve..");
                                Console.WriteLine("FIN");
                                fin = true;
                            }
                        }
                        else if (ha1 == 2)
                        {

                            Console.WriteLine("qwertyui");
                            Console.WriteLine("1-asdfghj");
                            Console.WriteLine("2-mnbvbcxz");

                            ha3 = Convert.ToInt32(Console.ReadLine());

                            if (ha3 == 1)
                            {
                                Console.WriteLine("Vous ne vous revillerez pas en, en fait vous vous ne reveillerez plus.. ");
                                Console.WriteLine("FIN");
                                fin = true;
                            }
                            else if (ha3 == 2)
                            {

                            }
                        }
                    }
                }
                else if (do1 == 2)
                {

                    Console.WriteLine("Vous vous levez et vous entendez une cloche");
                    Console.WriteLine("1-C'est l'heure de la pause dans la prison, tous sont demander dehors");
                    Console.WriteLine("2-La faim vous ronge, il faut trouver de la nourriture");

                    re1 = Convert.ToInt32(Console.ReadLine());

                    if (re1 == 1)
                    {

                        Console.WriteLine("Vous vous dirigez vers l'exterieur, et comme vous avez apris dans les film, il y 2  manière de survivre dans une prison");
                        Console.WriteLine("1-Devenir amis avec le plus fort de la prison");
                        Console.WriteLine("2-Ou devenir le plus fort de la prison");

                        cou1 = Convert.ToInt32(Console.ReadLine());

                        if (cou1 == 1)
                        {

                            Console.WriteLine("En approchant la table des <<Boss>>, le mur explosa et un débris vous percuta... ");
                            Console.WriteLine("FIN");
                            fin = true;
                        }
                        else if (cou1 == 2)
                        {
                            Console.WriteLine("En réflechissant à votre plan pour battre les <<Boss>>, le mur explosa");
                            Console.WriteLine("Vous vous precipitez vers le trou de la liberté quand tout à coup ,le marteau de Thor vous transpersa... ");
                            Console.WriteLine("FIN");
                            fin = true;
                        }

                    }
                    else if (re1 == 2)
                    {

                        while (man == false)
                        {



                            Console.WriteLine("Il n`y a pas des milliers d'endroit où la nourriture peut se trouver");
                            Console.WriteLine("1-Dans ta cellule");
                            Console.WriteLine("2-En dehors de ta cellule");

                            ma1 = Convert.ToInt32(Console.ReadLine());

                            if (ma1 == 1)
                            {

                                Console.WriteLine("Dans une si petite cellule, les choix sont considérablement réduit");
                                Console.WriteLine("1-Il y a une coquerelle sur le mur");
                                Console.WriteLine("2-Vous pouvez toujours attendre...");

                                ma2 = Convert.ToInt32(Console.ReadLine());

                                if (ma2 == 1)
                                {
                                    Console.WriteLine("Vous ne devriez pas manger ça ....");
                                    Console.WriteLine("Le silence se fit dans la cellule... ");
                                    Console.WriteLine("FIN");
                                    fin = true;
                                    man = true;

                                }
                                else if (ma2 == 2)
                                {
                                    Console.WriteLine("La coquerelle se faufilla dans votre bouche et vous étoufa...");
                                    Console.WriteLine("FIN");
                                    fin = true;
                                    man = true;

                                }
                            }
                            else if (ma1 == 2)
                            {
                                Console.WriteLine("Il y quelqu'un qui se fait battre dehors, vous ne voudriez pas être à sa place ");
                            }
                        }
                    }

                }
                else if (c1 == 2)
                {

                    Console.WriteLine("Tout en vous levant, vous prenez le temps d'observer votre environement");
                    Console.WriteLine("1-Quelque chose sintille dans le coin de la cellule, mais qu'est-ce que ça peut bien être?");
                    Console.WriteLine("2-Les barreaux de la fenêtre n'ont pas l'aire très solides");

                    c2 = Convert.ToInt32(Console.ReadLine());
                    if (c2 == 1)
                    {

                        Console.WriteLine("Vous approcher l'objet scintillant");

                        if (c3 == 1)
                        {
                            Console.WriteLine("Ça ma tout l'aire d'une clée");
                            Console.WriteLine("1-Elle rentre peut-être dans la serrure de ta cellule");
                            Console.WriteLine("2-Elle a l'air assez solide, vous pouvez peut-être l'utiliser comme lime");

                            c4 = Convert.ToInt32(Console.ReadLine());

                            if (c4 == 1)
                            {

                                Console.WriteLine("La porte s'ouvre avec facilité");
                                Console.WriteLine("Un garde se tiens devant vous");
                                Console.WriteLine("1-Il ne vous voit pas, vous pourriez peut-être vous faufiller..");
                                Console.WriteLine("2-L'assomer ne serrait pas sage, mais efficace");

                                ev1 = Convert.ToInt32(Console.ReadLine());

                                if (ev1 == 1)
                                {

                                    Console.WriteLine("Vous contournez le garde qui est apparament sourd et aveugle");
                                    Console.WriteLine("et devant vous, le chemin se sépare");
                                    Console.WriteLine("1-Allez à droite");
                                    Console.WriteLine("2-Allez à gauche");

                                    fa1 = Convert.ToInt32(Console.ReadLine());

                                    if (fa1 == 1)
                                    {

                                        Console.WriteLine("Vous faites un tour à droite et qui se tient devant vous?");
                                        Console.WriteLine("Un mur de garde et évidemment la seule issue est de se rendre..");
                                        Console.WriteLine("Meilleur chance la prochaine fois");
                                        Console.WriteLine("FIN");

                                        fin = true;
                                        man = true;
                                    }
                                    else if (fa1 == 2)
                                    {

                                        Console.WriteLine("Vous continuez vers la gauche");
                                        Console.WriteLine("1-Au loin, vous appercevez une sortie");
                                        Console.WriteLine("2-Il serait mieux de faire attention");

                                        fa2 = Convert.ToInt32(Console.ReadLine());

                                        if (fa2 == 1)
                                        {
                                            Console.WriteLine("Vous vous précipitez vers la sortie");
                                            Console.WriteLine("Rendue sous la porte, un engrenage tombe à votre pied");
                                            Console.WriteLine("Vous levez vos yeux et la porte vous tombe dessus");
                                            Console.WriteLine("Dommage si près du but...");
                                            Console.WriteLine("FIN");

                                            fin = true;
                                            man = true;
                                        }
                                        else if (fa2 == 2)
                                        {

                                            Console.WriteLine("En avancant avec précaution,la noirceur se fit");
                                            Console.WriteLine("En regardant vers le ciel, vous voillez un caillou géant se précipitant vers la Terre...");
                                            Console.WriteLine("FIN");

                                            fin = true;
                                            man = true;

                                        }
                                    }
                                }
                                else if (ev1 == 2)
                                {

                                    Console.WriteLine("Esperez qu'il ne se réveil pas");
                                    Console.WriteLine("Vous arrivez devant un chemin qui se sépare");
                                    Console.WriteLine("1-Allez à droite");
                                    Console.WriteLine("2-Allez à gauche");

                                    ev2 = Convert.ToInt32(Console.ReadLine());

                                    if (ev2 == 1)
                                    {
                                        Console.WriteLine("Vous arrivez devant la sortie et vous vous y précipitez");
                                        Console.WriteLine("La liberté vous appartient (c'était pas si compliqué)...");
                                        Console.WriteLine("FIN");

                                        fin = true;
                                        man = true;

                                    }
                                    else if (ev2 == 2)
                                    {
                                        Console.WriteLine("Des projecteurs se braquent sur vous");
                                        Console.WriteLine("Des gardes se tiennent devant vous");
                                        Console.WriteLine("Meilleur chance la prochaine fois");
                                        Console.WriteLine("FIN");

                                        fin = true;
                                        man = true;

                                    }
                                }

                            }
                            else if (c4 == 2)
                            {

                                Console.WriteLine("Votre idée folle a porté enfin fruit, les barreaux sont tombés ");
                                Console.WriteLine("Après 50 ans derrière les barreaux, vous allez enfin pouvoir vivre une vie normale");
                                Console.WriteLine("1-Retournez chez vous");
                                Console.WriteLine("2-Retournez chez vous?");

                                c5 = Convert.ToInt32(Console.ReadLine());

                                if (c5 == 1)
                                {

                                    Console.WriteLine("Vous retournez à votre ancienne maison et y restez pour le reste de vos jours.. ");
                                    Console.WriteLine("FIN");
                                    fin = true;
                                }
                                else if (c5 == 2)
                                {

                                    Console.WriteLine("Vous décidez de rester vivre dans la prison qui est maintenant votre logement permanent..");
                                    Console.WriteLine("FIN");
                                    fin = true;
                                }
                            }
                        }
                        else if (c3 > 1)
                        {
                            Console.WriteLine("Ce n'est qu'un petit morceau de verre");
                            Console.WriteLine("1-Vous devriez le garder, ça peut toujours servir");
                            Console.WriteLine("2-Un plan vous vient en tête...");

                            vi1 = Convert.ToInt32(Console.ReadLine());

                            if (vi1 == 1)
                            {

                                Console.WriteLine("Avec cette arme, plus rien ne se tiendra dans votre passage");
                                Console.WriteLine("En parlant de passage, un garde s'approche de votre cellule");
                                Console.WriteLine("1-L'attaquer");
                                Console.WriteLine("2-L'approché discrètement");

                                vi2 = Convert.ToInt32(Console.ReadLine());

                                if (vi2 == 1)
                                {
                                    Console.WriteLine("En vous précipitant sur lui il se retourne et vous donne un bon coup sur la tête...");
                                }
                                else if (vi2 == 2)
                                {
                                    Console.WriteLine("Vous approché le garde et vous le poignardez avec la vitre");
                                    Console.WriteLine("Avec un meutre dans vos mains, vous ne devez pas vous faire prendre");
                                    Console.WriteLine("Vous arrivez devant un chemin qui se sépare");
                                    Console.WriteLine("1-Allez à droite");
                                    Console.WriteLine("2-Allez à gauche");

                                    ba2 = Convert.ToInt32(Console.ReadLine());

                                    if (ba2 == 1)
                                    {
                                        Console.WriteLine("Vous arrivez devant la sortie et vous vous y précipitez");
                                        Console.WriteLine("La liberté vous appartient (c'était pas si compliqué)...");
                                        Console.WriteLine("FIN");

                                        fin = true;
                                        man = true;

                                    }
                                    else if (ba2 == 2)
                                    {
                                        Console.WriteLine("Des projecteurs se braquent sur vous");
                                        Console.WriteLine("Des gardes se tiennent devant vous");
                                        Console.WriteLine("Meilleur chance la prochaine fois");
                                        Console.WriteLine("FIN");

                                        fin = true;
                                        man = true;

                                    }
                                }
                            }
                            else if (vi1 == 2)
                            {
                                Console.WriteLine("Vous prennez le morceau de verre et vous vous coupez avec");
                                Console.WriteLine("1-Vous appelez de l'aide");
                                Console.WriteLine("2-Chercher des bandages");

                                co1 = Convert.ToInt32(Console.ReadLine());

                                if (co1 == 1)
                                {
                                    Console.WriteLine("En entendant vos cris de détresse, les gardes vous approche");
                                    Console.WriteLine("Ils vous prenent et ce précipitent vers l'infirmerie");
                                    Console.WriteLine("1-Rester couché dans le lit");
                                    Console.WriteLine("2-se lever pendant que les gardes se préocupent de d'autre chose");


                                    co2 = Convert.ToInt32(Console.ReadLine());

                                    if (co2 == 1)
                                    {

                                    }
                                    else if (co2 == 2)
                                    {
                                        Console.WriteLine("En vous levant, un objet pointu se plante dans votre pied");
                                        Console.WriteLine("Vous commencez à vous sentir...");
                                        Console.WriteLine("jdbjgbskjlf");
                                        Console.WriteLine("1-kjneuflsjd");
                                        Console.WriteLine("2-fioheaooif");

                                        ha4 = Convert.ToInt32(Console.ReadLine());

                                        if (ha4 == 1)
                                        {

                                            Console.WriteLine("(*?($)()_=");
                                            Console.WriteLine("1-/$*%*(/()");
                                            Console.WriteLine("2-)$*&/%()_");

                                            ha5 = Convert.ToInt32(Console.ReadLine());

                                            if (ha5 == 1)
                                            {
                                                Console.WriteLine("Vous vous reveillez en dehors de la prison, les vètements déchirés..");
                                                Console.WriteLine("FIN");
                                                fin = true;
                                                man = true;
                                            }
                                            else if (ha5 == 2)
                                            {
                                                Console.WriteLine("Vous vous reveillez dans votre lit, chez vous, ce n'était peut-être qu'un rêve..");
                                                Console.WriteLine("FIN");
                                                fin = true;
                                                man = true;
                                            }
                                        }
                                        else if (ha4 == 2)
                                        {

                                            Console.WriteLine("jkgnkjgn");
                                            Console.WriteLine("1-asdfghj");
                                            Console.WriteLine("2-mnbvbcxz");

                                            ha6 = Convert.ToInt32(Console.ReadLine());

                                            if (ha6 == 1)
                                            {
                                                Console.WriteLine("Vous ne vous revillerez pas en, en fait vous vous ne reveillerez plus.. ");
                                                Console.WriteLine("FIN");
                                                fin = true;
                                                man = true;
                                            }
                                            else if (ha6 == 2)
                                            {

                                            }

                                        }
                                    }
                                }
                                else if (co1 == 2)
                                {
                                    Console.WriteLine("En voyant que vous saignez les gardes vous escorte à l'infirmerie");
                                    Console.WriteLine("1-Les attaquer");
                                    Console.WriteLine("2-Les suivre");

                                    co3 = Convert.ToInt32(Console.ReadLine());

                                    if (co3 == 1)
                                    {
                                        Console.WriteLine("Vous donnez un coup aux premier garde qui lui tombe au sol");
                                        Console.WriteLine("Le deuxième garde vous fonce dessus");
                                        Console.WriteLine("1-Esquiver");
                                        Console.WriteLine("2-Contre Attaquer");

                                        ba1 = Convert.ToInt32(Console.ReadLine());

                                        if (ba1 == 1)
                                        {
                                            Console.WriteLine("Vous esquivez, mais vous tombez dans les pommes à cause de votre coupure...");
                                        }
                                        else if (ba1 == 2)
                                        {
                                            Console.WriteLine("Vous essayer de contre attaquez mais vous tombez dans les pommes à cause de votre coupure...");
                                        }

                                    }
                                    else if (co3 == 2)
                                    {
                                        Console.WriteLine("Les gardes arrêtent de marché spontanément");
                                        Console.WriteLine("Les deux se tournèrent vers vous");
                                        Console.WriteLine("D'un coup de matraque vous ètes OUT");
                                    }
                                }
                            }
                        }

                    }
                    else if (c2 == 2)
                    {

                        Console.WriteLine("Vous vous rapprocher de barreaux de votre cellule");
                        Console.WriteLine("Vous commencez à forcer sur ceux ci");

                        if (b1 == 1)
                        {
                            Console.WriteLine("Dottez d'une force Herculéene, vous brisez les bareaux sans même forcer");
                            Console.WriteLine("Vous regardez par cette fenêtre, et vous voillez la rue");

                            if (b2 == 1)
                            {
                                Console.WriteLine("Puisse que vous ètes un grand joueur de THE ESCAPIST, vous vous construisez une corde avec vos draps ");
                                Console.WriteLine("Vous procèdez ensuite à la descente de la prison, 13 étages ça ne se descendera pas tout seul");

                                if (b3 == 1)
                                {
                                    Console.WriteLine("Arrivez au milieu, un bras vous attrape la jambe");
                                    Console.WriteLine("1-Vous débattre");
                                    Console.WriteLine("2-Vous laisser faire");

                                    b4 = Convert.ToInt32(Console.ReadLine());

                                    if (b4 == 1)
                                    {

                                        Console.WriteLine("En vous débattant, la corde se fend et vous tombez...");
                                        Console.WriteLine("FIN");
                                        fin = true;
                                        man = true;
                                    }
                                    else if (b4 == 2)
                                    {
                                        Console.WriteLine("L'homme vous lache et vous arrivez en bas en toute sécurité...");
                                        Console.WriteLine("FIN");
                                        fin = true;
                                        man = true;

                                    }
                                }
                                else if (b3 == 2)
                                {
                                    Console.WriteLine("Aucune intempérie ne c'est produite durant votre descente et vous vous échappez sans problème..");
                                    Console.WriteLine("FIN");
                                    fin = true;
                                    man = true;

                                }
                                else if (b3 == 3)
                                {
                                    Console.WriteLine("Arrivé au milieu de la descente, la corde se coupa...");
                                    Console.WriteLine("FIN");
                                    fin = true;
                                    man = true;
                                }
                            }
                            else if (b2 == 2)
                            {
                                Console.WriteLine("Puisse que vous n'ètes pas le plus brillant de tous, vous dessidez de sauter, tout simplement ");
                                Console.WriteLine("A ma surprise, la chute ne vous tue pas, mais je n'en dit pas autant de la voiture qui vous fonce dessus...");
                                Console.WriteLine("FIN");
                                fin = true;
                                man = true;

                            }

                        }
                        else if (b1 == 2)
                        {
                            Console.WriteLine("Dessue de votre piètre performance, vous vous recouchez dans votre lit");
                        }

                    }
                }


            }


            //Lever 1









            Console.ReadKey();
        }
    }
}
