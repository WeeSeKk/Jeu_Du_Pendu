using Microsoft.VisualBasic;
using System;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Xml.Serialization;

namespace Jeu_du_Pendu
{
    public class IHM 
    {  
        // Affiche regles du jeu et titre
        static public void regleEtTitre()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("*************                                   ************");
            Console.WriteLine("*************           Jeu du pendu            ************");
            Console.WriteLine("*************                                   ************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("                                                            ");
            Console.WriteLine("                                                            ");          
            Console.WriteLine("Trouvez le mot mystère avant que le pendu ne soit complet   ");
            Console.WriteLine("Vous ne pouvez taper qu'une lettre à la fois                ");  
            Console.WriteLine("                                                            ");
            Console.WriteLine("                                                            ");   
        }
        //Si partie gagne
        static public void win()
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("*************                                   ************");
            Console.WriteLine("*************              GAGNE                ************");
            Console.WriteLine("*************                                   ************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("                                                            ");
            Console.WriteLine("le mot était " + Program.motChoisiString                     );
            Console.WriteLine("                                                            ");
        }
        //Si partie perdu
        static public void loose()
        {
            Console.WriteLine("                                                            ");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("*************                                   ************");
            Console.WriteLine("*************              PERDU                ************");
            Console.WriteLine("*************                                   ************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("                                                            ");
            Console.WriteLine("le mot était " + Program.motChoisiString                     );
            Console.WriteLine("                                                            ");
        }

        //Affiche le pendu et le lettres deja tapées 
        static public void affichagePendu()
        {
            Program.badLetter = string.Concat(Program.mauvaiseLettres);

            if (Program.essaisRestants == 10)
            {
            System.Console.WriteLine("                                             " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("                                             " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("                                             ");
            System.Console.WriteLine("*********************************************");
            }
            if (Program.essaisRestants == 9)
            {
            System.Console.WriteLine("                                             " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *                                " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");
            }
            if (Program.essaisRestants == 8)
            {
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *                                " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");
            }
            if (Program.essaisRestants == 7)
            {
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *                            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                              ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");
            }              
            if (Program.essaisRestants == 6)
            {               
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *               *            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                 *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");                                         
            }
            if (Program.essaisRestants == 5)
            {               
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *               *            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                 *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                 *   *          ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");                                         
            }
            if (Program.essaisRestants == 4)
            {               
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *               *            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                 *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                 *   *          ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");                                         
            }
            if (Program.essaisRestants == 3)
            {               
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *               *            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                 *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                 *   *          ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                 * *            ");
            System.Console.WriteLine("            *               *   *            ");
            System.Console.WriteLine("            *              *    *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");                                         
            }
            if (Program.essaisRestants == 2)
            {               
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *               *            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                 *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                 *   *          ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                 * * *          ");
            System.Console.WriteLine("            *               *   *   *        ");
            System.Console.WriteLine("            *              *    *    *       ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");                                         
            }
            if (Program.essaisRestants == 1)
            {               
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *               *            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                 *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                 *   *          ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                 * * *          ");
            System.Console.WriteLine("            *               *   *   *        ");
            System.Console.WriteLine("            *              *    *    *       ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  *             ");
            System.Console.WriteLine("            *                 *              ");
            System.Console.WriteLine("            *                *               ");
            System.Console.WriteLine("            *               *                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");                                         
            }
            if (Program.essaisRestants == 0)
            {               
            System.Console.WriteLine("            *********************            " + "Tappez |menu| pour revenir à l'écran titre");
            System.Console.WriteLine("            *   *               *            " + "Lettres déja tapées : " + Program.badLetter);
            System.Console.WriteLine("            * *                 *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                 *   *          ");
            System.Console.WriteLine("            *                  ***           ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                 * * *          ");
            System.Console.WriteLine("            *               *   *   *        ");
            System.Console.WriteLine("            *              *    *    *       ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                   *            ");
            System.Console.WriteLine("            *                  * *           ");
            System.Console.WriteLine("            *                 *   *          ");
            System.Console.WriteLine("            *                *     *         ");
            System.Console.WriteLine("            *               *       *        ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("            *                                ");
            System.Console.WriteLine("*********************************************");                                         
            }
        }  
        //Affiche les lettres trouvées
        static public void showletter()
        {  
            Program.motComplet = string.Concat(Program.lettresTrouve);

            foreach(char letter in Program.motChoisiString)
            {   
                if(Program.motComplet.Contains(letter))
                {
                    System.Console.WriteLine(letter);
                }
                if(Program.motChoisiString.Contains(Program.lettreChoisie) && !Program.motComplet.Contains(Program.lettreChoisie))
                {
                    if(Program.lettreChoisie.Contains(letter))
                    {
                        System.Console.WriteLine(letter);
                    }       
                }  
                if(!Program.motComplet.Contains(letter))  
                {
                    System.Console.WriteLine("_");
                }
            }
        } 
        //Selection du mode de jeu
        static public void modeDeJeu()
        {
            Console.Clear();
            System.Console.WriteLine("                                                          *********************                         *********************            "); 
            System.Console.WriteLine("                                                          *   *               *                         *   *               *            "); 
            System.Console.WriteLine("                                                          * *                 *                         * *                 *            ");
            System.Console.WriteLine("                                                          *                   *                         *                   *            ");
            System.Console.WriteLine("                                                          *                                             *                  ***           ");
            System.Console.WriteLine("                                                          *                                             *                 *   *          ");
            System.Console.WriteLine("                                                          *                                             *                  ***           ");
            System.Console.WriteLine("                                                          *                                             *                   *            ");
            System.Console.WriteLine("                                                          *                                             *                 * *            ");
            System.Console.WriteLine("                                                          *                                             *               *   *            ");
            System.Console.WriteLine("                                                          *                                             *              *    *            ");
            System.Console.WriteLine("                                                          *                                             *                   *            ");
            System.Console.WriteLine("                                                          *                                             *                   *            ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("                                                          *                                             *                                ");
            System.Console.WriteLine("********************************************* ********************************************* *********************************************");
            System.Console.WriteLine("                                                                                                                                         ");
            System.Console.WriteLine("                  ********                                    ****       **                                    *****                     ");
            System.Console.WriteLine("                  ********                                    **  **     **                                    **  ***                   ");
            System.Console.WriteLine("                  **                                          **   **    **                                    **    ***                 ");
            System.Console.WriteLine("                  *****                                       **    **   **                                    **    ***                 ");
            System.Console.WriteLine("                  **                                          **     **  **                                    **    ***                 ");
            System.Console.WriteLine("                  **                                          **      ** **                                    **  ***                   ");
            System.Console.WriteLine("                  **                                          **       ****                                    *****                     ");
            System.Console.WriteLine("                                                                                                                                         ");
            System.Console.WriteLine("                                                                                                                                         ");
            
            
            System.Console.WriteLine("Voulez-vous jouer en mode FACILE, NORMAL ou DIFFICILE?");
            System.Console.WriteLine("Tappez F pour mode FACILE N pour mode NORMAL ou D pour mode DIFFICILE");   
        } 
        static public void showMessage(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}